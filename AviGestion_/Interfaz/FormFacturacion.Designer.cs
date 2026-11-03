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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEtiquetaFactura = new System.Windows.Forms.Label();
            this.dgvListadoCompra = new System.Windows.Forms.DataGridView();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tabsFacturacion = new System.Windows.Forms.TabControl();
            this.tabPendientes = new System.Windows.Forms.TabPage();
            this.grbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLectura = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnConfirmarDespacho = new System.Windows.Forms.Button();
            this.tabFacturadosDia = new System.Windows.Forms.TabPage();
            this.lblResumenFacturados = new System.Windows.Forms.Label();
            this.dgvFacturados = new System.Windows.Forms.DataGridView();
            this.dtpFechaFacturados = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).BeginInit();
            this.tabsFacturacion.SuspendLayout();
            this.tabPendientes.SuspendLayout();
            this.grbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.tabFacturadosDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiquetaFactura
            // 
            this.lblEtiquetaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtiquetaFactura.AutoSize = true;
            this.lblEtiquetaFactura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblEtiquetaFactura.Location = new System.Drawing.Point(705, 33);
            this.lblEtiquetaFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiquetaFactura.Name = "lblEtiquetaFactura";
            this.lblEtiquetaFactura.Size = new System.Drawing.Size(398, 18);
            this.lblEtiquetaFactura.TabIndex = 27;
            this.lblEtiquetaFactura.Text = "Pedidos pendientes a facturar (últimos 30 días)";
            // 
            // dgvListadoCompra
            // 
            this.dgvListadoCompra.AllowUserToAddRows = false;
            this.dgvListadoCompra.AllowUserToDeleteRows = false;
            this.dgvListadoCompra.AllowUserToOrderColumns = true;
            this.dgvListadoCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvListadoCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListadoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoCompra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListadoCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListadoCompra.ColumnHeadersHeight = 26;
            this.dgvListadoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListadoCompra.Location = new System.Drawing.Point(11, 54);
            this.dgvListadoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoCompra.MultiSelect = false;
            this.dgvListadoCompra.Name = "dgvListadoCompra";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListadoCompra.RowHeadersVisible = false;
            this.dgvListadoCompra.RowHeadersWidth = 51;
            this.dgvListadoCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCompra.Size = new System.Drawing.Size(1120, 174);
            this.dgvListadoCompra.TabIndex = 25;
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(19, 231);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(44, 16);
            this.lblAyuda.TabIndex = 29;
            this.lblAyuda.Text = "label2";
            // 
            // tabsFacturacion
            // 
            this.tabsFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsFacturacion.Controls.Add(this.tabPendientes);
            this.tabsFacturacion.Controls.Add(this.tabFacturadosDia);
            this.tabsFacturacion.Location = new System.Drawing.Point(16, 263);
            this.tabsFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.tabsFacturacion.Name = "tabsFacturacion";
            this.tabsFacturacion.SelectedIndex = 0;
            this.tabsFacturacion.Size = new System.Drawing.Size(1120, 304);
            this.tabsFacturacion.TabIndex = 30;
            // 
            // tabPendientes
            // 
            this.tabPendientes.Controls.Add(this.grbDetalleCompra);
            this.tabPendientes.Location = new System.Drawing.Point(4, 25);
            this.tabPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabPendientes.Name = "tabPendientes";
            this.tabPendientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabPendientes.Size = new System.Drawing.Size(1112, 275);
            this.tabPendientes.TabIndex = 0;
            this.tabPendientes.Text = "Pendientes";
            this.tabPendientes.UseVisualStyleBackColor = true;
            // 
            // grbDetalleCompra
            // 
            this.grbDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.grbDetalleCompra.Controls.Add(this.label1);
            this.grbDetalleCompra.Controls.Add(this.lblLectura);
            this.grbDetalleCompra.Controls.Add(this.lblTotalPagar);
            this.grbDetalleCompra.Controls.Add(this.dgvDetalle);
            this.grbDetalleCompra.Controls.Add(this.lblPedidoCliente);
            this.grbDetalleCompra.Controls.Add(this.btnCancelarFactura);
            this.grbDetalleCompra.Controls.Add(this.btnConfirmarDespacho);
            this.grbDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDetalleCompra.Location = new System.Drawing.Point(4, 4);
            this.grbDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.grbDetalleCompra.Name = "grbDetalleCompra";
            this.grbDetalleCompra.Padding = new System.Windows.Forms.Padding(4);
            this.grbDetalleCompra.Size = new System.Drawing.Size(1104, 267);
            this.grbDetalleCompra.TabIndex = 29;
            this.grbDetalleCompra.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(24, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Importe total facturado";
            // 
            // lblLectura
            // 
            this.lblLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLectura.AutoSize = true;
            this.lblLectura.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLectura.Location = new System.Drawing.Point(934, 20);
            this.lblLectura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(123, 20);
            this.lblLectura.TabIndex = 22;
            this.lblLectura.Text = "Solo lectura";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagar.Location = new System.Drawing.Point(48, 224);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(21, 24);
            this.lblTotalPagar.TabIndex = 21;
            this.lblTotalPagar.Text = "0";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDetalle.ColumnHeadersHeight = 26;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDetalle.Location = new System.Drawing.Point(24, 46);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1059, 144);
            this.dgvDetalle.TabIndex = 19;
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblPedidoCliente.Location = new System.Drawing.Point(24, 20);
            this.lblPedidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(66, 24);
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
            this.btnCancelarFactura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancelarFactura.Location = new System.Drawing.Point(699, 214);
            this.btnCancelarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(143, 46);
            this.btnCancelarFactura.TabIndex = 17;
            this.btnCancelarFactura.Text = "Cancelar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btnConfirmarDespacho
            // 
            this.btnConfirmarDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarDespacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnConfirmarDespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarDespacho.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarDespacho.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarDespacho.Location = new System.Drawing.Point(863, 214);
            this.btnConfirmarDespacho.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarDespacho.Name = "btnConfirmarDespacho";
            this.btnConfirmarDespacho.Size = new System.Drawing.Size(233, 46);
            this.btnConfirmarDespacho.TabIndex = 18;
            this.btnConfirmarDespacho.Text = "Confirmar Despacho";
            this.btnConfirmarDespacho.UseVisualStyleBackColor = false;
            this.btnConfirmarDespacho.Click += new System.EventHandler(this.btnConfirmarDespacho_Click);
            // 
            // tabFacturadosDia
            // 
            this.tabFacturadosDia.BackColor = System.Drawing.Color.White;
            this.tabFacturadosDia.Controls.Add(this.lblResumenFacturados);
            this.tabFacturadosDia.Controls.Add(this.dgvFacturados);
            this.tabFacturadosDia.Controls.Add(this.dtpFechaFacturados);
            this.tabFacturadosDia.Location = new System.Drawing.Point(4, 25);
            this.tabFacturadosDia.Margin = new System.Windows.Forms.Padding(4);
            this.tabFacturadosDia.Name = "tabFacturadosDia";
            this.tabFacturadosDia.Padding = new System.Windows.Forms.Padding(4);
            this.tabFacturadosDia.Size = new System.Drawing.Size(1112, 275);
            this.tabFacturadosDia.TabIndex = 1;
            this.tabFacturadosDia.Text = "FacturadosDelDia";
            // 
            // lblResumenFacturados 
            // 
            this.lblResumenFacturados.AutoSize = true;
            this.lblResumenFacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenFacturados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblResumenFacturados.Location = new System.Drawing.Point(279, 9);
            this.lblResumenFacturados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumenFacturados.Name = "lblResumenFacturados";
            this.lblResumenFacturados.Size = new System.Drawing.Size(103, 20);
            this.lblResumenFacturados.TabIndex = 2;
            this.lblResumenFacturados.Text = "Facturados";
            // 
            // dgvFacturados
            // 
            this.dgvFacturados.AllowUserToAddRows = false;
            this.dgvFacturados.AllowUserToDeleteRows = false;
            this.dgvFacturados.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvFacturados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFacturados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturados.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFacturados.ColumnHeadersHeight = 26;
            this.dgvFacturados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturados.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFacturados.EnableHeadersVisualStyles = false;
            this.dgvFacturados.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvFacturados.Location = new System.Drawing.Point(9, 50);
            this.dgvFacturados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturados.MultiSelect = false;
            this.dgvFacturados.Name = "dgvFacturados";
            this.dgvFacturados.ReadOnly = true;
            this.dgvFacturados.RowHeadersVisible = false;
            this.dgvFacturados.RowHeadersWidth = 51;
            this.dgvFacturados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturados.Size = new System.Drawing.Size(1092, 208);
            this.dgvFacturados.TabIndex = 1;
            // 
            // dtpFechaFacturados
            // 
            this.dtpFechaFacturados.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaFacturados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFacturados.Location = new System.Drawing.Point(4, 4);
            this.dtpFechaFacturados.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFacturados.MaxDate = new System.DateTime(2026, 10, 24, 0, 0, 0, 0);
            this.dtpFechaFacturados.Name = "dtpFechaFacturados";
            this.dtpFechaFacturados.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFacturados.TabIndex = 0;
            this.dtpFechaFacturados.Value = new System.DateTime(2026, 10, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "🔍 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(72, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(597, 22);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1152, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.tabsFacturacion);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblEtiquetaFactura);
            this.Controls.Add(this.dgvListadoCompra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).EndInit();
            this.tabsFacturacion.ResumeLayout(false);
            this.tabPendientes.ResumeLayout(false);
            this.grbDetalleCompra.ResumeLayout(false);
            this.grbDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.tabFacturadosDia.ResumeLayout(false);
            this.tabFacturadosDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEtiquetaFactura;
        private System.Windows.Forms.DataGridView dgvListadoCompra;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.TabControl tabsFacturacion;
        private System.Windows.Forms.TabPage tabPendientes;
        private System.Windows.Forms.GroupBox grbDetalleCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblPedidoCliente;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnConfirmarDespacho;
        private System.Windows.Forms.TabPage tabFacturadosDia;
        private System.Windows.Forms.Label lblResumenFacturados;
        private System.Windows.Forms.DataGridView dgvFacturados;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}