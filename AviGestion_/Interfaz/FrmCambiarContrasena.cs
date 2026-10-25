using AviGestion_.Logica;
using System;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    // Cambio de contraseña del usuario que tiene la sesión iniciada.
    public partial class FrmCambiarContrasena : Form
    {
        private UsuarioLogica usuarioLogica = new UsuarioLogica();
        private Usuario usuarioActual;

        public FrmCambiarContrasena(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string actual = txtActual.Text.Trim();
            string nueva = txtNueva.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (actual == "" || nueva == "" || confirmar == "")
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Cambio de contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("La nueva contraseña y su repetición no coinciden.", "Cambio de contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmar.Clear();
                txtConfirmar.Focus();
                return;
            }

            string mensaje;
            bool cambiada;

            try
            {
                cambiada = usuarioLogica.CambiarContrasena(usuarioActual.IdUsuario, actual, nueva, out mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la contraseña.\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!cambiada)
            {
                MessageBox.Show(mensaje, "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtActual.Clear();
                txtActual.Focus();
                return;
            }

            MessageBox.Show("Tu contraseña se cambió correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}