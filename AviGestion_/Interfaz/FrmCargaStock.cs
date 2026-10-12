using System;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormCargaStock : Form
    {
        private StockLogica logica = new StockLogica();
        private Producto productoSeleccionado = null;
        private Usuario usuarioActual;

        public FormCargaStock(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            this.Load += FormCargaStock_Load;
        }

        private void FormCargaStock_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla(string filtro = "")
        {
            var lista = logica.BuscarProductos(filtro);
            dgvStock.AutoGenerateColumns = false;
            dgvStock.DataSource = null;
            dgvStock.DataSource = lista;
        }

        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStock.Columns[e.ColumnIndex].Name != "colEstadoStock" || e.Value == null) return;

            switch (e.Value.ToString())
            {
                case "Stock Mínimo":
                case "Stock Máximo":
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                    e.CellStyle.Font = new System.Drawing.Font(dgvStock.Font, System.Drawing.FontStyle.Bold);
                    break;
                case "Próx. a Máximo":
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 130, 0);
                    e.CellStyle.Font = new System.Drawing.Font(dgvStock.Font, System.Drawing.FontStyle.Bold);
                    break;
                default:
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
                    break;
            }
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvStock.Columns[e.ColumnIndex].Name != "colSeleccionar") return;

            productoSeleccionado = (Producto)dgvStock.Rows[e.RowIndex].DataBoundItem;

            txtProductoSeleccionado.Text = $"{productoSeleccionado.Descripcion} ({productoSeleccionado.Codigo})";
            txtStockActual.Text = productoSeleccionado.Stock.ToString();
            nudCantidad.Value = 0;
            ActualizarNuevoStock();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarNuevoStock();
        }

        private void ActualizarNuevoStock()
        {
            if (productoSeleccionado == null)
            {
                txtNuevoStock.Text = "";
                lblValidacion.Text = "";
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            int nuevoStock = productoSeleccionado.Stock + cantidad;
            txtNuevoStock.Text = nuevoStock.ToString();

            if (nuevoStock <= productoSeleccionado.StockMinimo)
            {
                lblValidacion.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                lblValidacion.Text = $"⚠ El stock quedará por debajo del mínimo permitido (Mín: {productoSeleccionado.StockMinimo}).";
            }
            else if (nuevoStock >= productoSeleccionado.StockMaximo)
            {
                lblValidacion.ForeColor = System.Drawing.Color.FromArgb(200, 130, 0);
                lblValidacion.Text = $"⚠ El stock alcanzará o superará el máximo permitido (Máx: {productoSeleccionado.StockMaximo}).";
            }
            else
            {
                lblValidacion.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
                lblValidacion.Text = $"✓ Stock dentro del rango permitido (Mín: {productoSeleccionado.StockMinimo} / Máx: {productoSeleccionado.StockMaximo})";
            }
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un producto de la lista antes de registrar el ingreso.");
                return;
            }

            try
            {
                int cantidad = (int)nudCantidad.Value;
                var resultado = logica.RegistrarIngreso(productoSeleccionado, cantidad, usuarioActual.Nombre);

                MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.EstadoStock == "Stock Mínimo")
                {
                    MessageBox.Show(
                        $"⚠ ALERTA DE STOCK MÍNIMO\n\nEl producto \"{productoSeleccionado.Descripcion}\" quedó con {resultado.NuevoStock} unidades, en o por debajo del mínimo permitido ({productoSeleccionado.StockMinimo}).\n\nSe recomienda reponer stock a la brevedad.",
                        "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado.EstadoStock == "Stock Máximo")
                {
                    MessageBox.Show(
                        $"⚠ ALERTA DE STOCK MÁXIMO\n\nEl producto \"{productoSeleccionado.Descripcion}\" alcanzó {resultado.NuevoStock} unidades, en o por encima del máximo permitido ({productoSeleccionado.StockMaximo}).",
                        "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }

        private void btnActualizarInventario_Click(object sender, EventArgs e)
        {
            CargarGrilla(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(txtBuscar.Text);
        }

        private void btnGestionAlertas_Click(object sender, EventArgs e)
        {
            FormAlertas alertas = new FormAlertas(usuarioActual);
            alertas.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.Show();
            this.Close();
        }

        private void LimpiarFormulario()
        {
            productoSeleccionado = null;
            txtProductoSeleccionado.Clear();
            txtStockActual.Clear();
            txtNuevoStock.Clear();
            nudCantidad.Value = 0;
            lblValidacion.Text = "";
        }
    }
}