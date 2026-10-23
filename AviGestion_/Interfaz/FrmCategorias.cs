using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FrmCategorias : Form
    {
        private CategoriaLogica logica = new CategoriaLogica();
        private int idCategoriaModificando = -1;
        private const string SUGERENCIA = "Filtrar por Nombre o Descripción";

        #region Constructor
        public FrmCategorias()
        {
            InitializeComponent();
            CargarCategorias();
            ConfigurarBuscador();
            OcultarPanelDetalle();
        }
        #endregion

        #region Helpers panel
        private void OcultarPanelDetalle()
        {
            pnlDetalle.Visible = false;
            btnEliminar.Visible = false;
            idCategoriaModificando = -1;
        }

        private void MostrarPanelAlta()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idCategoriaModificando = -1;
            lblTituloDetalle.Text = "Registrar Categoría";
            btnGuardar.Text = "Registrar";
            btnEliminar.Visible = false;
            pnlDetalle.Visible = true;
            txtNombre.Focus();
        }

        private void MostrarPanelModificacion(int idCategoria, string nombre, string descripcion)
        {
            idCategoriaModificando = idCategoria;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            lblTituloDetalle.Text = "Modificar Categoría";
            btnGuardar.Text = "Guardar Cambios";
            btnEliminar.Visible = true;
            pnlDetalle.Visible = true;
            txtNombre.Focus();
        }
        #endregion

        #region Carga de datos
        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (var c in logica.ObtenerCategorias())
                    dgvCategorias.Rows.Add(c.Id_Categoria, c.Nombre, c.Descripcion,
                        c.CantProductos + " productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botón Nueva Categoría
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            MostrarPanelAlta();
        }
        #endregion

        #region Doble clic en grilla → Modificar
        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idCategoria = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells[0].Value);
            string nombre = dgvCategorias.Rows[e.RowIndex].Cells[1].Value?.ToString();
            string descripcion = dgvCategorias.Rows[e.RowIndex].Cells[2].Value?.ToString();

            MostrarPanelModificacion(idCategoria, nombre, descripcion);
        }
        #endregion

        #region Guardar (Alta o Modificación)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaModificando == -1)
                {
                    logica.AltaCategoria(txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show("Categoría registrada exitosamente.", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logica.ModificarCategoria(idCategoriaModificando,
                        txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show("Categoría modificada exitosamente.", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OcultarPanelDetalle();
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DialogResult confirmar = MessageBox.Show(
                $"¿Estás seguro que querés eliminar la categoría \"{nombre}\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    logica.EliminarCategoria(idCategoriaModificando);
                    MessageBox.Show("Categoría eliminada correctamente.", "Baja exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OcultarPanelDetalle();
                    CargarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se puede eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarPanelDetalle();
        }
        #endregion

        #region Búsqueda
        private void ConfigurarBuscador()
        {
            txtBuscar.Text = SUGERENCIA;
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == SUGERENCIA) { txtBuscar.Text = ""; txtBuscar.ForeColor = Color.Black; }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = SUGERENCIA; txtBuscar.ForeColor = Color.Gray; }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (var c in logica.BuscarCategorias(txtBuscar.Text == SUGERENCIA ? "" : txtBuscar.Text.Trim()))
                    dgvCategorias.Rows.Add(c.Id_Categoria, c.Nombre, c.Descripcion,
                        c.CantProductos + " productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Volver al menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormMenu)
                {
                    f.Show();
                    break;
                }
            }
        }
        #endregion

        #region Label ayuda
        private void lblAyuda_Click(object sender, EventArgs e) { }
        #endregion
    }
}