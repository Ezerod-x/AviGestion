using System;
using System.IO;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormBackup : Form
    {
        private BackupLogica logica = new BackupLogica();
        private Usuario usuarioActual;

        // Ruta del último backup generado en esta sesión de la pantalla.
        private string ultimaRutaBackup = null;

        public FormBackup(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtCarpeta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnGenerarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Mientras se genera, no se puede descargar nada anterior.
                ultimaRutaBackup = null;
                btnDescargarBackup.Enabled = false;

                lblResultado.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
                lblResultado.Text = "Generando backup, por favor espere...";
                Application.DoEvents();

                string ruta = logica.GenerarBackup(txtCarpeta.Text, usuarioActual.Nombre, usuarioActual.Rol);

                ultimaRutaBackup = ruta;
                btnDescargarBackup.Enabled = true;

                lblResultado.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
                lblResultado.Text = $"✓ Backup generado correctamente en:\n{ruta}";
            }
            catch (Exception ex)
            {
                lblResultado.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                lblResultado.Text = "✗ " + ex.Message;
            }
        }

        private void btnDescargarBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ultimaRutaBackup))
            {
                MessageBox.Show("Primero generá un backup para poder descargarlo.", "Descargar backup",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(ultimaRutaBackup))
            {
                MessageBox.Show(
                    "No se encontró el archivo de backup en:\n" + ultimaRutaBackup +
                    "\n\nSi la base de datos está en otro equipo (servidor), el archivo quedó guardado en ese equipo.",
                    "Descargar backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Descargar copia del backup";
                dlg.FileName = Path.GetFileName(ultimaRutaBackup);
                dlg.Filter = "Backup de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dlg.OverwritePrompt = true;

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    string origen = Path.GetFullPath(ultimaRutaBackup);
                    string destino = Path.GetFullPath(dlg.FileName);

                    if (string.Equals(origen, destino, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El backup ya se encuentra en esa ubicación. Elegí otra carpeta para la copia.",
                            "Descargar backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    File.Copy(origen, destino, true);

                    lblResultado.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
                    lblResultado.Text = $"✓ Copia del backup descargada en:\n{destino}";
                }
                catch (Exception ex)
                {
                    lblResultado.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                    lblResultado.Text = "✗ No se pudo descargar la copia: " + ex.Message;
                }
            }
        }
    }
}