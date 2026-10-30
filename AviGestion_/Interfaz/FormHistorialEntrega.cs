using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.Interfaz
{
    // Ventana flotante con el historial de entregas.
    public partial class FormHistorialEntrega : Form
    {
        private readonly EntregaLogica negocio = new EntregaLogica();
        private DataTable tablaHistorial;
        private bool cargando = false;     

        public FormHistorialEntrega()
        {
            InitializeComponent();
        }

        private void FormHistorialEntregas_Load(object sender, EventArgs e)
        {

            // Por defecto: últimos 30 días, sin poder elegir fechas futuras
            cargando = true;
            dtpDesde.MaxDate = DateTime.Today;
            dtpHasta.MaxDate = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            cargando = false;

            CargarHistorial();
        }

        // ---------------------------------------------------------------
        // Carga de la lista de entregas
        // ---------------------------------------------------------------
        private void CargarHistorial()
        {
            if (cargando) return;

            try
            {
                tablaHistorial = negocio.ListarHistorial(dtpDesde.Value, dtpHasta.Value);
                dgvHistorial.DataSource = tablaHistorial;

                dgvHistorial.Columns["Id_Entrega"].HeaderText = "N°";
                dgvHistorial.Columns["FechaHora"].HeaderText = "Fecha y hora";
                dgvHistorial.Columns["FechaHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvHistorial.Columns["Vehiculo"].HeaderText = "Vehículo";
                dgvHistorial.Columns["NoEntregados"].HeaderText = "No entregados";

                foreach (string col in new[] { "Pedidos", "Entregados", "NoEntregados" })
                    dgvHistorial.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvHistorial.Columns["Id_Entrega"].FillWeight = 6;
                dgvHistorial.Columns["FechaHora"].FillWeight = 15;
                dgvHistorial.Columns["Patente"].FillWeight = 10;
                dgvHistorial.Columns["Vehiculo"].FillWeight = 22;
                dgvHistorial.Columns["Responsable"].FillWeight = 16;
                dgvHistorial.Columns["Pedidos"].FillWeight = 8;
                dgvHistorial.Columns["Entregados"].FillWeight = 9;
                dgvHistorial.Columns["NoEntregados"].FillWeight = 10;
                dgvHistorial.Columns["Comprobante"].FillWeight = 10;

                AplicarBusqueda();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fechas no válidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el historial: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por patente, vehículo o responsable y actualiza el resumen
        private void AplicarBusqueda()
        {
            if (tablaHistorial == null) return;

            string texto = txtBuscar.Text.Trim().Replace("'", "''");
            tablaHistorial.DefaultView.RowFilter = texto == ""
                ? ""
                : "Patente LIKE '%" + texto + "%' OR Vehiculo LIKE '%" + texto + "%' OR Responsable LIKE '%" + texto + "%'";

            ActualizarResumen();
            MostrarDetalle();
        }

        private void ActualizarResumen()
        {
            int entregas = 0, pedidos = 0, entregados = 0, noEntregados = 0;

            foreach (DataRowView fila in tablaHistorial.DefaultView)
            {
                entregas++;
                pedidos += Convert.ToInt32(fila["Pedidos"]);
                entregados += Convert.ToInt32(fila["Entregados"]);
                noEntregados += Convert.ToInt32(fila["NoEntregados"]);
            }

            lblResumenHistorial.Text = entregas + " entrega(s) · " + pedidos + " pedido(s): "
                                     + entregados + " entregados, " + noEntregados + " no entregados";
        }

        // ---------------------------------------------------------------
        // Detalle de la entrega seleccionada
        // ---------------------------------------------------------------
        private void MostrarDetalle()
        {
            DataRowView fila = dgvHistorial.CurrentRow == null ? null : dgvHistorial.CurrentRow.DataBoundItem as DataRowView;

            if (fila == null)
            {
                dgvDetalleEntrega.DataSource = null;
                lblDetalleTitulo.Text = "Seleccioná una entrega para ver sus pedidos";
                btnVerComprobante.Enabled = false;
                return;
            }

            try
            {
                int idEntrega = Convert.ToInt32(fila["Id_Entrega"]);
                lblDetalleTitulo.Text = "Entrega N° " + idEntrega + " · " + fila["Patente"] + " · Pedidos";

                dgvDetalleEntrega.DataSource = negocio.ListarDetalleEntrega(idEntrega);

                dgvDetalleEntrega.Columns["Entregado"].Visible = false;
                dgvDetalleEntrega.Columns["Id_Pedido"].HeaderText = "N°";
                dgvDetalleEntrega.Columns["Cajas"].HeaderText = "Cajones";
                dgvDetalleEntrega.Columns["Cajas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalleEntrega.Columns["EstadoActual"].HeaderText = "Estado actual del pedido";

                // Los pedidos que no se entregaron se destacan en naranja
                foreach (DataGridViewRow f in dgvDetalleEntrega.Rows)
                {
                    bool entregado = Convert.ToBoolean(f.Cells["Entregado"].Value);
                    f.Cells["Resultado"].Style.ForeColor = entregado ? Color.Black : Color.OrangeRed;
                }

                // Solo se puede ver el comprobante si la entrega tiene uno
                btnVerComprobante.Enabled = fila["Comprobante"].ToString() == "Sí";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el detalle: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // Ver el comprobante (imagen)
        // ---------------------------------------------------------------
        private void btnVerComprobante_Click(object sender, EventArgs e)
        {
            DataRowView fila = dgvHistorial.CurrentRow == null ? null : dgvHistorial.CurrentRow.DataBoundItem as DataRowView;
            if (fila == null) return;

            try
            {
                string nombre;
                byte[] imagen = negocio.ObtenerComprobante(Convert.ToInt32(fila["Id_Entrega"]), out nombre);
                MostrarImagen(imagen, nombre ?? "comprobante");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Sin comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el comprobante: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ventana simple con la imagen (se arma por código: no necesita Designer)
        private void MostrarImagen(byte[] bytes, string titulo)
        {
            MemoryStream flujo = new MemoryStream(bytes);
            Image imagen = Image.FromStream(flujo);

            Form visor = new Form();
            visor.Text = "Comprobante · " + titulo;
            visor.Size = new Size(800, 600);
            visor.StartPosition = FormStartPosition.CenterParent;
            visor.ShowInTaskbar = false;

            PictureBox caja = new PictureBox();
            caja.Dock = DockStyle.Fill;
            caja.SizeMode = PictureBoxSizeMode.Zoom;
            caja.Image = imagen;
            visor.Controls.Add(caja);

            visor.FormClosed += (s, ev) => { caja.Image = null; imagen.Dispose(); flujo.Dispose(); };
            visor.ShowDialog(this);
        }

        // ---------------------------------------------------------------
        // Eventos del Designer (asignarlos desde Propiedades > rayo)
        // ---------------------------------------------------------------
        private void dtpFiltro_ValueChanged(object sender, EventArgs e)     // dtpDesde y dtpHasta (ValueChanged)
        {
            CargarHistorial();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)      // txtBuscar (TextChanged)
        {
            AplicarBusqueda();
        }

        private void dgvHistorial_SelectionChanged(object sender, EventArgs e)   // dgvHistorial (SelectionChanged)
        {
            MostrarDetalle();
        }

        private void btnCerrar_Click(object sender, EventArgs e)            // btnCerrar (Click)
        {
            this.Close();
        }
    }
}
 
