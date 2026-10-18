namespace AviGestion_.UI
{
    partial class FormMenu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlGraficoProductos = new System.Windows.Forms.Panel();
            this.lblGraficoProductosTitulo = new System.Windows.Forms.Label();
            this.pnlGraficoPedidos = new System.Windows.Forms.Panel();
            this.lblGraficoPedidosTitulo = new System.Windows.Forms.Label();
            this.pnlStockResumen = new System.Windows.Forms.Panel();
            this.lblStockResumenTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlGraficoProductos.SuspendLayout();
            this.pnlGraficoPedidos.SuspendLayout();
            this.pnlStockResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.lblUsuario);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú Principal - Sistema AviGestión";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.flpSidebar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 551);
            this.pnlSidebar.TabIndex = 1;
            // 
            // flpSidebar
            // 
            this.flpSidebar.AutoScroll = true;
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.flpSidebar.Size = new System.Drawing.Size(220, 551);
            this.flpSidebar.TabIndex = 0;
            this.flpSidebar.WrapContents = false;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.pnlFondo.BackgroundImage = global::AviGestion_.Properties.Resources.Fondo_patron_420x300;
            this.pnlFondo.Controls.Add(this.pnlContenido);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(220, 60);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(788, 551);
            this.pnlFondo.TabIndex = 2;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.Beige;
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Controls.Add(this.pnlGraficoProductos);
            this.pnlContenido.Controls.Add(this.pnlGraficoPedidos);
            this.pnlContenido.Controls.Add(this.pnlStockResumen);
            this.pnlContenido.Location = new System.Drawing.Point(61, 44);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(666, 462);
            this.pnlContenido.TabIndex = 6;
            // 
            // pnlGraficoProductos
            // 
            this.pnlGraficoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficoProductos.BackColor = System.Drawing.Color.White;
            this.pnlGraficoProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoProductos.Controls.Add(this.lblGraficoProductosTitulo);
            this.pnlGraficoProductos.Location = new System.Drawing.Point(335, 157);
            this.pnlGraficoProductos.Name = "pnlGraficoProductos";
            this.pnlGraficoProductos.Size = new System.Drawing.Size(325, 300);
            this.pnlGraficoProductos.TabIndex = 4;
            // 
            // lblGraficoProductosTitulo
            // 
            this.lblGraficoProductosTitulo.AutoSize = true;
            this.lblGraficoProductosTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGraficoProductosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblGraficoProductosTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblGraficoProductosTitulo.Name = "lblGraficoProductosTitulo";
            this.lblGraficoProductosTitulo.Size = new System.Drawing.Size(234, 20);
            this.lblGraficoProductosTitulo.TabIndex = 0;
            this.lblGraficoProductosTitulo.Text = "Cantidad de productos vendidos";
            // 
            // pnlGraficoPedidos
            // 
            this.pnlGraficoPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGraficoPedidos.BackColor = System.Drawing.Color.White;
            this.pnlGraficoPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoPedidos.Controls.Add(this.lblGraficoPedidosTitulo);
            this.pnlGraficoPedidos.Location = new System.Drawing.Point(9, 157);
            this.pnlGraficoPedidos.Name = "pnlGraficoPedidos";
            this.pnlGraficoPedidos.Size = new System.Drawing.Size(287, 300);
            this.pnlGraficoPedidos.TabIndex = 3;
            // 
            // lblGraficoPedidosTitulo
            // 
            this.lblGraficoPedidosTitulo.AutoSize = true;
            this.lblGraficoPedidosTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGraficoPedidosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblGraficoPedidosTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblGraficoPedidosTitulo.Name = "lblGraficoPedidosTitulo";
            this.lblGraficoPedidosTitulo.Size = new System.Drawing.Size(142, 20);
            this.lblGraficoPedidosTitulo.TabIndex = 0;
            this.lblGraficoPedidosTitulo.Text = "Pedidos por cliente";
            // 
            // pnlStockResumen
            // 
            this.pnlStockResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStockResumen.BackColor = System.Drawing.Color.White;
            this.pnlStockResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockResumen.Controls.Add(this.lblStockResumenTitulo);
            this.pnlStockResumen.Location = new System.Drawing.Point(9, 3);
            this.pnlStockResumen.Name = "pnlStockResumen";
            this.pnlStockResumen.Size = new System.Drawing.Size(639, 150);
            this.pnlStockResumen.TabIndex = 2;
            // 
            // lblStockResumenTitulo
            // 
            this.lblStockResumenTitulo.AutoSize = true;
            this.lblStockResumenTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblStockResumenTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblStockResumenTitulo.Name = "lblStockResumenTitulo";
            this.lblStockResumenTitulo.Size = new System.Drawing.Size(242, 20);
            this.lblStockResumenTitulo.TabIndex = 0;
            this.lblStockResumenTitulo.Text = "Stock de los diferentes productos";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 650);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlFondo.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlGraficoProductos.ResumeLayout(false);
            this.pnlGraficoProductos.PerformLayout();
            this.pnlGraficoPedidos.ResumeLayout(false);
            this.pnlGraficoPedidos.PerformLayout();
            this.pnlStockResumen.ResumeLayout(false);
            this.pnlStockResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlGraficoProductos;
        private System.Windows.Forms.Label lblGraficoProductosTitulo;
        private System.Windows.Forms.Panel pnlGraficoPedidos;
        private System.Windows.Forms.Label lblGraficoPedidosTitulo;
        private System.Windows.Forms.Panel pnlStockResumen;
        private System.Windows.Forms.Label lblStockResumenTitulo;
    }
}