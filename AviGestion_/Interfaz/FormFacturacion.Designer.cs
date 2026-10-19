namespace AviGestion_.Interfaz
{
    partial class FormFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLectura = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnConfirmarDespacho = new System.Windows.Forms.Button();
            this.lblEtiquetaFactura = new System.Windows.Forms.Label();
            this.dgvListadoCompra = new System.Windows.Forms.DataGridView();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.grbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalleCompra
            // 
            this.grbDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDetalleCompra.BackColor = System.Drawing.Color.White;
            this.grbDetalleCompra.Controls.Add(this.label1);
            this.grbDetalleCompra.Controls.Add(this.lblLectura);
            this.grbDetalleCompra.Controls.Add(this.lblTotalPagar);
            this.grbDetalleCompra.Controls.Add(this.dgvDetalle);
            this.grbDetalleCompra.Controls.Add(this.lblPedidoCliente);
            this.grbDetalleCompra.Controls.Add(this.btnCancelarFactura);
            this.grbDetalleCompra.Controls.Add(this.btnConfirmarDespacho);
            this.grbDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDetalleCompra.Location = new System.Drawing.Point(12, 195);
            this.grbDetalleCompra.Name = "grbDetalleCompra";
            this.grbDetalleCompra.Size = new System.Drawing.Size(837, 228);
            this.grbDetalleCompra.TabIndex = 28;
            this.grbDetalleCompra.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(18, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Importe total facturado";
            // 
            // lblLectura
            // 
            this.lblLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLectura.AutoSize = true;
            this.lblLectura.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLectura.Location = new System.Drawing.Point(709, 16);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(93, 16);
            this.lblLectura.TabIndex = 22;
            this.lblLectura.Text = "Solo lectura";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagar.Location = new System.Drawing.Point(36, 193);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(17, 18);
            this.lblTotalPagar.TabIndex = 21;
            this.lblTotalPagar.Text = "0";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(18, 37);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(803, 128);
            this.dgvDetalle.TabIndex = 19;
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPedidoCliente.Location = new System.Drawing.Point(18, 16);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(52, 18);
            this.lblPedidoCliente.TabIndex = 20;
            this.lblPedidoCliente.Text = "label1";
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarFactura.FlatAppearance.BorderSize = 2;
            this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFactura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelarFactura.Location = new System.Drawing.Point(533, 185);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(107, 37);
            this.btnCancelarFactura.TabIndex = 17;
            this.btnCancelarFactura.Text = "Cancelar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btnConfirmarDespacho
            // 
            this.btnConfirmarDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarDespacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnConfirmarDespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarDespacho.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarDespacho.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarDespacho.Location = new System.Drawing.Point(656, 185);
            this.btnConfirmarDespacho.Name = "btnConfirmarDespacho";
            this.btnConfirmarDespacho.Size = new System.Drawing.Size(175, 37);
            this.btnConfirmarDespacho.TabIndex = 18;
            this.btnConfirmarDespacho.Text = "Confirmar Despacho";
            this.btnConfirmarDespacho.UseVisualStyleBackColor = false;
            this.btnConfirmarDespacho.Click += new System.EventHandler(this.btnConfirmarDespacho_Click);
            // 
            // lblEtiquetaFactura
            // 
            this.lblEtiquetaFactura.AutoSize = true;
            this.lblEtiquetaFactura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaFactura.Location = new System.Drawing.Point(14, 23);
            this.lblEtiquetaFactura.Name = "lblEtiquetaFactura";
            this.lblEtiquetaFactura.Size = new System.Drawing.Size(323, 14);
            this.lblEtiquetaFactura.TabIndex = 27;
            this.lblEtiquetaFactura.Text = "Pedidos pendientes a facturar (últimos 30 días)";
            // 
            // dgvListadoCompra
            // 
            this.dgvListadoCompra.AllowUserToAddRows = false;
            this.dgvListadoCompra.AllowUserToDeleteRows = false;
            this.dgvListadoCompra.AllowUserToOrderColumns = true;
            this.dgvListadoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoCompra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListadoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCompra.Location = new System.Drawing.Point(12, 44);
            this.dgvListadoCompra.Name = "dgvListadoCompra";
            this.dgvListadoCompra.Size = new System.Drawing.Size(840, 122);
            this.dgvListadoCompra.TabIndex = 25;
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(17, 176);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(35, 13);
            this.lblAyuda.TabIndex = 29;
            this.lblAyuda.Text = "label2";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.grbDetalleCompra);
            this.Controls.Add(this.lblEtiquetaFactura);
            this.Controls.Add(this.dgvListadoCompra);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            this.grbDetalleCompra.ResumeLayout(false);
            this.grbDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetalleCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblPedidoCliente;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnConfirmarDespacho;
        private System.Windows.Forms.Label lblEtiquetaFactura;
        private System.Windows.Forms.DataGridView dgvListadoCompra;
        private System.Windows.Forms.Label lblAyuda;
    }
}