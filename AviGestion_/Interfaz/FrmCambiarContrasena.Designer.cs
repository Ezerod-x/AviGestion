namespace AviGestion_.Interfaz
{
    partial class FrmCambiarContrasena
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnCancelar);
            this.pnlCard.Controls.Add(this.btnGuardar);
            this.pnlCard.Controls.Add(this.lblRequisitos);
            this.pnlCard.Controls.Add(this.txtConfirmar);
            this.pnlCard.Controls.Add(this.lblConfirmar);
            this.pnlCard.Controls.Add(this.txtNueva);
            this.pnlCard.Controls.Add(this.lblNueva);
            this.pnlCard.Controls.Add(this.txtActual);
            this.pnlCard.Controls.Add(this.lblActual);
            this.pnlCard.Controls.Add(this.pnlEncabezado);
            this.pnlCard.Location = new System.Drawing.Point(40, 37);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(479, 418);
            this.pnlCard.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnCancelar.Location = new System.Drawing.Point(247, 351);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(33, 351);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 44);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.ForeColor = System.Drawing.Color.DimGray;
            this.lblRequisitos.Location = new System.Drawing.Point(33, 318);
            this.lblRequisitos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(259, 16);
            this.lblRequisitos.TabIndex = 7;
            this.lblRequisitos.Text = "Mínimo 8 caracteres, con letras y números.";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(33, 282);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(412, 22);
            this.txtConfirmar.TabIndex = 6;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblConfirmar.Location = new System.Drawing.Point(33, 260);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(171, 16);
            this.lblConfirmar.TabIndex = 5;
            this.lblConfirmar.Text = "Repetí la contraseña nueva";
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(33, 217);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(412, 22);
            this.txtNueva.TabIndex = 4;
            this.txtNueva.UseSystemPasswordChar = true;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblNueva.Location = new System.Drawing.Point(33, 194);
            this.lblNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(116, 16);
            this.lblNueva.TabIndex = 3;
            this.lblNueva.Text = "Contraseña nueva";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(33, 151);
            this.txtActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(412, 22);
            this.txtActual.TabIndex = 2;
            this.txtActual.UseSystemPasswordChar = true;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblActual.Location = new System.Drawing.Point(33, 129);
            this.lblActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(115, 16);
            this.lblActual.TabIndex = 1;
            this.lblActual.Text = "Contraseña actual";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(477, 111);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 62);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.MaximumSize = new System.Drawing.Size(427, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(285, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingresá tu contraseña actual y elegí una nueva.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(27, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cambiar Contraseña";
            // 
            // FrmCambiarContrasena
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(560, 492);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar Contraseña";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}