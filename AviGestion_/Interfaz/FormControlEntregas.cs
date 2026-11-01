using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormControlEntregas : Form
    {
        private readonly Usuario usuarioActual;
        private readonly EntregaLogica negocio = new EntregaLogica();

        private DataTable tablaCamiones;
        private int idVehiculoSeleccionado = 0;
        private string patenteSeleccionada = "";
        private string rutaComprobante = null;     

        private static readonly Color Verde = Color.FromArgb(46, 125, 50);
        private static readonly Color Naranja = Color.OrangeRed;

        public FormControlEntregas(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        // Carga inicial
        private void FormControlEntregas_Load(object sender, EventArgs e)
        {
            dgvPedidosCamion.ReadOnly = false;     

            try
            {
                txtBuscar.Text = "Filtrar por nro de Pantente, Vehículo o Estado";
                txtBuscar.ForeColor = Color.Gray;
                cboResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
                cboResponsable.DataSource = negocio.ListarResponsables();
                cboResponsable.DisplayMember = "Nombre";
                cboResponsable.ValueMember = "Id";
                cboResponsable.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarCamiones();
            LimpiarPanel();
        }

        #region Grilla de camiones (arriba)
        private void CargarCamiones()
        {
            try
            {
                tablaCamiones = negocio.ListarCamionesEnCamino();
                dgvCamiones.DataSource = tablaCamiones;

                dgvCamiones.Columns["Id"].Visible = false;
                dgvCamiones.Columns["Vehiculo"].HeaderText = "Vehículo";
                dgvCamiones.Columns["Pedidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCamiones.Columns["Cajones"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                AplicarBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los camiones: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por patente, vehículo o estado
        private void AplicarBusqueda()
        {
            if (tablaCamiones == null) return;
            if (txtBuscar.Text == "Filtrar por nro de Pantente, Vehículo o Estado" || txtBuscar.Text.Trim() == "")
            {
                tablaCamiones = negocio.ListarCamionesEnCamino();
                dgvCamiones.DataSource = tablaCamiones;
                return;
            }
            string texto = txtBuscar.Text.Trim().Replace("'", "''");
            tablaCamiones.DefaultView.RowFilter = texto == ""
                ? ""
                : "Patente LIKE '%" + texto + "%' OR Vehiculo LIKE '%" + texto + "%' OR Estado LIKE '%" + texto + "%'";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarBusqueda();
        }

        private void dgvCamiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AbrirCamionSeleccionado(e.RowIndex);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            // Si el usuario hace clic y todavía está el texto de sugerencia, se borra y cambia la letra en negro
            if (txtBuscar.Text == "Filtrar por nro de Pantente, Vehículo o Estado")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            // Si el usuario hace clic afuera y no escribió nada, vuelve a poner la sugerencia gris
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "F r por nro de Pantente, Vehículo o Estado";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void cboResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarResumen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
        }

        #endregion

        #region Panel inferior: pedidos del camión elegido
        private void AbrirCamionSeleccionado(int indiceFila = -1)
        {
            DataGridViewRow filaGrilla = indiceFila >= 0 ? dgvCamiones.Rows[indiceFila] : dgvCamiones.CurrentRow;
            DataRowView fila = filaGrilla == null ? null : filaGrilla.DataBoundItem as DataRowView;

            if (fila == null)
            {
                MessageBox.Show("No se pudo leer el camión seleccionado. Elegí una fila de la lista.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                idVehiculoSeleccionado = Convert.ToInt32(fila["Id"]);
                patenteSeleccionada = fila["Patente"].ToString();

                dgvPedidosCamion.DataSource = negocio.ListarPedidosDelCamion(idVehiculoSeleccionado);

                dgvPedidosCamion.Columns["Entregado"].HeaderText = "Entregado";
                dgvPedidosCamion.Columns["Id_Pedido"].HeaderText = "N°";
                dgvPedidosCamion.Columns["Cajas"].HeaderText = "Cajones";
                dgvPedidosCamion.Columns["Cajas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Solo el tilde se puede tocar
                foreach (DataGridViewColumn col in dgvPedidosCamion.Columns)
                    col.ReadOnly = col.Name != "Entregado";

                rutaComprobante = null;
                lblArchivo.Text = "Sin imagen adjunta";
                cboResponsable.SelectedIndex = -1;
                lblTituloEntrega.Text = "Camión " + patenteSeleccionada + " · Registrar entrega";

                if (grbEntrega.Parent != dgvCamiones.Parent)
                    dgvCamiones.Parent.Controls.Add(grbEntrega);
                grbEntrega.Location = new Point(dgvCamiones.Left, lblAyuda.Bottom + 8);
                grbEntrega.Width = dgvCamiones.Width;

                grbEntrega.Visible = true;
                grbEntrega.BringToFront();

                foreach (DataGridViewRow f in dgvPedidosCamion.Rows)
                    PintarEstado(f);

                ActualizarResumen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los pedidos del camión: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al tildar o destildar: el cambio se confirma al instante y se actualiza el estado
        private void dgvPedidosCamion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPedidosCamion.IsCurrentCellDirty)
                dgvPedidosCamion.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvPedidosCamion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPedidosCamion.Columns[e.ColumnIndex].Name != "Entregado") return;

            DataGridViewRow fila = dgvPedidosCamion.Rows[e.RowIndex];
            bool entregado = Convert.ToBoolean(fila.Cells["Entregado"].Value);
            fila.Cells["Estado"].Value = entregado ? "Entregado" : "En preparación";

            PintarEstado(fila);
            ActualizarResumen();
        }

        // Los no entregados se ven en naranja y negrita
        private void PintarEstado(DataGridViewRow fila)
        {
            bool entregado = Convert.ToBoolean(fila.Cells["Entregado"].Value);
            DataGridViewCellStyle estilo = fila.Cells["Estado"].Style;
            estilo.ForeColor = entregado ? Color.Black : Naranja;
            estilo.Font = entregado ? dgvPedidosCamion.Font : new Font(dgvPedidosCamion.Font, FontStyle.Bold);
        }

        // Resumen, mensaje de ayuda y habilitación del botón Confirmar
        private void ActualizarResumen()
        {
            int total = 0, entregados = 0, cajasTotal = 0, cajasEntregadas = 0;
            List<string> vuelven = new List<string>();

            foreach (DataGridViewRow fila in dgvPedidosCamion.Rows)
            {
                int cajas = Convert.ToInt32(fila.Cells["Cajas"].Value);
                bool entregado = Convert.ToBoolean(fila.Cells["Entregado"].Value);

                total++;
                cajasTotal += cajas;
                if (entregado) { entregados++; cajasEntregadas += cajas; }
                else vuelven.Add("#" + fila.Cells["Id_Pedido"].Value);
            }

            lblResumen.Text = entregados + " de " + total + " pedidos entregados · "
                            + cajasEntregadas + " de " + cajasTotal + " cajones"
                            + (vuelven.Count > 0 ? " · vuelven a En preparación: " + string.Join(", ", vuelven) : "");

            bool hayResponsable = cboResponsable.SelectedIndex >= 0;
            bool hayImagen = rutaComprobante != null;
            bool listo = total > 0 && hayResponsable && (entregados == 0 || hayImagen);

            if (total == 0) lblMensaje.Text = "";
            else if (!hayResponsable) lblMensaje.Text = "Elegí el responsable de la entrega.";
            else if (entregados > 0 && !hayImagen) lblMensaje.Text = "Adjuntá la imagen del comprobante.";
            else lblMensaje.Text = "Listo para confirmar.";

            lblMensaje.ForeColor = listo ? Verde : Naranja;
            btnConfirmarEntrega.Enabled = listo;
        }
        #endregion
        
        #region Comprobante (imagen)
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Comprobante de entrega";
                dialogo.Filter = "Imágenes (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

                if (dialogo.ShowDialog() != DialogResult.OK) return;

                try
                {
                    negocio.ValidarImagen(dialogo.FileName);    // formato, tamaño y que sea una imagen real
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rutaComprobante = dialogo.FileName;
                lblArchivo.Text = Path.GetFileName(rutaComprobante) + " · " + (new FileInfo(rutaComprobante).Length / 1024) + " KB";
                ActualizarResumen();
            }
        }
        #endregion
       
        #region Confirmar / cancelar
        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            List<int> entregados = new List<int>();
            List<int> noEntregados = new List<int>();

            foreach (DataGridViewRow fila in dgvPedidosCamion.Rows)
            {
                int idPedido = Convert.ToInt32(fila.Cells["Id_Pedido"].Value);
                if (Convert.ToBoolean(fila.Cells["Entregado"].Value)) entregados.Add(idPedido);
                else noEntregados.Add(idPedido);
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirmás la entrega del camión " + patenteSeleccionada + "?\n\n"
                + "• Pedidos entregados: " + entregados.Count + "\n"
                + "• Pedidos que vuelven a \"En preparación\": " + noEntregados.Count + "\n\n"
                + "El camión queda disponible en el depósito.",
                "Confirmar entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                int idResponsable = Convert.ToInt32(cboResponsable.SelectedValue);
                negocio.RegistrarEntrega(idVehiculoSeleccionado, idResponsable, entregados, noEntregados, rutaComprobante);

                BitacoraLogica.Registrar(usuarioActual.Nombre,
                    "Registró la entrega del vehículo " + patenteSeleccionada + ": " + entregados.Count
                    + " entregado(s), " + noEntregados.Count + " vuelven a En preparación", "Pedidos");

                MessageBox.Show("La entrega fue registrada correctamente.", "Entrega registrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarPanel();
                CargarCamiones();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar la entrega", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarPanel();
                CargarCamiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarPanel()
        {
            idVehiculoSeleccionado = 0;
            patenteSeleccionada = "";
            rutaComprobante = null;

            dgvPedidosCamion.DataSource = null;
            cboResponsable.SelectedIndex = -1;
            lblArchivo.Text = "Sin imagen adjunta";
            lblResumen.Text = "";
            lblMensaje.Text = "";
            btnConfirmarEntrega.Enabled = false;
            grbEntrega.Visible = false;
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            //Ventana principal completa(si este formulario está dentro de un panel, TopLevelControl es la ventana de afuera)
            Form principal = this.TopLevelControl as Form ?? this;

            // Capa oscura semitransparente sobre toda la pantalla, para que el historial "flote" encima
            using (Form velo = new Form())
            {
                velo.FormBorderStyle = FormBorderStyle.None;
                velo.BackColor = Color.Black;
                velo.Opacity = 0.45;
                velo.ShowInTaskbar = false;
                velo.StartPosition = FormStartPosition.Manual;
                velo.Bounds = principal.Bounds;
                velo.Show(principal);

                using (FormHistorialEntrega historial = new FormHistorialEntrega())
                {
                    historial.ShowDialog(velo);      
                }
            }
        }
        #endregion
    }
}
