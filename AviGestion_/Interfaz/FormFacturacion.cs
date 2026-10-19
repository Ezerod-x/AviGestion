using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace AviGestion_.Interfaz
{
    public partial class FormFacturacion : Form
    {
        private FacturacionLogica negocio = new FacturacionLogica();
        private int idPedidoSeleccionado = 0;
        private Usuario usuarioActual;
        private static readonly Color VERDE = Color.FromArgb(46, 125, 50);


        public FormFacturacion(Usuario usuarioActual)//nuevo form
        {
            InitializeComponent();
            CenterToParent();
            this.usuarioActual = usuarioActual;
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                EstiloGrilla(dgvListadoCompra);
                dgvListadoCompra.MultiSelect = false;
                dgvListadoCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvListadoCompra.Cursor = Cursors.Hand;
                dgvListadoCompra.CellDoubleClick += (s, ev) => { if (ev.RowIndex >= 0) CargarPedido(ev.RowIndex); };

                EstiloGrilla(dgvDetalle);

                EstiloBoton(btnConfirmarDespacho, VERDE, Color.White);
                EstiloBoton(btnCancelarFactura, Color.White, Color.FromArgb(160, 0, 0));

                lblAyuda.Text = "Doble clic en un pedido para cargar su detalle.";
                lblAyuda.ForeColor = Color.FromArgb(91, 107, 79);
                lblAyuda.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
                lblPedidoCliente.ForeColor = VERDE;

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            dgvListadoCompra.AutoGenerateColumns = true;
            dgvListadoCompra.DataSource = negocio.ListarPedidosPendientes();

            // Columnas que no aportan en este módulo (todos son 'Pendiente', sin pagos)
            if (dgvListadoCompra.Columns["Estado"] != null) dgvListadoCompra.Columns["Estado"].Visible = false;
            if (dgvListadoCompra.Columns["SaldoPendiente"] != null) dgvListadoCompra.Columns["SaldoPendiente"].Visible = false;

            if (dgvListadoCompra.Columns["NºPedido"] != null)
            {
                dgvListadoCompra.Columns["NºPedido"].HeaderText = "Nº";
                dgvListadoCompra.Columns["NºPedido"].FillWeight = 40;
            }
            if (dgvListadoCompra.Columns["Total"] != null)
            {
                dgvListadoCompra.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvListadoCompra.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Doble clic o Enter sobre una fila: SOLO carga el detalle, no confirma nada
        private void CargarPedido(int indiceFila)
        {
            try
            {
                DataGridViewRow fila = dgvListadoCompra.Rows[indiceFila];
                idPedidoSeleccionado = Convert.ToInt32(fila.Cells["NºPedido"].Value);
                string cliente = fila.Cells["Cliente"].Value.ToString();

                DataTable detalles = negocio.ListarDetallesDelPedido(idPedidoSeleccionado);
                detalles.Columns.Add("Subtotal", typeof(decimal));

                decimal importeTotal = 0;
                foreach (DataRow r in detalles.Rows)
                {
                    decimal sub = Convert.ToInt32(r["Cantidad"]) * Convert.ToDecimal(r["PrecioUnitario"]);
                    r["Subtotal"] = sub;
                    importeTotal += sub;
                }

                dgvDetalle.DataSource = detalles;
                dgvDetalle.Columns["PrecioUnitario"].HeaderText = "Precio unit.";
                dgvDetalle.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

                lblPedidoCliente.Text = $"Pedido Nº {idPedidoSeleccionado} · {cliente}";
                lblTotalPagar.Text = "$ " + importeTotal.ToString("N2");

                btnConfirmarDespacho.Enabled = true;     // ahora hay algo que confirmar
                btnCancelarFactura.Enabled = true;
            }
            catch (Exception ex)
            {
                LimpiarCampos();
                MessageBox.Show("No se pudo cargar el detalle del pedido: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Deja la pantalla sin pedido cargado y sin detalle de compra, con botones deshabilitados.
        //Se llama al cancelar o al confirmar despacho.
        private void LimpiarCampos()
        {
            idPedidoSeleccionado = 0;
            lblPedidoCliente.Text = "Sin pedido cargado";
            lblTotalPagar.Text = "$ 0,00";
            dgvDetalle.DataSource = null;
            dgvListadoCompra.ClearSelection();
            btnConfirmarDespacho.Enabled = false;
            btnCancelarFactura.Enabled = false;
        }

        private void btnConfirmarDespacho_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un pedido de la lista antes de continuar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirma = MessageBox.Show(
                $"¿Confirmar la facturación y el despacho del Pedido Nº {idPedidoSeleccionado} por {lblTotalPagar.Text}?",
                "Confirmación de Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;
            btnConfirmarDespacho.Enabled = false;        // evita un segundo clic mientras se procesa

            try
            {
                switch (negocio.ConfirmarDespacho(idPedidoSeleccionado))
                {
                    case ResultadoDespacho.Exito:
                        MessageBox.Show("La compra fue registrada correctamente. El pedido quedó listo para que Logística lo asigne a un camión.",
                                        "Despacho confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case ResultadoDespacho.CompraYaRegistrada:
                        MessageBox.Show("La compra ya fue registrada. La operación se cancela.",
                                        "Compra ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ResultadoDespacho.PedidoNoDisponible:
                        MessageBox.Show("El pedido ya fue procesado o cancelado por otro usuario. Se actualiza el listado.",
                                        "Pedido ya procesado o cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                btnConfirmarDespacho.Enabled = true;     // si falló, se puede reintentar
                MessageBox.Show("Error técnico: " + ex.Message, "Falla de Comunicación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ---- Estilo (verde 46; 125; 50) ----
        private void EstiloGrilla(DataGridView g)
        {
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.RowHeadersVisible = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = VERDE;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        // Botón plano que se ve gris cuando está deshabilitado
        private void EstiloBoton(Button b, Color fondo, Color texto)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.UseVisualStyleBackColor = false;
            b.BackColor = fondo;
            b.ForeColor = texto;
            b.EnabledChanged += (s, ev) =>
            {
                b.BackColor = b.Enabled ? fondo : Color.Gainsboro;
                b.ForeColor = b.Enabled ? texto : Color.Gray;
            };
        }
    }
}
