using System;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormProducto : Form
    {
        private ABM_Producto logica = new ABM_Producto();
        private int idSeleccionado = 0;
        private Usuario usuarioActual;

        public FormProducto(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarPlaceholderBuscar();
            this.Load += FormProducto_Load;
        }

        private void ConfigurarPlaceholderBuscar()
        {
            txtBuscar.Text = "Buscar producto...";
            txtBuscar.ForeColor = System.Drawing.Color.Gray;

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == "Buscar producto...")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = System.Drawing.Color.Black;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar producto...";
                    txtBuscar.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla(string filtro = "")
        {
            var lista = logica.BuscarProductos(filtro);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar producto...") return;
            CargarGrilla(txtBuscar.Text);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductos.Columns[e.ColumnIndex].Name != "colSeleccionar") return;

            var producto = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

            idSeleccionado = producto.Id;
            txtCodigo.Text = producto.Codigo;
            txtDescripcion.Text = producto.Descripcion;
            cmbCategoria.Text = producto.Categoria;
            nudPrecio.Value = producto.Precio;
            nudStock.Value = producto.Stock;
            nudStockMinimo.Value = producto.StockMinimo;
            nudStockMaximo.Value = producto.StockMaximo;
            cmbEstado.Text = producto.Estado;
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    Id = idSeleccionado,
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Categoria = cmbCategoria.Text,
                    Precio = nudPrecio.Value,
                    Stock = (int)nudStock.Value,
                    StockMinimo = (int)nudStockMinimo.Value,
                    StockMaximo = (int)nudStockMaximo.Value,
                    Estado = string.IsNullOrEmpty(cmbEstado.Text) ? "Activo" : cmbEstado.Text
                };

                logica.GuardarProducto(producto, usuarioActual.Nombre);
                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un producto de la lista antes de eliminarlo.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Confirma que desea eliminar el producto '{txtDescripcion.Text}'?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                logica.EliminarProducto(idSeleccionado, usuarioActual.Nombre);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            idSeleccionado = 0;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            nudStockMinimo.Value = 0;
            nudStockMaximo.Value = 0;
            cmbEstado.SelectedIndex = -1;
        }
    }
}