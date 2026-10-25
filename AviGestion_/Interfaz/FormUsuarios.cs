using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    public partial class FormUsuarios : Form
    {


        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvUsuarios.Columns[e.ColumnIndex].Name;

            Usuario usuario = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;

            if (nombreColumna == "colAccion")
            {
                idUsuarioEditando = usuario.IdUsuario;

                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtContrasena.Clear();
                txtContrasena.Enabled = false;   // la contraseña no se edita acá: la cambia cada usuario
                cmbRol.Text = usuario.Rol;
            }
            else if (nombreColumna == "colEliminar")
            {
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que querés eliminar a {usuario.Nombre} {usuario.Apellido}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    usuarioLogica.Eliminar(usuario.IdUsuario);
                    MessageBox.Show("Usuario eliminado correctamente.");
                    CargarUsuarios();
                }
            }
        }
        private int? idUsuarioEditando = null;

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private UsuarioLogica usuarioLogica = new UsuarioLogica();
        private void CargarUsuarios()
        {
            colNombre.DataPropertyName = "Nombre";
            colApellido.DataPropertyName = "Apellido";
            colRol.DataPropertyName = "Rol";

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = usuarioLogica.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            idUsuarioEditando = null;
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtContrasena.Enabled = true;
            cmbRol.SelectedIndex = -1;
            txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esAlta = !idUsuarioEditando.HasValue;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                (esAlta && string.IsNullOrWhiteSpace(txtContrasena.Text)) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Completá todos los campos antes de guardar.");
                return;
            }

            // En el alta, la contraseña inicial tiene que cumplir los requisitos
            if (esAlta)
            {
                string errorRequisitos = UsuarioLogica.ValidarRequisitos(txtContrasena.Text.Trim());
                if (errorRequisitos != null)
                {
                    MessageBox.Show(errorRequisitos);
                    txtContrasena.Focus();
                    return;
                }
            }

            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Contrasena = txtContrasena.Text,
                Rol = cmbRol.Text
            };

            if (idUsuarioEditando.HasValue)
            {
                usuario.IdUsuario = idUsuarioEditando.Value;
                usuarioLogica.Actualizar(usuario);
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                usuarioLogica.Insertar(usuario);
                MessageBox.Show("Usuario guardado correctamente.");
            }

            idUsuarioEditando = null;
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtContrasena.Enabled = true;
            cmbRol.SelectedIndex = -1;

            CargarUsuarios();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idUsuarioEditando = null;
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtContrasena.Enabled = true;
            cmbRol.SelectedIndex = -1;
        }
        private Usuario usuarioActual;

        public FormUsuarios(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}