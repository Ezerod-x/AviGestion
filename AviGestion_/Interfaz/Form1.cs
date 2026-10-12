using AviGestion_.Interfaz;
using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            UsuarioLogica logica = new UsuarioLogica();
            Usuario usuarioValidado = logica.ValidarLogin(usuario, contrasena);

            if (usuarioValidado != null)
            {
                FormMenu menu = new FormMenu(usuarioValidado);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private void lnkOlvidoContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperoContrasena recupero = new FormRecuperoContrasena();
            recupero.Show();
            this.Hide();
        }
    }
}
