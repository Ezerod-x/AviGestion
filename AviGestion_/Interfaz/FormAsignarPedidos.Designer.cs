namespace AviGestion_.Interfaz
{
    partial class FormAsignarPedidos
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.tlpColumnas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEspera = new System.Windows.Forms.Panel();
            this.flpEspera = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEspera = new System.Windows.Forms.Label();
            this.pnlEnCamino = new System.Windows.Forms.Panel();
            this.flpEnCamino = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEnCamino = new System.Windows.Forms.Label();
            this.pnlEntregados = new System.Windows.Forms.Panel();
            this.flpEntregados = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEntregados = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            this.tlpColumnas.SuspendLayout();
            this.pnlEspera.SuspendLayout();
            this.pnlEnCamino.SuspendLayout();
            this.pnlEntregados.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSuperior
            //
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlSuperior.Controls.Add(this.btnVolverMenu);
            this.pnlSuperior.Controls.Add(this.lblTituloForm);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1000, 56);
            this.pnlSuperior.TabIndex = 1;
            //
            // btnVolverMenu
            //
            this.btnVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverMenu.BackColor = System.Drawing.Color.White;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.FlatAppearance.BorderSize = 0;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolverMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnVolverMenu.Location = new System.Drawing.Point(840, 12);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(140, 32);
            this.btnVolverMenu.TabIndex = 1;
            this.btnVolverMenu.Text = "Volver al menú";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            //
            // lblTituloForm
            //
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(20, 12);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(220, 25);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "Asignación de pedidos";
            //
            // tlpColumnas
            //
            this.tlpColumnas.ColumnCount = 3;
            this.tlpColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpColumnas.Controls.Add(this.pnlEspera, 0, 0);
            this.tlpColumnas.Controls.Add(this.pnlEnCamino, 1, 0);
            this.tlpColumnas.Controls.Add(this.pnlEntregados, 2, 0);
            this.tlpColumnas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColumnas.Location = new System.Drawing.Point(0, 56);
            this.tlpColumnas.Name = "tlpColumnas";
            this.tlpColumnas.Padding = new System.Windows.Forms.Padding(8);
            this.tlpColumnas.RowCount = 1;
            this.tlpColumnas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColumnas.Size = new System.Drawing.Size(1000, 544);
            this.tlpColumnas.TabIndex = 0;
            //
            // pnlEspera
            //
            this.pnlEspera.Controls.Add(this.flpEspera);
            this.pnlEspera.Controls.Add(this.lblEspera);
            this.pnlEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspera.Location = new System.Drawing.Point(13, 13);
            this.pnlEspera.Margin = new System.Windows.Forms.Padding(5);
            this.pnlEspera.Name = "pnlEspera";
            this.pnlEspera.Size = new System.Drawing.Size(313, 518);
            this.pnlEspera.TabIndex = 0;
            //
            // flpEspera
            //
            this.flpEspera.AutoScroll = true;
            this.flpEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.flpEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEspera.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEspera.Location = new System.Drawing.Point(0, 40);
            this.flpEspera.Name = "flpEspera";
            this.flpEspera.Padding = new System.Windows.Forms.Padding(8);
            this.flpEspera.Size = new System.Drawing.Size(313, 478);
            this.flpEspera.TabIndex = 1;
            this.flpEspera.WrapContents = false;
            //
            // lblEspera
            //
            this.lblEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEspera.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEspera.ForeColor = System.Drawing.Color.White;
            this.lblEspera.Location = new System.Drawing.Point(0, 0);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(313, 40);
            this.lblEspera.TabIndex = 0;
            this.lblEspera.Text = "Pedidos en espera";
            this.lblEspera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlEnCamino
            //
            this.pnlEnCamino.Controls.Add(this.flpEnCamino);
            this.pnlEnCamino.Controls.Add(this.lblEnCamino);
            this.pnlEnCamino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnCamino.Location = new System.Drawing.Point(344, 13);
            this.pnlEnCamino.Margin = new System.Windows.Forms.Padding(5);
            this.pnlEnCamino.Name = "pnlEnCamino";
            this.pnlEnCamino.Size = new System.Drawing.Size(313, 518);
            this.pnlEnCamino.TabIndex = 1;
            //
            // flpEnCamino
            //
            this.flpEnCamino.AutoScroll = true;
            this.flpEnCamino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.flpEnCamino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEnCamino.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEnCamino.Location = new System.Drawing.Point(0, 40);
            this.flpEnCamino.Name = "flpEnCamino";
            this.flpEnCamino.Padding = new System.Windows.Forms.Padding(8);
            this.flpEnCamino.Size = new System.Drawing.Size(313, 478);
            this.flpEnCamino.TabIndex = 1;
            this.flpEnCamino.WrapContents = false;
            //
            // lblEnCamino
            //
            this.lblEnCamino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEnCamino.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnCamino.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnCamino.ForeColor = System.Drawing.Color.White;
            this.lblEnCamino.Location = new System.Drawing.Point(0, 0);
            this.lblEnCamino.Name = "lblEnCamino";
            this.lblEnCamino.Size = new System.Drawing.Size(313, 40);
            this.lblEnCamino.TabIndex = 0;
            this.lblEnCamino.Text = "En camino";
            this.lblEnCamino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlEntregados
            //
            this.pnlEntregados.Controls.Add(this.flpEntregados);
            this.pnlEntregados.Controls.Add(this.lblEntregados);
            this.pnlEntregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntregados.Location = new System.Drawing.Point(675, 13);
            this.pnlEntregados.Margin = new System.Windows.Forms.Padding(5);
            this.pnlEntregados.Name = "pnlEntregados";
            this.pnlEntregados.Size = new System.Drawing.Size(312, 518);
            this.pnlEntregados.TabIndex = 2;
            //
            // flpEntregados
            //
            this.flpEntregados.AutoScroll = true;
            this.flpEntregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.flpEntregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEntregados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEntregados.Location = new System.Drawing.Point(0, 40);
            this.flpEntregados.Name = "flpEntregados";
            this.flpEntregados.Padding = new System.Windows.Forms.Padding(8);
            this.flpEntregados.Size = new System.Drawing.Size(312, 478);
            this.flpEntregados.TabIndex = 1;
            this.flpEntregados.WrapContents = false;
            //
            // lblEntregados
            //
            this.lblEntregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEntregados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEntregados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntregados.ForeColor = System.Drawing.Color.White;
            this.lblEntregados.Location = new System.Drawing.Point(0, 0);
            this.lblEntregados.Name = "lblEntregados";
            this.lblEntregados.Size = new System.Drawing.Size(312, 40);
            this.lblEntregados.TabIndex = 0;
            this.lblEntregados.Text = "Entregados";
            this.lblEntregados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // FormAsignarPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpColumnas);
            this.Controls.Add(this.pnlSuperior);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "FormAsignarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AviGestión - Asignar pedidos";
            this.Load += new System.EventHandler(this.FormAsignarPedidos_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.tlpColumnas.ResumeLayout(false);
            this.pnlEspera.ResumeLayout(false);
            this.pnlEnCamino.ResumeLayout(false);
            this.pnlEntregados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.TableLayoutPanel tlpColumnas;
        private System.Windows.Forms.Panel pnlEspera;
        private System.Windows.Forms.FlowLayoutPanel flpEspera;
        private System.Windows.Forms.Label lblEspera;
        private System.Windows.Forms.Panel pnlEnCamino;
        private System.Windows.Forms.FlowLayoutPanel flpEnCamino;
        private System.Windows.Forms.Label lblEnCamino;
        private System.Windows.Forms.Panel pnlEntregados;
        private System.Windows.Forms.FlowLayoutPanel flpEntregados;
        private System.Windows.Forms.Label lblEntregados;
    }
}