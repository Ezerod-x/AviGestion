namespace AviGestion_.Interfaz
{
    partial class FormRegistrarPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.splitPagos = new System.Windows.Forms.SplitContainer();
            this.dgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.pnlBuscarPagos = new System.Windows.Forms.Panel();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.lblCapImporte = new System.Windows.Forms.Label();
            this.lblCapSaldo = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.lblSaldoPendiente = new System.Windows.Forms.Label();
            this.lblCapTotal = new System.Windows.Forms.Label();
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagos)).BeginInit();
            this.splitPagos.Panel1.SuspendLayout();
            this.splitPagos.Panel2.SuspendLayout();
            this.splitPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.pnlBuscarPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "🔍 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(44, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(555, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // splitPagos
            // 
            this.splitPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPagos.IsSplitterFixed = true;
            this.splitPagos.Location = new System.Drawing.Point(0, 0);
            this.splitPagos.Name = "splitPagos";
            this.splitPagos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPagos.Panel1
            // 
            this.splitPagos.Panel1.Controls.Add(this.dgvListadoPedidos);
            this.splitPagos.Panel1.Controls.Add(this.lblAyuda);
            this.splitPagos.Panel1.Controls.Add(this.pnlBuscarPagos);
            // 
            // splitPagos.Panel2
            // 
            this.splitPagos.Panel2.BackColor = System.Drawing.Color.Beige;
            this.splitPagos.Panel2.Controls.Add(this.btnConfirmarPago);
            this.splitPagos.Panel2.Controls.Add(this.btnCancelarPago);
            this.splitPagos.Panel2.Controls.Add(this.lblCapImporte);
            this.splitPagos.Panel2.Controls.Add(this.lblCapSaldo);
            this.splitPagos.Panel2.Controls.Add(this.nudImporte);
            this.splitPagos.Panel2.Controls.Add(this.lblTotalPedido);
            this.splitPagos.Panel2.Controls.Add(this.lblSaldoPendiente);
            this.splitPagos.Panel2.Controls.Add(this.lblCapTotal);
            this.splitPagos.Panel2.Controls.Add(this.lblPedidoCliente);
            this.splitPagos.Size = new System.Drawing.Size(864, 461);
            this.splitPagos.SplitterDistance = 300;
            this.splitPagos.TabIndex = 13;
            // 
            // dgvListadoPedidos
            // 
            this.dgvListadoPedidos.AllowUserToAddRows = false;
            this.dgvListadoPedidos.AllowUserToDeleteRows = false;
            this.dgvListadoPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colCliente,
            this.colFecha,
            this.colProductos,
            this.colTotal,
            this.colSaldo,
            this.colEstado});
            this.dgvListadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPedidos.Location = new System.Drawing.Point(0, 47);
            this.dgvListadoPedidos.MultiSelect = false;
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(862, 238);
            this.dgvListadoPedidos.TabIndex = 2;
            // 
            // colIdPedido
            // 
            this.colIdPedido.DataPropertyName = "IdPedido";
            this.colIdPedido.HeaderText = "N°Pedido";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colProductos
            // 
            this.colProductos.HeaderText = "Productos";
            this.colProductos.Name = "colProductos";
            this.colProductos.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "C2";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.DataPropertyName = "SaldoPendiente";
            dataGridViewCellStyle6.Format = "C2";
            this.colSaldo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSaldo.HeaderText = "Saldo Pendiente";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado de Pago";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAyuda.Location = new System.Drawing.Point(0, 285);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(35, 13);
            this.lblAyuda.TabIndex = 16;
            this.lblAyuda.Text = "label2";
            // 
            // pnlBuscarPagos
            // 
            this.pnlBuscarPagos.BackColor = System.Drawing.Color.Beige;
            this.pnlBuscarPagos.Controls.Add(this.label1);
            this.pnlBuscarPagos.Controls.Add(this.txtBuscar);
            this.pnlBuscarPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscarPagos.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscarPagos.Name = "pnlBuscarPagos";
            this.pnlBuscarPagos.Size = new System.Drawing.Size(862, 47);
            this.pnlBuscarPagos.TabIndex = 15;
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnConfirmarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.Location = new System.Drawing.Point(694, 86);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(146, 33);
            this.btnConfirmarPago.TabIndex = 5;
            this.btnConfirmarPago.Text = "Confirmar Pago";
            this.btnConfirmarPago.UseVisualStyleBackColor = false;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPago.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPago.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelarPago.Location = new System.Drawing.Point(590, 86);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(98, 33);
            this.btnCancelarPago.TabIndex = 4;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // lblCapImporte
            // 
            this.lblCapImporte.AutoSize = true;
            this.lblCapImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCapImporte.Location = new System.Drawing.Point(378, 70);
            this.lblCapImporte.Name = "lblCapImporte";
            this.lblCapImporte.Size = new System.Drawing.Size(47, 15);
            this.lblCapImporte.TabIndex = 30;
            this.lblCapImporte.Text = "label2";
            // 
            // lblCapSaldo
            // 
            this.lblCapSaldo.AutoSize = true;
            this.lblCapSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCapSaldo.Location = new System.Drawing.Point(173, 70);
            this.lblCapSaldo.Name = "lblCapSaldo";
            this.lblCapSaldo.Size = new System.Drawing.Size(134, 15);
            this.lblCapSaldo.TabIndex = 29;
            this.lblCapSaldo.Text = "SALDO PENDIENTE";
            // 
            // nudImporte
            // 
            this.nudImporte.BackColor = System.Drawing.Color.White;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.ForeColor = System.Drawing.Color.Black;
            this.nudImporte.Location = new System.Drawing.Point(381, 99);
            this.nudImporte.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(152, 20);
            this.nudImporte.TabIndex = 3;
            this.nudImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudImporte.ThousandsSeparator = true;
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BackColor = System.Drawing.Color.Beige;
            this.lblTotalPedido.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPedido.Location = new System.Drawing.Point(12, 99);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(73, 23);
            this.lblTotalPedido.TabIndex = 6;
            this.lblTotalPedido.Text = "$0,00";
            // 
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.AutoSize = true;
            this.lblSaldoPendiente.BackColor = System.Drawing.Color.Beige;
            this.lblSaldoPendiente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPendiente.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoPendiente.Location = new System.Drawing.Point(172, 99);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(73, 23);
            this.lblSaldoPendiente.TabIndex = 8;
            this.lblSaldoPendiente.Text = "$0,00";
            // 
            // lblCapTotal
            // 
            this.lblCapTotal.AutoSize = true;
            this.lblCapTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCapTotal.Location = new System.Drawing.Point(11, 70);
            this.lblCapTotal.Name = "lblCapTotal";
            this.lblCapTotal.Size = new System.Drawing.Size(49, 15);
            this.lblCapTotal.TabIndex = 28;
            this.lblCapTotal.Text = "TOTAL";
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPedidoCliente.Location = new System.Drawing.Point(12, 17);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(57, 20);
            this.lblPedidoCliente.TabIndex = 27;
            this.lblPedidoCliente.Text = "label2";
            // 
            // FormRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.splitPagos);
            this.Name = "FormRegistrarPago";
            this.Text = "FormRegistrarPago";
            this.Load += new System.EventHandler(this.FormRegistrarPago_Load);
            this.splitPagos.Panel1.ResumeLayout(false);
            this.splitPagos.Panel1.PerformLayout();
            this.splitPagos.Panel2.ResumeLayout(false);
            this.splitPagos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagos)).EndInit();
            this.splitPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.pnlBuscarPagos.ResumeLayout(false);
            this.pnlBuscarPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.SplitContainer splitPagos;
        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblSaldoPendiente;
        private System.Windows.Forms.Panel pnlBuscarPagos;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblCapTotal;
        private System.Windows.Forms.Label lblPedidoCliente;
        private System.Windows.Forms.Label lblCapImporte;
        private System.Windows.Forms.Label lblCapSaldo;
    }
}