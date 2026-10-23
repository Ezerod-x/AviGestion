namespace AviGestion_.Interfaz
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLupa = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblDetNroPedido = new System.Windows.Forms.Label();
            this.lblDetCliente = new System.Windows.Forms.Label();
            this.txtDetCliente = new System.Windows.Forms.TextBox();
            this.lblDetFecha = new System.Windows.Forms.Label();
            this.txtDetFecha = new System.Windows.Forms.TextBox();
            this.lblDetEstado = new System.Windows.Forms.Label();
            this.txtDetEstado = new System.Windows.Forms.TextBox();
            this.lblDetProductos = new System.Windows.Forms.Label();
            this.dgvDetProductos = new System.Windows.Forms.DataGridView();
            this.colDetProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpDetBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerarComprobante = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnCerrarDetalle = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoBadge = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblDetalleTitle = new System.Windows.Forms.Label();
            this.dgvProductosPedido = new System.Windows.Forms.DataGridView();
            this.colProdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdQuitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpAltaBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.pnlBusqueda.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProductos)).BeginInit();
            this.flpDetBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnlAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).BeginInit();
            this.flpAltaBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblLupa.Location = new System.Drawing.Point(4, 10);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(43, 30);
            this.lblLupa.TabIndex = 0;
            this.lblLupa.Text = "🔍";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.pnlBusqueda.Controls.Add(this.lblLupa);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.btnAgregarPedido);
            this.pnlBusqueda.Location = new System.Drawing.Point(10, 8);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1040, 44);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(53, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(805, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPedido.Location = new System.Drawing.Point(870, 7);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(160, 30);
            this.btnAgregarPedido.TabIndex = 2;
            this.btnAgregarPedido.Text = "+ Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.lblDetNroPedido);
            this.pnlDetalle.Controls.Add(this.lblDetCliente);
            this.pnlDetalle.Controls.Add(this.txtDetCliente);
            this.pnlDetalle.Controls.Add(this.lblDetFecha);
            this.pnlDetalle.Controls.Add(this.txtDetFecha);
            this.pnlDetalle.Controls.Add(this.lblDetEstado);
            this.pnlDetalle.Controls.Add(this.txtDetEstado);
            this.pnlDetalle.Controls.Add(this.lblDetProductos);
            this.pnlDetalle.Controls.Add(this.dgvDetProductos);
            this.pnlDetalle.Controls.Add(this.flpDetBotones);
            this.pnlDetalle.Location = new System.Drawing.Point(10, 425);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1040, 370);
            this.pnlDetalle.TabIndex = 3;
            this.pnlDetalle.Visible = false;
            // 
            // lblDetNroPedido
            // 
            this.lblDetNroPedido.AutoSize = true;
            this.lblDetNroPedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetNroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetNroPedido.Location = new System.Drawing.Point(14, 12);
            this.lblDetNroPedido.Name = "lblDetNroPedido";
            this.lblDetNroPedido.Size = new System.Drawing.Size(216, 25);
            this.lblDetNroPedido.TabIndex = 0;
            this.lblDetNroPedido.Text = "Detalle del Pedido";
            // 
            // lblDetCliente
            // 
            this.lblDetCliente.AutoSize = true;
            this.lblDetCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetCliente.Location = new System.Drawing.Point(14, 52);
            this.lblDetCliente.Name = "lblDetCliente";
            this.lblDetCliente.Size = new System.Drawing.Size(79, 18);
            this.lblDetCliente.TabIndex = 1;
            this.lblDetCliente.Text = "CLIENTE";
            // 
            // txtDetCliente
            // 
            this.txtDetCliente.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDetCliente.Location = new System.Drawing.Point(14, 74);
            this.txtDetCliente.Name = "txtDetCliente";
            this.txtDetCliente.ReadOnly = true;
            this.txtDetCliente.Size = new System.Drawing.Size(480, 26);
            this.txtDetCliente.TabIndex = 2;
            // 
            // lblDetFecha
            // 
            this.lblDetFecha.AutoSize = true;
            this.lblDetFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetFecha.Location = new System.Drawing.Point(14, 110);
            this.lblDetFecha.Name = "lblDetFecha";
            this.lblDetFecha.Size = new System.Drawing.Size(63, 18);
            this.lblDetFecha.TabIndex = 3;
            this.lblDetFecha.Text = "FECHA";
            // 
            // txtDetFecha
            // 
            this.txtDetFecha.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDetFecha.Location = new System.Drawing.Point(14, 132);
            this.txtDetFecha.Name = "txtDetFecha";
            this.txtDetFecha.ReadOnly = true;
            this.txtDetFecha.Size = new System.Drawing.Size(480, 26);
            this.txtDetFecha.TabIndex = 4;
            // 
            // lblDetEstado
            // 
            this.lblDetEstado.AutoSize = true;
            this.lblDetEstado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetEstado.Location = new System.Drawing.Point(14, 168);
            this.lblDetEstado.Name = "lblDetEstado";
            this.lblDetEstado.Size = new System.Drawing.Size(76, 18);
            this.lblDetEstado.TabIndex = 5;
            this.lblDetEstado.Text = "ESTADO";
            // 
            // txtDetEstado
            // 
            this.txtDetEstado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtDetEstado.Location = new System.Drawing.Point(14, 190);
            this.txtDetEstado.Name = "txtDetEstado";
            this.txtDetEstado.ReadOnly = true;
            this.txtDetEstado.Size = new System.Drawing.Size(480, 26);
            this.txtDetEstado.TabIndex = 6;
            // 
            // lblDetProductos
            // 
            this.lblDetProductos.AutoSize = true;
            this.lblDetProductos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetProductos.Location = new System.Drawing.Point(511, 52);
            this.lblDetProductos.Name = "lblDetProductos";
            this.lblDetProductos.Size = new System.Drawing.Size(221, 18);
            this.lblDetProductos.TabIndex = 7;
            this.lblDetProductos.Text = "PRODUCTOS DEL PEDIDO";
            // 
            // dgvDetProductos
            // 
            this.dgvDetProductos.AllowUserToAddRows = false;
            this.dgvDetProductos.AllowUserToDeleteRows = false;
            this.dgvDetProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDetProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetProductos.ColumnHeadersHeight = 30;
            this.dgvDetProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetProducto,
            this.colDetCantidad});
            this.dgvDetProductos.EnableHeadersVisualStyles = false;
            this.dgvDetProductos.Font = new System.Drawing.Font("Verdana", 9F);
            this.dgvDetProductos.Location = new System.Drawing.Point(514, 74);
            this.dgvDetProductos.Name = "dgvDetProductos";
            this.dgvDetProductos.ReadOnly = true;
            this.dgvDetProductos.RowHeadersVisible = false;
            this.dgvDetProductos.RowHeadersWidth = 51;
            this.dgvDetProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetProductos.Size = new System.Drawing.Size(510, 226);
            this.dgvDetProductos.TabIndex = 8;
            // 
            // colDetProducto
            // 
            this.colDetProducto.FillWeight = 70F;
            this.colDetProducto.HeaderText = "Producto";
            this.colDetProducto.MinimumWidth = 6;
            this.colDetProducto.Name = "colDetProducto";
            this.colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.FillWeight = 30F;
            this.colDetCantidad.HeaderText = "Cantidad";
            this.colDetCantidad.MinimumWidth = 6;
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.ReadOnly = true;
            // 
            // flpDetBotones
            // 
            this.flpDetBotones.Controls.Add(this.btnGenerarComprobante);
            this.flpDetBotones.Controls.Add(this.btnFacturacion);
            this.flpDetBotones.Controls.Add(this.btnCerrarDetalle);
            this.flpDetBotones.Controls.Add(this.btnCancelarPedido);
            this.flpDetBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDetBotones.Location = new System.Drawing.Point(14, 322);
            this.flpDetBotones.Name = "flpDetBotones";
            this.flpDetBotones.Size = new System.Drawing.Size(1010, 44);
            this.flpDetBotones.TabIndex = 9;
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGenerarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarComprobante.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarComprobante.ForeColor = System.Drawing.Color.White;
            this.btnGenerarComprobante.Location = new System.Drawing.Point(827, 3);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(180, 36);
            this.btnGenerarComprobante.TabIndex = 0;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.UseVisualStyleBackColor = false;
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Location = new System.Drawing.Point(701, 3);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(120, 36);
            this.btnFacturacion.TabIndex = 1;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnCerrarDetalle
            // 
            this.btnCerrarDetalle.BackColor = System.Drawing.Color.White;
            this.btnCerrarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarDetalle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarDetalle.Location = new System.Drawing.Point(605, 3);
            this.btnCerrarDetalle.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnCerrarDetalle.Name = "btnCerrarDetalle";
            this.btnCerrarDetalle.Size = new System.Drawing.Size(90, 36);
            this.btnCerrarDetalle.TabIndex = 2;
            this.btnCerrarDetalle.Text = "Cerrar";
            this.btnCerrarDetalle.UseVisualStyleBackColor = false;
            this.btnCerrarDetalle.Click += new System.EventHandler(this.btnCerrarDetalle_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPedido.Location = new System.Drawing.Point(109, 3);
            this.btnCancelarPedido.Margin = new System.Windows.Forms.Padding(3, 3, 350, 3);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(140, 36);
            this.btnCancelarPedido.TabIndex = 3;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.ColumnHeadersHeight = 32;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCliente,
            this.colProductos,
            this.colFecha,
            this.colEstado});
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Font = new System.Drawing.Font("Verdana", 9F);
            this.dgvPedidos.Location = new System.Drawing.Point(10, 56);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1040, 560);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 8F;
            this.colId.HeaderText = "N° Pedido";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 22F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colProductos
            // 
            this.colProductos.FillWeight = 40F;
            this.colProductos.HeaderText = "Productos";
            this.colProductos.MinimumWidth = 6;
            this.colProductos.Name = "colProductos";
            this.colProductos.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 12F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 12F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            this.lblAyuda.Location = new System.Drawing.Point(12, 622);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(467, 18);
            this.lblAyuda.TabIndex = 2;
            this.lblAyuda.Text = "Doble clic en un pedido para ver el detalle y realizar acciones.";
            // 
            // pnlAlta
            // 
            this.pnlAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.pnlAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlta.Controls.Add(this.lblTituloAlta);
            this.pnlAlta.Controls.Add(this.lblEstadoTitulo);
            this.pnlAlta.Controls.Add(this.lblEstadoBadge);
            this.pnlAlta.Controls.Add(this.lblCliente);
            this.pnlAlta.Controls.Add(this.cboCliente);
            this.pnlAlta.Controls.Add(this.lblFecha);
            this.pnlAlta.Controls.Add(this.dtpFecha);
            this.pnlAlta.Controls.Add(this.lblProductos);
            this.pnlAlta.Controls.Add(this.lstProductos);
            this.pnlAlta.Controls.Add(this.lblCantidad);
            this.pnlAlta.Controls.Add(this.nudCantidad);
            this.pnlAlta.Controls.Add(this.btnAgregarProducto);
            this.pnlAlta.Controls.Add(this.lblDetalleTitle);
            this.pnlAlta.Controls.Add(this.dgvProductosPedido);
            this.pnlAlta.Controls.Add(this.flpAltaBotones);
            this.pnlAlta.Location = new System.Drawing.Point(10, 425);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(1040, 404);
            this.pnlAlta.TabIndex = 4;
            this.pnlAlta.Visible = false;
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTituloAlta.Location = new System.Drawing.Point(14, 12);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(278, 25);
            this.lblTituloAlta.TabIndex = 0;
            this.lblTituloAlta.Text = "Registrar Nuevo Pedido";
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEstadoTitulo.Location = new System.Drawing.Point(808, 16);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(76, 18);
            this.lblEstadoTitulo.TabIndex = 1;
            this.lblEstadoTitulo.Text = "ESTADO";
            // 
            // lblEstadoBadge
            // 
            this.lblEstadoBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.lblEstadoBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoBadge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblEstadoBadge.Location = new System.Drawing.Point(890, 12);
            this.lblEstadoBadge.Name = "lblEstadoBadge";
            this.lblEstadoBadge.Size = new System.Drawing.Size(110, 26);
            this.lblEstadoBadge.TabIndex = 2;
            this.lblEstadoBadge.Text = "Pendiente";
            this.lblEstadoBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCliente.Location = new System.Drawing.Point(14, 52);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 18);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "CLIENTE";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Verdana", 9F);
            this.cboCliente.Location = new System.Drawing.Point(14, 74);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(480, 26);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFecha.Location = new System.Drawing.Point(14, 110);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 18);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(14, 132);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(480, 26);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblProductos.Location = new System.Drawing.Point(14, 168);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(113, 18);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "PRODUCTOS";
            // 
            // lstProductos
            // 
            this.lstProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProductos.Font = new System.Drawing.Font("Verdana", 9F);
            this.lstProductos.ItemHeight = 18;
            this.lstProductos.Location = new System.Drawing.Point(14, 190);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(480, 92);
            this.lstProductos.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCantidad.Location = new System.Drawing.Point(14, 298);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 18);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Verdana", 9F);
            this.nudCantidad.Location = new System.Drawing.Point(14, 320);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(100, 26);
            this.nudCantidad.TabIndex = 10;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(124, 318);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(110, 30);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "+ Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblDetalleTitle
            // 
            this.lblDetalleTitle.AutoSize = true;
            this.lblDetalleTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetalleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDetalleTitle.Location = new System.Drawing.Point(511, 52);
            this.lblDetalleTitle.Name = "lblDetalleTitle";
            this.lblDetalleTitle.Size = new System.Drawing.Size(190, 18);
            this.lblDetalleTitle.TabIndex = 12;
            this.lblDetalleTitle.Text = "DETALLE DEL PEDIDO";
            // 
            // dgvProductosPedido
            // 
            this.dgvProductosPedido.AllowUserToAddRows = false;
            this.dgvProductosPedido.AllowUserToDeleteRows = false;
            this.dgvProductosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.dgvProductosPedido.ColumnHeadersHeight = 32;
            this.dgvProductosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdNombre,
            this.colProdCantidad,
            this.colProdStock,
            this.colProdQuitar});
            this.dgvProductosPedido.EnableHeadersVisualStyles = false;
            this.dgvProductosPedido.Font = new System.Drawing.Font("Verdana", 9F);
            this.dgvProductosPedido.Location = new System.Drawing.Point(514, 74);
            this.dgvProductosPedido.Name = "dgvProductosPedido";
            this.dgvProductosPedido.RowHeadersVisible = false;
            this.dgvProductosPedido.RowHeadersWidth = 51;
            this.dgvProductosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosPedido.Size = new System.Drawing.Size(510, 160);
            this.dgvProductosPedido.TabIndex = 13;
            this.dgvProductosPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosPedido_CellContentClick);
            // 
            // colProdNombre
            // 
            this.colProdNombre.HeaderText = "Producto";
            this.colProdNombre.MinimumWidth = 160;
            this.colProdNombre.Name = "colProdNombre";
            this.colProdNombre.ReadOnly = true;
            // 
            // colProdCantidad
            // 
            this.colProdCantidad.FillWeight = 40F;
            this.colProdCantidad.HeaderText = "Cantidad";
            this.colProdCantidad.MinimumWidth = 85;
            this.colProdCantidad.Name = "colProdCantidad";
            this.colProdCantidad.ReadOnly = true;
            // 
            // colProdStock
            // 
            this.colProdStock.FillWeight = 60F;
            this.colProdStock.HeaderText = "Stock disponible";
            this.colProdStock.MinimumWidth = 145;
            this.colProdStock.Name = "colProdStock";
            this.colProdStock.ReadOnly = true;
            // 
            // colProdQuitar
            // 
            this.colProdQuitar.FillWeight = 30F;
            this.colProdQuitar.HeaderText = "Quitar";
            this.colProdQuitar.MinimumWidth = 65;
            this.colProdQuitar.Name = "colProdQuitar";
            this.colProdQuitar.ReadOnly = true;
            // 
            // flpAltaBotones
            // 
            this.flpAltaBotones.Controls.Add(this.btnRegistrar);
            this.flpAltaBotones.Controls.Add(this.btnCancelarAlta);
            this.flpAltaBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAltaBotones.Location = new System.Drawing.Point(14, 356);
            this.flpAltaBotones.Name = "flpAltaBotones";
            this.flpAltaBotones.Size = new System.Drawing.Size(1010, 40);
            this.flpAltaBotones.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(857, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 36);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Pedido";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.BackColor = System.Drawing.Color.White;
            this.btnCancelarAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarAlta.Location = new System.Drawing.Point(751, 3);
            this.btnCancelarAlta.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarAlta.TabIndex = 1;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = false;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // FrmPedidos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1060, 781);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlAlta);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema AviGestión";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProductos)).EndInit();
            this.flpDetBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).EndInit();
            this.flpAltaBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblDetNroPedido;
        private System.Windows.Forms.Label lblDetCliente;
        private System.Windows.Forms.TextBox txtDetCliente;
        private System.Windows.Forms.Label lblDetFecha;
        private System.Windows.Forms.TextBox txtDetFecha;
        private System.Windows.Forms.Label lblDetEstado;
        private System.Windows.Forms.TextBox txtDetEstado;
        private System.Windows.Forms.Label lblDetProductos;
        private System.Windows.Forms.DataGridView dgvDetProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetCantidad;
        private System.Windows.Forms.FlowLayoutPanel flpDetBotones;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnCerrarDetalle;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnGenerarComprobante;
        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoBadge;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblDetalleTitle;
        private System.Windows.Forms.DataGridView dgvProductosPedido;
        private System.Windows.Forms.FlowLayoutPanel flpAltaBotones;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdQuitar;
    }
}