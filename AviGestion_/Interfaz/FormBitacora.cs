using System;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormBitacora : Form
    {
        private BitacoraLogica logica = new BitacoraLogica();
        private Usuario usuarioActual;

        public FormBitacora(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            this.Load += FormBitacora_Load;
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            cmbAccion.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            DateTime? desde = chkFiltrarFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = chkFiltrarFecha.Checked ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null;

            var lista = logica.Buscar(txtBuscarUsuario.Text, cmbAccion.Text, cmbModulo.Text, desde, hasta);

            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = lista;

            if (dgvBitacora.Columns.Count > 0)
                dgvBitacora.Columns["colFecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void Filtro_Changed(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
            CargarGrilla();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Clear();
            cmbAccion.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            chkFiltrarFecha.Checked = false;
            CargarGrilla();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }
    }
}