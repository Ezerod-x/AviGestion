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
            ConfigurarPlaceholderBuscar();
            this.Load += FormBitacora_Load;
        }


        // ---- Texto de ayuda dentro del buscador ----
        private const string PH_BUSCAR = "Buscar por usuario...";
        private bool inicializando = true;     // evita consultas mientras se arma la pantalla

        // Texto que realmente se usa para buscar (el texto de ayuda no cuenta como búsqueda)
        private string TextoBusqueda
        {
            get { return txtBuscarUsuario.Text == PH_BUSCAR ? "" : txtBuscarUsuario.Text; }
        }

        private void PonerPlaceholder()
        {
            txtBuscarUsuario.Text = PH_BUSCAR;
            txtBuscarUsuario.ForeColor = System.Drawing.Color.Gray;
        }

        private void ConfigurarPlaceholderBuscar()
        {
            PonerPlaceholder();

            txtBuscarUsuario.Enter += (s, e) =>
            {
                if (txtBuscarUsuario.Text == PH_BUSCAR)
                {
                    txtBuscarUsuario.Text = "";
                    txtBuscarUsuario.ForeColor = System.Drawing.Color.Black;
                }
            };

            txtBuscarUsuario.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
                    PonerPlaceholder();
            };
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            cmbAccion.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            inicializando = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            DateTime? desde = chkFiltrarFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = chkFiltrarFecha.Checked ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null;

            var lista = logica.Buscar(TextoBusqueda, cmbAccion.Text, cmbModulo.Text, desde, hasta);

            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = lista;

            if (dgvBitacora.Columns.Count > 0)
                dgvBitacora.Columns["colFecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void Filtro_Changed(object sender, EventArgs e)
        {
            if (inicializando) return;
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
            PonerPlaceholder();
            cmbAccion.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            chkFiltrarFecha.Checked = false;
            CargarGrilla();
        }
    }
}