namespace AviGestion_.Interfaz
{
    partial class FormRecuperoContrasena
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lnkVolver = new System.Windows.Forms.LinkLabel();
            this.pnlPaso1 = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.pnlPaso2 = new System.Windows.Forms.Panel();
            this.lblInstruccion2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnReenviar = new System.Windows.Forms.Button();
            this.btnCambiarMail = new System.Windows.Forms.Button();
            this.pnlPaso3 = new System.Windows.Forms.Panel();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.pnlPaso1.SuspendLayout();
            this.pnlPaso2.SuspendLayout();
            this.pnlPaso3.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lnkVolver);
            this.pnlCard.Controls.Add(this.pnlPaso3);
            this.pnlCard.Controls.Add(this.pnlPaso2);
            this.pnlCard.Controls.Add(this.pnlPaso1);
            this.pnlCard.Controls.Add(this.pnlEncabezado);
            this.pnlCard.Location = new System.Drawing.Point(60, 40);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(360, 330);
            this.pnlCard.TabIndex = 0;
            // 
            // lnkVolver
            // 
            this.lnkVolver.AutoSize = true;
            this.lnkVolver.LinkColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lnkVolver.Location = new System.Drawing.Point(115, 295);
            this.lnkVolver.Name = "lnkVolver";
            this.lnkVolver.TabIndex = 4;
            this.lnkVolver.TabStop = true;
            this.lnkVolver.Text = "Volver al inicio de sesión";
            this.lnkVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVolver_LinkClicked);
            // 
            // pnlPaso1
            // 
            this.pnlPaso1.BackColor = System.Drawing.Color.White;
            this.pnlPaso1.Controls.Add(this.lblMail);
            this.pnlPaso1.Controls.Add(this.txtMail);
            this.pnlPaso1.Controls.Add(this.btnEnviarCodigo);
            this.pnlPaso1.Location = new System.Drawing.Point(0, 90);
            this.pnlPaso1.Name = "pnlPaso1";
            this.pnlPaso1.Size = new System.Drawing.Size(358, 190);
            this.pnlPaso1.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblMail.Location = new System.Drawing.Point(25, 25);
            this.lblMail.Name = "lblMail";
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Correo electrónico";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(25, 43);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(310, 20);
            this.txtMail.TabIndex = 1;
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnEnviarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCodigo.Location = new System.Drawing.Point(25, 95);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(310, 36);
            this.btnEnviarCodigo.TabIndex = 2;
            this.btnEnviarCodigo.Text = "Enviar código";
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // pnlPaso2
            // 
            this.pnlPaso2.BackColor = System.Drawing.Color.White;
            this.pnlPaso2.Controls.Add(this.lblInstruccion2);
            this.pnlPaso2.Controls.Add(this.txtCodigo);
            this.pnlPaso2.Controls.Add(this.btnVerificar);
            this.pnlPaso2.Controls.Add(this.btnReenviar);
            this.pnlPaso2.Controls.Add(this.btnCambiarMail);
            this.pnlPaso2.Location = new System.Drawing.Point(0, 90);
            this.pnlPaso2.Name = "pnlPaso2";
            this.pnlPaso2.Size = new System.Drawing.Size(358, 190);
            this.pnlPaso2.TabIndex = 2;
            // 
            // lblInstruccion2
            // 
            this.lblInstruccion2.AutoSize = true;
            this.lblInstruccion2.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstruccion2.Location = new System.Drawing.Point(25, 12);
            this.lblInstruccion2.MaximumSize = new System.Drawing.Size(310, 0);
            this.lblInstruccion2.Name = "lblInstruccion2";
            this.lblInstruccion2.TabIndex = 0;
            this.lblInstruccion2.Text = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(25, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(310, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(25, 102);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(310, 36);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar código";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnReenviar
            // 
            this.btnReenviar.BackColor = System.Drawing.Color.White;
            this.btnReenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReenviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnReenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReenviar.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnReenviar.Location = new System.Drawing.Point(25, 150);
            this.btnReenviar.Name = "btnReenviar";
            this.btnReenviar.Size = new System.Drawing.Size(150, 28);
            this.btnReenviar.TabIndex = 3;
            this.btnReenviar.Text = "Reenviar código";
            this.btnReenviar.UseVisualStyleBackColor = false;
            this.btnReenviar.Click += new System.EventHandler(this.btnReenviar_Click);
            // 
            // btnCambiarMail
            // 
            this.btnCambiarMail.BackColor = System.Drawing.Color.White;
            this.btnCambiarMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCambiarMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarMail.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCambiarMail.Location = new System.Drawing.Point(185, 150);
            this.btnCambiarMail.Name = "btnCambiarMail";
            this.btnCambiarMail.Size = new System.Drawing.Size(150, 28);
            this.btnCambiarMail.TabIndex = 4;
            this.btnCambiarMail.Text = "Cambiar correo";
            this.btnCambiarMail.UseVisualStyleBackColor = false;
            this.btnCambiarMail.Click += new System.EventHandler(this.btnCambiarMail_Click);
            // 
            // pnlPaso3
            // 
            this.pnlPaso3.BackColor = System.Drawing.Color.White;
            this.pnlPaso3.Controls.Add(this.lblNueva);
            this.pnlPaso3.Controls.Add(this.txtNueva);
            this.pnlPaso3.Controls.Add(this.lblConfirmar);
            this.pnlPaso3.Controls.Add(this.txtConfirmar);
            this.pnlPaso3.Controls.Add(this.lblRequisitos);
            this.pnlPaso3.Controls.Add(this.btnGuardar);
            this.pnlPaso3.Location = new System.Drawing.Point(0, 90);
            this.pnlPaso3.Name = "pnlPaso3";
            this.pnlPaso3.Size = new System.Drawing.Size(358, 190);
            this.pnlPaso3.TabIndex = 3;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblNueva.Location = new System.Drawing.Point(25, 10);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.TabIndex = 0;
            this.lblNueva.Text = "Contraseña nueva";
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(25, 28);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(310, 20);
            this.txtNueva.TabIndex = 1;
            this.txtNueva.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblConfirmar.Location = new System.Drawing.Point(25, 58);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.TabIndex = 2;
            this.lblConfirmar.Text = "Repetí la contraseña";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(25, 76);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmar.TabIndex = 3;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.ForeColor = System.Drawing.Color.DimGray;
            this.lblRequisitos.Location = new System.Drawing.Point(25, 104);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.TabIndex = 4;
            this.lblRequisitos.Text = "Mínimo 8 caracteres, con letras y números.";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(25, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(310, 36);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar contraseña";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(358, 90);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Paso 1 de 3";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Recuperar Contraseña";
            // 
            // FormRecuperoContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 410);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecuperoContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recuperar Contraseña";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlPaso1.ResumeLayout(false);
            this.pnlPaso1.PerformLayout();
            this.pnlPaso2.ResumeLayout(false);
            this.pnlPaso2.PerformLayout();
            this.pnlPaso3.ResumeLayout(false);
            this.pnlPaso3.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.LinkLabel lnkVolver;
        private System.Windows.Forms.Panel pnlPaso1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Panel pnlPaso2;
        private System.Windows.Forms.Label lblInstruccion2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnReenviar;
        private System.Windows.Forms.Button btnCambiarMail;
        private System.Windows.Forms.Panel pnlPaso3;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}