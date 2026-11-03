namespace AviGestion_.UI
{
    partial class FormBackup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.btnGenerarBackup = new System.Windows.Forms.Button();
            this.btnDescargarBackup = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblRestaurarTitulo = new System.Windows.Forms.Label();
            this.lblRestaurarInfo = new System.Windows.Forms.Label();
            this.txtArchivoRestaurar = new System.Windows.Forms.TextBox();
            this.btnExaminarArchivo = new System.Windows.Forms.Button();
            this.btnRestaurarBackup = new System.Windows.Forms.Button();
            this.lblAutomatico = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(245, 240, 220);
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Controls.Add(this.lblInfo);
            this.pnlContenido.Controls.Add(this.lblCarpeta);
            this.pnlContenido.Controls.Add(this.txtCarpeta);
            this.pnlContenido.Controls.Add(this.btnSeleccionarCarpeta);
            this.pnlContenido.Controls.Add(this.btnGenerarBackup);
            this.pnlContenido.Controls.Add(this.btnDescargarBackup);
            this.pnlContenido.Controls.Add(this.lblResultado);
            this.pnlContenido.Controls.Add(this.lblSeparador);
            this.pnlContenido.Controls.Add(this.lblRestaurarTitulo);
            this.pnlContenido.Controls.Add(this.lblRestaurarInfo);
            this.pnlContenido.Controls.Add(this.txtArchivoRestaurar);
            this.pnlContenido.Controls.Add(this.btnExaminarArchivo);
            this.pnlContenido.Controls.Add(this.btnRestaurarBackup);
            this.pnlContenido.Controls.Add(this.lblAutomatico);
            this.pnlContenido.Location = new System.Drawing.Point(110, 20);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenido.Size = new System.Drawing.Size(660, 470);
            this.pnlContenido.TabIndex = 1;
            //
            // lblInfo
            //
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(600, 40);
            this.lblInfo.Text = "Se generará una copia de seguridad completa (Backup Full) de la base de datos AviGestion, incluyendo todas las tablas del sistema. El sistema también genera un backup automático una vez por día.";
            //
            // lblCarpeta
            //
            this.lblCarpeta.AutoSize = true;
            this.lblCarpeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarpeta.Location = new System.Drawing.Point(20, 75);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Text = "CARPETA DE DESTINO";
            //
            // txtCarpeta
            //
            this.txtCarpeta.Location = new System.Drawing.Point(20, 95);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(480, 20);
            this.txtCarpeta.TabIndex = 0;
            //
            // btnSeleccionarCarpeta
            //
            this.btnSeleccionarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCarpeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(510, 93);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(130, 24);
            this.btnSeleccionarCarpeta.TabIndex = 1;
            this.btnSeleccionarCarpeta.Text = "Examinar...";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            //
            // btnGenerarBackup
            //
            this.btnGenerarBackup.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnGenerarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerarBackup.ForeColor = System.Drawing.Color.White;
            this.btnGenerarBackup.Location = new System.Drawing.Point(20, 140);
            this.btnGenerarBackup.Name = "btnGenerarBackup";
            this.btnGenerarBackup.Size = new System.Drawing.Size(220, 36);
            this.btnGenerarBackup.TabIndex = 2;
            this.btnGenerarBackup.Text = "💾 Generar Backup";
            this.btnGenerarBackup.UseVisualStyleBackColor = false;
            this.btnGenerarBackup.Click += new System.EventHandler(this.btnGenerarBackup_Click);
            //
            // btnDescargarBackup
            //
            this.btnDescargarBackup.Enabled = false;
            this.btnDescargarBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnDescargarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDescargarBackup.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnDescargarBackup.Location = new System.Drawing.Point(260, 140);
            this.btnDescargarBackup.Name = "btnDescargarBackup";
            this.btnDescargarBackup.Size = new System.Drawing.Size(220, 36);
            this.btnDescargarBackup.TabIndex = 3;
            this.btnDescargarBackup.Text = "⬇ Descargar copia";
            this.btnDescargarBackup.UseVisualStyleBackColor = true;
            this.btnDescargarBackup.Click += new System.EventHandler(this.btnDescargarBackup_Click);
            //
            // lblResultado
            //
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultado.Location = new System.Drawing.Point(20, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(600, 40);
            //
            // lblSeparador
            //
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.Location = new System.Drawing.Point(20, 242);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(620, 2);
            //
            // lblRestaurarTitulo
            //
            this.lblRestaurarTitulo.AutoSize = true;
            this.lblRestaurarTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRestaurarTitulo.Location = new System.Drawing.Point(20, 258);
            this.lblRestaurarTitulo.Name = "lblRestaurarTitulo";
            this.lblRestaurarTitulo.Text = "RESTAURAR UNA COPIA DE SEGURIDAD";
            //
            // lblRestaurarInfo
            //
            this.lblRestaurarInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRestaurarInfo.ForeColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.lblRestaurarInfo.Location = new System.Drawing.Point(20, 280);
            this.lblRestaurarInfo.Name = "lblRestaurarInfo";
            this.lblRestaurarInfo.Size = new System.Drawing.Size(620, 34);
            this.lblRestaurarInfo.Text = "Atención: al restaurar, todos los datos actuales se reemplazan por los de la copia elegida. Antes se guarda una copia automática de lo que hay hoy.";
            //
            // txtArchivoRestaurar
            //
            this.txtArchivoRestaurar.Location = new System.Drawing.Point(20, 322);
            this.txtArchivoRestaurar.Name = "txtArchivoRestaurar";
            this.txtArchivoRestaurar.ReadOnly = true;
            this.txtArchivoRestaurar.Size = new System.Drawing.Size(480, 20);
            this.txtArchivoRestaurar.TabIndex = 4;
            //
            // btnExaminarArchivo
            //
            this.btnExaminarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminarArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExaminarArchivo.Location = new System.Drawing.Point(510, 320);
            this.btnExaminarArchivo.Name = "btnExaminarArchivo";
            this.btnExaminarArchivo.Size = new System.Drawing.Size(130, 24);
            this.btnExaminarArchivo.TabIndex = 5;
            this.btnExaminarArchivo.Text = "Buscar archivo...";
            this.btnExaminarArchivo.UseVisualStyleBackColor = true;
            this.btnExaminarArchivo.Click += new System.EventHandler(this.btnExaminarArchivo_Click);
            //
            // btnRestaurarBackup
            //
            this.btnRestaurarBackup.BackColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.btnRestaurarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRestaurarBackup.ForeColor = System.Drawing.Color.White;
            this.btnRestaurarBackup.Location = new System.Drawing.Point(20, 362);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.btnRestaurarBackup.Size = new System.Drawing.Size(220, 36);
            this.btnRestaurarBackup.TabIndex = 6;
            this.btnRestaurarBackup.Text = "♻ Restaurar Backup";
            this.btnRestaurarBackup.UseVisualStyleBackColor = false;
            this.btnRestaurarBackup.Click += new System.EventHandler(this.btnRestaurarBackup_Click);
            //
            // lblAutomatico
            //
            this.lblAutomatico.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAutomatico.ForeColor = System.Drawing.Color.DimGray;
            this.lblAutomatico.Location = new System.Drawing.Point(20, 410);
            this.lblAutomatico.Name = "lblAutomatico";
            this.lblAutomatico.Size = new System.Drawing.Size(620, 48);
            this.lblAutomatico.Text = "";
            //
            // openFileDialog1
            //
            this.openFileDialog1.Filter = "Backup de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
            this.openFileDialog1.Title = "Seleccionar copia de seguridad";
            //
            // FormBackup
            //
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.pnlContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.Text = "Sistema AviGestión";
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Button btnGenerarBackup;
        private System.Windows.Forms.Button btnDescargarBackup;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblRestaurarTitulo;
        private System.Windows.Forms.Label lblRestaurarInfo;
        private System.Windows.Forms.TextBox txtArchivoRestaurar;
        private System.Windows.Forms.Button btnExaminarArchivo;
        private System.Windows.Forms.Button btnRestaurarBackup;
        private System.Windows.Forms.Label lblAutomatico;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}