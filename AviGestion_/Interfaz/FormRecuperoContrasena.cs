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

namespace AviGestion_.Interfaz
{
    public partial class FormRecuperoContrasena : Form
    {
        private UsuarioLogica usuarioLogica = new UsuarioLogica();

        public FormRecuperoContrasena()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Ingresá un correo electrónico.");
                return;
            }

            string nuevaContrasena = usuarioLogica.RecuperarContrasena(txtMail.Text);

            if (nuevaContrasena == null)
            {
                MessageBox.Show("No se encontró ningún usuario con ese correo.");
            }
            else
            {
                MessageBox.Show("Tu nueva contraseña temporal es: " + nuevaContrasena +
                    "\n\nPor seguridad, cambiala después de iniciar sesión.");

                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }
        private void lnkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
