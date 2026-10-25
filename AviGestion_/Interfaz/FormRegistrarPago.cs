using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormRegistrarPago : Form
    {
        private const string SUGERENCIA = "Filtrar por N°Pedido, Cliente, Fecha, Estado o Productos";
        private static readonly Color VERDE = Color.FromArgb(46, 125, 50);

        private PagoPedidoLogica pagosLogica = new PagoPedidoLogica();
        private PagoPedido pedidoSeleccionado;
        private List<PagoPedido> listaOriginalPedidos = new List<PagoPedido>();
        private Usuario usuarioActual;

        public FormRegistrarPago(Usuario usuarioActual) //Nuevo form
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            LimpiarPanelPago();
        }

        #region Cargar la pantalla
        private void FormRegistrarPago_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();
            cboMetodoPago.Items.AddRange(PagoPedidoLogica.MetodosPago);
            EstiloGrilla(dgvListadoPedidos);
            dgvListadoPedidos.MultiSelect = false;
            dgvListadoPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoPedidos.Cursor = Cursors.Hand;
            dgvListadoPedidos.CellDoubleClick += (s, ev) => { if (ev.RowIndex >= 0) CargarPedidoSeleccionado(ev.RowIndex); };

            EstiloBoton(btnConfirmarPago, VERDE, Color.White);
            EstiloBoton(btnCancelarPago, Color.White, Color.FromArgb(160, 0, 0));

            lblAyuda.Text = "Doble clic en un pedido para registrar su pago. Se aceptan pagos parciales.";
            lblAyuda.ForeColor = Color.FromArgb(91, 107, 79);
            lblAyuda.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPedidoCliente.ForeColor = VERDE;

            txtBuscar.Text = SUGERENCIA;
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            CargarPedidos();

        }
        
        private void ConfigurarColumnasGrilla()
        {
            dgvListadoPedidos.AutoGenerateColumns = false;
            if (dgvListadoPedidos.Columns.Contains("colIdPedido")) dgvListadoPedidos.Columns["colIdPedido"].DataPropertyName = "NºPedido";
            if (dgvListadoPedidos.Columns.Contains("colCliente")) dgvListadoPedidos.Columns["colCliente"].DataPropertyName = "Cliente";
            if (dgvListadoPedidos.Columns.Contains("colFecha")) dgvListadoPedidos.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvListadoPedidos.Columns.Contains("colProductos")) dgvListadoPedidos.Columns["colProductos"].DataPropertyName = "Productos";
            if (dgvListadoPedidos.Columns.Contains("colTotal")) dgvListadoPedidos.Columns["colTotal"].DataPropertyName = "Total";
            if (dgvListadoPedidos.Columns.Contains("colSaldoPendiente")) dgvListadoPedidos.Columns["colSaldoPendiente"].DataPropertyName = "SaldoPendiente";
            if (dgvListadoPedidos.Columns.Contains("colEstado")) dgvListadoPedidos.Columns["colEstado"].DataPropertyName = "Estado";

            if (dgvListadoPedidos.Columns.Contains("colMetodoPago"))
                dgvListadoPedidos.Columns["colMetodoPago"].DataPropertyName = "MetodoPago";

            foreach (string nombre in new[] { "colTotal", "colSaldoPendiente" })
                if (dgvListadoPedidos.Columns.Contains(nombre))
                {
                    dgvListadoPedidos.Columns[nombre].DefaultCellStyle.Format = "C2";
                    dgvListadoPedidos.Columns[nombre].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
        }

        private void CargarPedidos()
        {
            try
            {
                listaOriginalPedidos = pagosLogica.ObtenerPedidosParaPagos();
                AplicarFiltro();                       // mantiene el filtro que haya escrito el usuario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado de deudas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Filtro
        private void txtBuscar_TextChanged(object sender, EventArgs e) { AplicarFiltro(); }
        private void AplicarFiltro()
        {
            if (listaOriginalPedidos == null) return; 
            string texto = txtBuscar.Text.Trim().ToLower();

            List<PagoPedido> lista = listaOriginalPedidos;
            if (texto.Length > 0 && txtBuscar.Text != SUGERENCIA)
            {
                lista = new List<PagoPedido>();
                foreach (PagoPedido ped in listaOriginalPedidos)
                {
                    if (ped.NºPedido.ToString().Contains(texto) ||
                        (ped.Cliente ?? "").ToLower().Contains(texto) ||
                        Convert.ToString(ped.Fecha).ToLower().Contains(texto) ||
                        (ped.Productos ?? "").ToLower().Contains(texto) ||
                        (ped.Estado ?? "").ToLower().Contains(texto))
                        lista.Add(ped);
                }
            }
            dgvListadoPedidos.DataSource = null;
            dgvListadoPedidos.DataSource = lista;
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == SUGERENCIA) { txtBuscar.Text = ""; txtBuscar.ForeColor = Color.Black; }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = SUGERENCIA; txtBuscar.ForeColor = Color.Gray; }
        }
        #endregion

        #region Doble clic: cargar el pedido (solo carga, nunca confirma)
        private void CargarPedidoSeleccionado(int indiceFila)
        {
            pedidoSeleccionado = (PagoPedido)dgvListadoPedidos.Rows[indiceFila].DataBoundItem;

            HabilitarPago(true);                  // habilita la franja: campo de importe y botones
            lblPedidoCliente.Text = $"Pedido Nº {pedidoSeleccionado.NºPedido} · {pedidoSeleccionado.Cliente}";
            lblTotalPedido.Text = pedidoSeleccionado.Total.ToString("C2");
            lblSaldoPendiente.Text = pedidoSeleccionado.SaldoPendiente.ToString("C2");
            lblCapImporte.Text = "IMPORTE A ABONAR (máx. " + pedidoSeleccionado.SaldoPendiente.ToString("C2") + ")";

            nudImporte.Minimum = 0;
            nudImporte.Maximum = 999999999;
            nudImporte.Value = 0;
            nudImporte.Focus();
            nudImporte.Select(0, nudImporte.Text.Length);

            cboMetodoPago.SelectedIndex = 0;   // Efectivo por defecto
        }

        private void HabilitarPago(bool habilitado)
        {
            nudImporte.Enabled = habilitado;
            cboMetodoPago.Enabled = habilitado;
            btnConfirmarPago.Enabled = habilitado;
        }
        //Deja la franja sin pedido cargado y deshabilitada
        private void LimpiarPanelPago()
        {
            pedidoSeleccionado = null;
            lblPedidoCliente.Text = "Sin pedido seleccionado";
            lblTotalPedido.Text = "$ 0,00";
            lblSaldoPendiente.Text = "$ 0,00";
            lblCapImporte.Text = "IMPORTE A ABONAR";
            nudImporte.Value = 0;
            cboMetodoPago.SelectedIndex = -1;
            dgvListadoPedidos.ClearSelection();
            HabilitarPago(false);
        }
        #endregion

        #region Botones 
        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un pedido de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal importeABonar = nudImporte.Value;

                if (importeABonar <= 0)
                {
                    MessageBox.Show("Ingresá un monto mayor a cero.", "Validación Comercial",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (importeABonar > pedidoSeleccionado.SaldoPendiente)
                {
                    MessageBox.Show($"El monto ({importeABonar:C2}) supera el saldo pendiente ({pedidoSeleccionado.SaldoPendiente:C2}). Corregí el importe.",
                                    "Validación Comercial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudImporte.Focus();
                    return;                                    // no se registra nada y el importe queda para corregirlo
                }
                if (cboMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná un método de pago.", "Validación Comercial",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMetodoPago.Focus();
                    return;
                }
                string metodoPago = cboMetodoPago.SelectedItem.ToString();
                if (MessageBox.Show($"¿Registrar un pago de {importeABonar:C2} ({metodoPago}) para el pedido Nº {pedidoSeleccionado.NºPedido}?",
                                    "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                splitPagos.Panel2.Enabled = false;             // evita un segundo clic mientras se procesa
                pagosLogica.RegistrarPago(pedidoSeleccionado.NºPedido, importeABonar, metodoPago);
                MessageBox.Show("El pago fue registrado correctamente en la base de datos.", "Pago Registrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPedidos();
                LimpiarPanelPago();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación Comercial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarPedidos();
                LimpiarPanelPago();                            // el saldo pudo cambiar: se vuelve a cargar el pedido
            }
            catch (Exception ex)
            {
                splitPagos.Panel2.Enabled = true;              // falló: se puede reintentar
                MessageBox.Show("Error al procesar el abono: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            LimpiarPanelPago();
        }
        #endregion

        #region Estilo (verde 46; 125; 50)
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

        // Botón plano que se ve gris cuando está deshabilitado (también si lo deshabilita su panel)
        private void EstiloBoton(Button b, Color fondo, Color texto)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.UseVisualStyleBackColor = false;
            Action pintar = () =>
            {
                b.BackColor = b.Enabled ? fondo : Color.Gainsboro;
                b.ForeColor = b.Enabled ? texto : Color.Gray;
            };
            pintar();                                          // estado inicial (la franja arranca deshabilitada)
            b.EnabledChanged += (s, ev) => pintar();
        }

        #endregion

    }
}
