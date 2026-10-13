using AviGestion;
using AviGestion_.Interfaz;
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
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            AgregarBotonCerrarSesion();
            ConfigurarVisibilidadPorRol();
        }

        // Crea el botón "Cerrar Sesión" en la barra superior.
        // Si el Designer ya tiene un btnCerrarSesion, no hace nada.
        private void AgregarBotonCerrarSesion()
        {
            if (this.Controls.Find("btnCerrarSesion", true).Length > 0) return;

            var btn = new Button
            {
                Name = "btnCerrarSesion",
                Text = "Cerrar Sesión",
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.OliveDrab,
                Size = new Size(140, 27),
                Location = new Point(this.ClientSize.Width - 150, 4),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderColor = Color.White;
            btn.Click += btnCerrarSesion_Click;

            this.Controls.Add(btn);
            btn.BringToFront();
        }

        private void btnUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios(usuarioActual);
            usuarios.Show();
            this.Hide();
        }

        private void ConfigurarVisibilidadPorRol()
        {
            // Por defecto, ocultamos todo excepto Ayuda (que ven todos)
            btnClientes.Visible = false;
            btnUsuarios.Visible = false;
            btnPedidos.Visible = false;
            btnProductos.Visible = false;
            btnAsignarPedidos.Visible = false;
            btnStock.Visible = false;
            btnCategorias.Visible = false;
            btnVehiculos.Visible = false;
            btnBitacora.Visible = false;
            btnBackup.Visible = false;
            btnFacturacion.Visible = false;
            btnRegistrarPago.Visible = false;
            btnAyuda.Visible = true;
            lblProductosDescripcion.Visible = false;
            lblStockDescripcion.Visible = false;



            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    btnClientes.Visible = true;
                    btnUsuarios.Visible = true;
                    btnStock.Visible = false;
                    btnFacturacion.Visible = true;
                    btnRegistrarPago.Visible = true;
                    btnBitacora.Visible = true;
                    btnBackup.Visible = true;
                    break;

                case "Administrador de pedidos":
                    btnPedidos.Visible = true;
                    break;

                case "Jefe de Deposito":
                    btnProductos.Visible = true;
                    btnAsignarPedidos.Visible = true;
                    btnVehiculos.Visible = true;
                    btnStock.Visible = true;
                    btnCategorias.Visible = true;
                    lblProductosDescripcion.Visible = true;
                    lblStockDescripcion.Visible = true;
                    break;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes frmCliente = new FormClientes(usuarioActual);
            frmCliente.Show();
            this.Hide();
        }

        private void btnProductos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblProductosTitulo_Click(object sender, EventArgs e)
        {
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto(usuarioActual);
            frm.Show();
            this.Hide();
        }




        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            FormCargaStock frm = new FormCargaStock(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.Show();
            this.Hide();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias();
            frm.Show();
            this.Hide();
        }

        private void btnCategorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion frm = new FormFacturacion(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            FormRegistrarPago frm = new FormRegistrarPago(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculo frm = new FormVehiculo(usuarioActual);
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FormBitacora frm = new FormBitacora(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup(usuarioActual);
            frm.Show();
            this.Hide();
        }
        private void btnAsignarPedidos_Click(object sender, EventArgs e)
        {
            FormAsignarPedidos frm = new FormAsignarPedidos(usuarioActual);
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            BitacoraLogica.Registrar(usuarioActual.Nombre, "Cierre de Sesión", "Seguridad");

            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.Show();
            this.Close();
        }
    }
}