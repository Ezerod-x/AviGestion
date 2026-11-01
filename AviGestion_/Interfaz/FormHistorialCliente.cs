using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.Interfaz
{
    public partial class FormHistorialCliente : Form
    {
        private HistorialClienteLogica historialLogica = new HistorialClienteLogica();
        private int idClienteN;
        private List<HistorialPedido> listaOriginalPedidos = new List<HistorialPedido>();

        public FormHistorialCliente(int idCliente, string nombreCompleto, string contacto, string direccion)
        {
            InitializeComponent();
            
            idClienteN = idCliente;
            // Valores de los labels de datos del cliente
            lblClienteValor.Text = nombreCompleto;
            lblContactoValor.Text = contacto;
            lblDireccionValor.Text = direccion;
            // Configuración básica de la grilla
            dgvHistorial.MultiSelect = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CenterToParent();
        }

        private void FormHistorialCliente_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();
            CargarDatosPantalla();

            // Seteo inicial del Placeholder de búsqueda
            txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
            txtBusqueda.ForeColor = Color.Gray;

            // Eventos para simular el comportamiento de Placeholder en la caja de texto
            txtBusqueda.Enter += txtBusqueda_Enter;
            txtBusqueda.Leave += txtBusqueda_Leave;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvHistorial.AutoGenerateColumns = false;
            if (dgvHistorial.Columns.Contains("colN")) dgvHistorial.Columns["colN"].DataPropertyName = "NumeroFila";

            // Corregimos "NºPedido" por "NumeroPedido" para que enlace correctamente con la propiedad C#
            if (dgvHistorial.Columns.Contains("colNumPedidos")) dgvHistorial.Columns["colNumPedidos"].DataPropertyName = "NumeroPedido";

            if (dgvHistorial.Columns.Contains("colFecha")) dgvHistorial.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvHistorial.Columns.Contains("colProducto")) dgvHistorial.Columns["colProducto"].DataPropertyName = "Productos";
            if (dgvHistorial.Columns.Contains("colMonto")) dgvHistorial.Columns["colMonto"].DataPropertyName = "Monto";
            if (dgvHistorial.Columns.Contains("colPagado")) dgvHistorial.Columns["colPagado"].DataPropertyName = "Pagado";
            if (dgvHistorial.Columns.Contains("colSaldo")) dgvHistorial.Columns["colSaldo"].DataPropertyName = "Saldo";
            if (dgvHistorial.Columns.Contains("colEstado")) dgvHistorial.Columns["colEstado"].DataPropertyName = "Estado";
        }

        private void CargarDatosPantalla()
        {
            try
            {
                listaOriginalPedidos = historialLogica.ObtenerPedidosCliente(idClienteN);
                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = listaOriginalPedidos;

                // Paneles Estadísticos e Históricos globales
                ResumenFinanciero resumen = historialLogica.ObtenerResumenFinanciero(idClienteN);

                // Carga de Tarjetas Superiores
                lblTotalCompradoValor.Text = resumen.TotalComprado.ToString("C2");
                lblTotalPagadoValor.Text = resumen.TotalPagado.ToString("C2");
                lblSaldoPendienteValor.Text = resumen.SaldoPendiente.ToString("C2");
                lblSaldoPendienteValor.ForeColor = resumen.SaldoPendiente > 0 ? Color.DarkRed : Color.DarkGreen;

                // Carga de Resumen Financiero Inferior
                lblPromedioValor.Text = resumen.PromedioCompra.ToString("C2");

                // Cálculo del porcentaje dinámico por si no viene directo desde la capa de lógica
                if (resumen.TotalComprado > 0)
                {
                    decimal porcentaje = (resumen.TotalPagado / resumen.TotalComprado) * 100;
                    lblPorcentajeValor.Text = $"{porcentaje:F1}%";
                }
                else
                {
                    lblPorcentajeValor.Text = "0.0%";
                }

                lblAntiguedadValor.Text = resumen.Antiguedad;
                lblMontoMinimoValor.Text = resumen.MontoMinimo.ToString("C2");
                lblMontoMaximoValor.Text = resumen.MontoMaximo.ToString("C2");
                lblUltimaCompraValor.Text = resumen.UltimaCompra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falla al cargar historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
            txtBusqueda.ForeColor = Color.Gray;
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = listaOriginalPedidos;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBusqueda.Text.Trim().ToLower();

            if (listaOriginalPedidos == null) return;

            // Evitamos filtrar si el campo tiene el texto descriptivo del marcador (Placeholder)
            if (string.IsNullOrEmpty(textoBusqueda) || txtBusqueda.Text == "Filtrar por N°Pedido, Fecha, Estado o Productos")
            {
                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = listaOriginalPedidos;
                return;
            }

            List<HistorialPedido> listaFiltrada = new List<HistorialPedido>();

            foreach (HistorialPedido pedido in listaOriginalPedidos)
            {
                string numeroPedidoTexto = pedido.NumeroPedido.ToString();
                string productosTexto = (pedido.Productos ?? "").ToLower();
                string estadoTexto = (pedido.Estado ?? "").ToLower(); // Busca sobre "Sin pagos", "Parcial" o "Pagado"
                string fechaTexto = (pedido.Fecha ?? "");

                if (numeroPedidoTexto.Contains(textoBusqueda) ||
                    productosTexto.Contains(textoBusqueda) ||
                    estadoTexto.Contains(textoBusqueda) ||
                    fechaTexto.Contains(textoBusqueda))
                {
                    listaFiltrada.Add(pedido);
                }
            }

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = listaFiltrada;
        }

        #region Etiqueta de sugerencia en el TextBox de búsqueda
        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            // Si el usuario hace clic y todavía está el texto de sugerencia, se borra y cambia la letra en negro
            if (txtBusqueda.Text == "Filtrar por N°Pedido, Fecha, Estado o Productos")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            // Si el usuario hace clic afuera y no escribió nada, vuelve a poner la sugerencia gris
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
