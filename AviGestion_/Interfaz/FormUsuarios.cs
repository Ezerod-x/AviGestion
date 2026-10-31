using AviGestion_.Logica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    public partial class FormUsuarios : Form
    {
        private UsuarioLogica logica = new UsuarioLogica();
        private Usuario usuarioActual;
        private int idUsuarioModificando = -1;
        private const string SUGERENCIA = "Filtrar por Nombre, Apellido o Rol";

        #region Constructor
        public FormUsuarios(Usuario usuario)
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;   // solo las columnas del diseño: sin Id ni Contraseña
            usuarioActual = usuario;
            ConfigurarBuscador();
            OcultarPanelDetalle();
            CargarUsuarios();
        }
        #endregion

        #region Helpers panel
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtContrasena.Enabled = true;
            txtMail.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void OcultarPanelDetalle()
        {
            pnlDetalle.Visible = false;
            btnEliminar.Visible = false;
            idUsuarioModificando = -1;
            LimpiarCampos();
        }

        private void MostrarPanelAlta()
        {
            LimpiarCampos();
            idUsuarioModificando = -1;
            lblTituloDetalle.Text = "Registrar Usuario";
            btnGuardar.Text = "Registrar";
            btnEliminar.Visible = false;
            pnlDetalle.Visible = true;
            txtNombre.Focus();
        }

        private void MostrarPanelModificacion(Usuario usuario)
        {
            idUsuarioModificando = usuario.IdUsuario;
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtContrasena.Clear();
            txtContrasena.Enabled = false;   // la contraseña no se edita acá: la cambia cada usuario
            cmbRol.Text = usuario.Rol;
            txtMail.Text = usuario.Mail;
            lblTituloDetalle.Text = "Modificar Usuario";
            btnGuardar.Text = "Guardar Cambios";
            btnEliminar.Visible = true;
            pnlDetalle.Visible = true;
            txtNombre.Focus();
        }
        #endregion

        #region Carga de datos
        private void CargarUsuarios()
        {
            try
            {
                string filtro = txtBuscar.Text == SUGERENCIA ? "" : txtBuscar.Text.Trim();
                dgvUsuarios.DataSource = logica.BuscarUsuarios(filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botón Agregar Usuario
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            MostrarPanelAlta();
        }
        #endregion

        #region Doble clic en grilla → Modificar / Eliminar
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Usuario usuario = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
            MostrarPanelModificacion(usuario);
        }
        #endregion

        #region Guardar (Alta o Modificación)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esAlta = idUsuarioModificando == -1;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                (esAlta && string.IsNullOrWhiteSpace(txtContrasena.Text)) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Completá todos los campos antes de guardar.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // En el alta, la contraseña inicial tiene que cumplir los requisitos
            if (esAlta)
            {
                string errorRequisitos = UsuarioLogica.ValidarRequisitos(txtContrasena.Text.Trim());
                if (errorRequisitos != null)
                {
                    MessageBox.Show(errorRequisitos, "Contraseña no válida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasena.Focus();
                    return;
                }
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Contrasena = txtContrasena.Text,
                    Rol = cmbRol.Text,
                    Mail = txtMail.Text.Trim()
                };

                if (esAlta)
                {
                    logica.Insertar(usuario);
                    MessageBox.Show("Usuario registrado exitosamente.", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usuario.IdUsuario = idUsuarioModificando;
                    logica.Actualizar(usuario);
                    MessageBox.Show("Usuario modificado exitosamente.", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OcultarPanelDetalle();
                CargarUsuarios();
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
            DialogResult confirmar = MessageBox.Show(
                $"¿Estás seguro que querés eliminar a {txtNombre.Text} {txtApellido.Text}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    logica.Eliminar(idUsuarioModificando, usuarioActual.IdUsuario);
                    MessageBox.Show("Usuario eliminado correctamente.", "Baja exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OcultarPanelDetalle();
                    CargarUsuarios();
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
            CargarUsuarios();
        }
        #endregion
    }
}