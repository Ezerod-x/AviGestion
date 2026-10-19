namespace AviGestion_.Interfaz
{
    partial class FrmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.groupBoxAlta = new System.Windows.Forms.Panel();
            this.lblDetallePedido = new System.Windows.Forms.Label();
            this.dgvProductosPedido = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTitulo
            //
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.panelTitulo.Controls.Add(this.btnVolver);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(900, 60);
            this.panelTitulo.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Pedidos";
            //
            // btnVolver
            //
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(740, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.btnAgregarPedido);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 34);
            this.panel1.TabIndex = 1;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "🔍";
            //
            // txtBuscar
            //
            this.txtBuscar.Location = new System.Drawing.Point(28, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            //
            // btnAgregarPedido
            //
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPedido.Location = new System.Drawing.Point(720, 4);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(140, 26);
            this.btnAgregarPedido.TabIndex = 2;
            this.btnAgregarPedido.Text = "+ Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            //
            // dgvPedidos
            //
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroPedido,
            this.colCliente,
            this.colProductos,
            this.colFecha,
            this.colEstado,
            this.colAccion});
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPedidos.Location = new System.Drawing.Point(20, 110);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(860, 150);
            this.dgvPedidos.TabIndex = 2;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            //
            // colNroPedido
            //
            this.colNroPedido.HeaderText = "N° Pedido";
            this.colNroPedido.MinimumWidth = 8;
            this.colNroPedido.Name = "colNroPedido";
            this.colNroPedido.ReadOnly = true;
            this.colNroPedido.Width = 80;
            //
            // colCliente
            //
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 170;
            //
            // colProductos
            //
            this.colProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductos.HeaderText = "Productos";
            this.colProductos.MinimumWidth = 6;
            this.colProductos.Name = "colProductos";
            this.colProductos.ReadOnly = true;
            //
            // colFecha
            //
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 90;
            //
            // colEstado
            //
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 90;
            //
            // colAccion
            //
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.colAccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAccion.HeaderText = "Acción";
            this.colAccion.MinimumWidth = 6;
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Width = 90;
            //
            // btnRegistrarPago
            //
            this.btnRegistrarPago.BackColor = System.Drawing.Color.White;
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnRegistrarPago.Location = new System.Drawing.Point(590, 268);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(140, 26);
            this.btnRegistrarPago.TabIndex = 3;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            //
            // btnComprobante
            //
            this.btnComprobante.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.ForeColor = System.Drawing.Color.White;
            this.btnComprobante.Location = new System.Drawing.Point(740, 268);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(140, 26);
            this.btnComprobante.TabIndex = 4;
            this.btnComprobante.Text = "Generar comprobante";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            //
            // groupBoxAlta
            //
            this.groupBoxAlta.BackColor = System.Drawing.Color.White;
            this.groupBoxAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxAlta.Controls.Add(this.lblDetallePedido);
            this.groupBoxAlta.Controls.Add(this.dgvProductosPedido);
            this.groupBoxAlta.Controls.Add(this.btnAgregarProducto);
            this.groupBoxAlta.Controls.Add(this.btnRegistrar);
            this.groupBoxAlta.Controls.Add(this.btnCancelar);
            this.groupBoxAlta.Controls.Add(this.label9);
            this.groupBoxAlta.Controls.Add(this.label8);
            this.groupBoxAlta.Controls.Add(this.nudCantidad);
            this.groupBoxAlta.Controls.Add(this.label7);
            this.groupBoxAlta.Controls.Add(this.lstProductos);
            this.groupBoxAlta.Controls.Add(this.label6);
            this.groupBoxAlta.Controls.Add(this.dtpFecha);
            this.groupBoxAlta.Controls.Add(this.label5);
            this.groupBoxAlta.Controls.Add(this.cboCliente);
            this.groupBoxAlta.Controls.Add(this.label4);
            this.groupBoxAlta.Controls.Add(this.label3);
            this.groupBoxAlta.Location = new System.Drawing.Point(20, 305);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(860, 305);
            this.groupBoxAlta.TabIndex = 5;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registrar Nuevo Pedido";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label8.Location = new System.Drawing.Point(688, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ESTADO";
            //
            // label9
            //
            this.label9.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(138, 106, 0);
            this.label9.Location = new System.Drawing.Point(750, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pendiente";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLIENTE";
            //
            // cboCliente
            //
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(15, 68);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(370, 21);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FECHA";
            //
            // dtpFecha
            //
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(370, 20);
            this.dtpFecha.TabIndex = 6;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "PRODUCTOS";
            //
            // lstProductos
            //
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.IntegralHeight = false;
            this.lstProductos.Location = new System.Drawing.Point(15, 168);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.lstProductos.Size = new System.Drawing.Size(370, 76);
            this.lstProductos.TabIndex = 8;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.label7.Location = new System.Drawing.Point(15, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CANTIDAD";
            //
            // nudCantidad
            //
            this.nudCantidad.Location = new System.Drawing.Point(88, 252);
            this.nudCantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(70, 20);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // btnAgregarProducto
            //
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(172, 249);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 26);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "+ Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            //
            // lblDetallePedido
            //
            this.lblDetallePedido.AutoSize = true;
            this.lblDetallePedido.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblDetallePedido.Location = new System.Drawing.Point(400, 50);
            this.lblDetallePedido.Name = "lblDetallePedido";
            this.lblDetallePedido.Size = new System.Drawing.Size(121, 13);
            this.lblDetallePedido.TabIndex = 12;
            this.lblDetallePedido.Text = "DETALLE DEL PEDIDO";
            //
            // dgvProductosPedido
            //
            this.dgvProductosPedido.AllowUserToAddRows = false;
            this.dgvProductosPedido.AllowUserToDeleteRows = false;
            this.dgvProductosPedido.AllowUserToResizeRows = false;
            this.dgvProductosPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvProductosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colStock,
            this.colQuitar});
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductosPedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosPedido.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvProductosPedido.Location = new System.Drawing.Point(400, 68);
            this.dgvProductosPedido.MultiSelect = false;
            this.dgvProductosPedido.Name = "dgvProductosPedido";
            this.dgvProductosPedido.ReadOnly = true;
            this.dgvProductosPedido.RowHeadersVisible = false;
            this.dgvProductosPedido.RowTemplate.Height = 24;
            this.dgvProductosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosPedido.Size = new System.Drawing.Size(445, 176);
            this.dgvProductosPedido.TabIndex = 13;
            this.dgvProductosPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosPedido_CellContentClick);
            //
            // colProducto
            //
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            //
            // colCantidad
            //
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 65;
            //
            // colStock
            //
            this.colStock.HeaderText = "Stock disponible";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 115;
            //
            // colQuitar
            //
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.colQuitar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuitar.HeaderText = "Quitar";
            this.colQuitar.MinimumWidth = 6;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.ReadOnly = true;
            this.colQuitar.Width = 65;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCancelar.Location = new System.Drawing.Point(625, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnRegistrar
            //
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(735, 260);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 30);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar Pedido";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            //
            // FrmPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.groupBoxAlta);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Pedidos";
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Panel groupBoxAlta;
        private System.Windows.Forms.Label lblDetallePedido;
        private System.Windows.Forms.DataGridView dgvProductosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuitar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccion;
    }
}