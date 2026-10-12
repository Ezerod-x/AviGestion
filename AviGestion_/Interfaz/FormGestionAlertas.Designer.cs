namespace AviGestion_.UI
{
    partial class FormAlertas
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

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbTipoAlerta = new System.Windows.Forms.ComboBox();
            this.cmbEstadoAlerta = new System.Windows.Forms.ComboBox();
            this.btnAlternarVista = new System.Windows.Forms.Button();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.dgvAlertas = new System.Windows.Forms.DataGridView();
            this.colProductoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoriaAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaGeneracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaResolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionarAlerta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lblLCodigo = new System.Windows.Forms.Label();
            this.lblVCodigo = new System.Windows.Forms.Label();
            this.lblLProducto = new System.Windows.Forms.Label();
            this.lblVProducto = new System.Windows.Forms.Label();
            this.lblLCategoria = new System.Windows.Forms.Label();
            this.lblVCategoria = new System.Windows.Forms.Label();
            this.lblLStockActual = new System.Windows.Forms.Label();
            this.lblVStockActual = new System.Windows.Forms.Label();
            this.lblLStockMin = new System.Windows.Forms.Label();
            this.lblVStockMin = new System.Windows.Forms.Label();
            this.lblLStockMax = new System.Windows.Forms.Label();
            this.lblVStockMax = new System.Windows.Forms.Label();
            this.lblLEstado = new System.Windows.Forms.Label();
            this.lblVEstado = new System.Windows.Forms.Label();
            this.lblLCantAlertas = new System.Windows.Forms.Label();
            this.lblVCantAlertas = new System.Windows.Forms.Label();
            this.pnlGraficos = new System.Windows.Forms.Panel();
            this.cmbVistaGrafico = new System.Windows.Forms.ComboBox();
            this.chartAlertas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).BeginInit();
            this.grpDetalle.SuspendLayout();
            this.pnlGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlertas)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.pnlHeader.Controls.Add(this.btnCerrarSesion);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(750, 16);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(130, 28);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(900, 60);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gestión de Alertas de Stock";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtBuscar
            //
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.Location = new System.Drawing.Point(20, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // cmbTipoAlerta
            //
            this.cmbTipoAlerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAlerta.Items.AddRange(new object[] {
            "Todas",
            "Stock Mínimo",
            "Stock Máximo"});
            this.cmbTipoAlerta.Location = new System.Drawing.Point(290, 80);
            this.cmbTipoAlerta.Name = "cmbTipoAlerta";
            this.cmbTipoAlerta.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoAlerta.TabIndex = 2;
            this.cmbTipoAlerta.SelectedIndexChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // cmbEstadoAlerta
            //
            this.cmbEstadoAlerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoAlerta.Items.AddRange(new object[] {
            "Todas",
            "Activa",
            "Resuelta"});
            this.cmbEstadoAlerta.Location = new System.Drawing.Point(450, 80);
            this.cmbEstadoAlerta.Name = "cmbEstadoAlerta";
            this.cmbEstadoAlerta.Size = new System.Drawing.Size(150, 21);
            this.cmbEstadoAlerta.TabIndex = 3;
            this.cmbEstadoAlerta.SelectedIndexChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // btnAlternarVista
            //
            this.btnAlternarVista.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnAlternarVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlternarVista.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAlternarVista.ForeColor = System.Drawing.Color.White;
            this.btnAlternarVista.Location = new System.Drawing.Point(700, 78);
            this.btnAlternarVista.Name = "btnAlternarVista";
            this.btnAlternarVista.Size = new System.Drawing.Size(180, 27);
            this.btnAlternarVista.TabIndex = 4;
            this.btnAlternarVista.Text = "📊 Ver Gráficos";
            this.btnAlternarVista.UseVisualStyleBackColor = false;
            this.btnAlternarVista.Click += new System.EventHandler(this.btnAlternarVista_Click);
            //
            // chkFiltrarFecha
            //
            this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFiltrarFecha.Location = new System.Drawing.Point(20, 117);
            this.chkFiltrarFecha.Name = "chkFiltrarFecha";
            this.chkFiltrarFecha.Size = new System.Drawing.Size(109, 19);
            this.chkFiltrarFecha.TabIndex = 13;
            this.chkFiltrarFecha.Text = "Filtrar por fecha";
            this.chkFiltrarFecha.UseVisualStyleBackColor = true;
            this.chkFiltrarFecha.CheckedChanged += new System.EventHandler(this.chkFiltrarFecha_CheckedChanged);
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesde.Location = new System.Drawing.Point(150, 117);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 15);
            this.lblDesde.TabIndex = 12;
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(200, 113);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 20);
            this.dtpDesde.TabIndex = 5;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHasta.Location = new System.Drawing.Point(335, 117);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 15);
            this.lblHasta.TabIndex = 11;
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(380, 113);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 20);
            this.dtpHasta.TabIndex = 6;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // btnLimpiarFiltros
            //
            this.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(700, 111);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(180, 27);
            this.btnLimpiarFiltros.TabIndex = 7;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            //
            // pnlGrilla
            //
            this.pnlGrilla.Controls.Add(this.dgvAlertas);
            this.pnlGrilla.Controls.Add(this.lblSinResultados);
            this.pnlGrilla.Controls.Add(this.grpDetalle);
            this.pnlGrilla.Location = new System.Drawing.Point(20, 155);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(860, 460);
            this.pnlGrilla.TabIndex = 8;
            //
            // dgvAlertas
            //
            this.dgvAlertas.AllowUserToAddRows = false;
            this.dgvAlertas.AllowUserToDeleteRows = false;
            this.dgvAlertas.AutoGenerateColumns = false;
            this.dgvAlertas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlertas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.dgvAlertas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAlertas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAlertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoAlerta,
            this.colCodigoAlerta,
            this.colCategoriaAlerta,
            this.colTipoAlerta,
            this.colEstadoAlerta,
            this.colFechaGeneracion,
            this.colFechaResolucion,
            this.colSeleccionarAlerta});
            this.dgvAlertas.Location = new System.Drawing.Point(0, 0);
            this.dgvAlertas.Name = "dgvAlertas";
            this.dgvAlertas.ReadOnly = true;
            this.dgvAlertas.RowHeadersVisible = false;
            this.dgvAlertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertas.Size = new System.Drawing.Size(860, 260);
            this.dgvAlertas.TabIndex = 0;
            this.dgvAlertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlertas_CellContentClick);
            this.dgvAlertas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlertas_CellFormatting);
            //
            // colProductoAlerta
            //
            this.colProductoAlerta.DataPropertyName = "Producto";
            this.colProductoAlerta.HeaderText = "Producto";
            this.colProductoAlerta.Name = "colProductoAlerta";
            this.colProductoAlerta.ReadOnly = true;
            this.colProductoAlerta.Width = 150;
            //
            // colCodigoAlerta
            //
            this.colCodigoAlerta.DataPropertyName = "Codigo";
            this.colCodigoAlerta.HeaderText = "Código";
            this.colCodigoAlerta.Name = "colCodigoAlerta";
            this.colCodigoAlerta.ReadOnly = true;
            this.colCodigoAlerta.Width = 70;
            //
            // colCategoriaAlerta
            //
            this.colCategoriaAlerta.DataPropertyName = "Categoria";
            this.colCategoriaAlerta.HeaderText = "Categoría";
            this.colCategoriaAlerta.Name = "colCategoriaAlerta";
            this.colCategoriaAlerta.ReadOnly = true;
            this.colCategoriaAlerta.Width = 90;
            //
            // colTipoAlerta
            //
            this.colTipoAlerta.DataPropertyName = "TipoAlerta";
            this.colTipoAlerta.HeaderText = "Tipo de Alerta";
            this.colTipoAlerta.Name = "colTipoAlerta";
            this.colTipoAlerta.ReadOnly = true;
            this.colTipoAlerta.Width = 110;
            //
            // colEstadoAlerta
            //
            this.colEstadoAlerta.DataPropertyName = "Estado";
            this.colEstadoAlerta.HeaderText = "Estado";
            this.colEstadoAlerta.Name = "colEstadoAlerta";
            this.colEstadoAlerta.ReadOnly = true;
            this.colEstadoAlerta.Width = 80;
            //
            // colFechaGeneracion
            //
            this.colFechaGeneracion.DataPropertyName = "FechaGeneracion";
            this.colFechaGeneracion.HeaderText = "Generada";
            this.colFechaGeneracion.Name = "colFechaGeneracion";
            this.colFechaGeneracion.ReadOnly = true;
            this.colFechaGeneracion.Width = 110;
            //
            // colFechaResolucion
            //
            this.colFechaResolucion.DataPropertyName = "FechaResolucion";
            this.colFechaResolucion.HeaderText = "Resuelta";
            this.colFechaResolucion.Name = "colFechaResolucion";
            this.colFechaResolucion.ReadOnly = true;
            this.colFechaResolucion.Width = 110;
            //
            // colSeleccionarAlerta
            //
            this.colSeleccionarAlerta.HeaderText = "Acción";
            this.colSeleccionarAlerta.Name = "colSeleccionarAlerta";
            this.colSeleccionarAlerta.ReadOnly = true;
            this.colSeleccionarAlerta.Text = "Ver Detalle";
            this.colSeleccionarAlerta.UseColumnTextForButtonValue = true;
            this.colSeleccionarAlerta.Width = 100;
            //
            // lblSinResultados
            //
            this.lblSinResultados.BackColor = System.Drawing.Color.White;
            this.lblSinResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSinResultados.ForeColor = System.Drawing.Color.Gray;
            this.lblSinResultados.Location = new System.Drawing.Point(0, 100);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(860, 60);
            this.lblSinResultados.TabIndex = 1;
            this.lblSinResultados.Text = "No existen alertas con los criterios aplicados.";
            this.lblSinResultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinResultados.Visible = false;
            //
            // grpDetalle
            //
            this.grpDetalle.Controls.Add(this.lblLCodigo);
            this.grpDetalle.Controls.Add(this.lblVCodigo);
            this.grpDetalle.Controls.Add(this.lblLProducto);
            this.grpDetalle.Controls.Add(this.lblVProducto);
            this.grpDetalle.Controls.Add(this.lblLCategoria);
            this.grpDetalle.Controls.Add(this.lblVCategoria);
            this.grpDetalle.Controls.Add(this.lblLStockActual);
            this.grpDetalle.Controls.Add(this.lblVStockActual);
            this.grpDetalle.Controls.Add(this.lblLStockMin);
            this.grpDetalle.Controls.Add(this.lblVStockMin);
            this.grpDetalle.Controls.Add(this.lblLStockMax);
            this.grpDetalle.Controls.Add(this.lblVStockMax);
            this.grpDetalle.Controls.Add(this.lblLEstado);
            this.grpDetalle.Controls.Add(this.lblVEstado);
            this.grpDetalle.Controls.Add(this.lblLCantAlertas);
            this.grpDetalle.Controls.Add(this.lblVCantAlertas);
            this.grpDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(0, 270);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(860, 190);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Producto Seleccionado";
            //
            // lblLCodigo
            //
            this.lblLCodigo.AutoSize = true;
            this.lblLCodigo.Location = new System.Drawing.Point(20, 35);
            this.lblLCodigo.Name = "lblLCodigo";
            this.lblLCodigo.Size = new System.Drawing.Size(48, 15);
            this.lblLCodigo.TabIndex = 0;
            this.lblLCodigo.Text = "Código:";
            //
            // lblVCodigo
            //
            this.lblVCodigo.AutoSize = true;
            this.lblVCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVCodigo.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVCodigo.Location = new System.Drawing.Point(100, 35);
            this.lblVCodigo.Name = "lblVCodigo";
            this.lblVCodigo.Size = new System.Drawing.Size(12, 15);
            this.lblVCodigo.TabIndex = 1;
            this.lblVCodigo.Text = "-";
            //
            // lblLProducto
            //
            this.lblLProducto.AutoSize = true;
            this.lblLProducto.Location = new System.Drawing.Point(280, 35);
            this.lblLProducto.Name = "lblLProducto";
            this.lblLProducto.Size = new System.Drawing.Size(61, 15);
            this.lblLProducto.TabIndex = 2;
            this.lblLProducto.Text = "Producto:";
            //
            // lblVProducto
            //
            this.lblVProducto.AutoSize = true;
            this.lblVProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVProducto.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVProducto.Location = new System.Drawing.Point(370, 35);
            this.lblVProducto.Name = "lblVProducto";
            this.lblVProducto.Size = new System.Drawing.Size(12, 15);
            this.lblVProducto.TabIndex = 3;
            this.lblVProducto.Text = "-";
            //
            // lblLCategoria
            //
            this.lblLCategoria.AutoSize = true;
            this.lblLCategoria.Location = new System.Drawing.Point(20, 65);
            this.lblLCategoria.Name = "lblLCategoria";
            this.lblLCategoria.Size = new System.Drawing.Size(63, 15);
            this.lblLCategoria.TabIndex = 4;
            this.lblLCategoria.Text = "Categoría:";
            //
            // lblVCategoria
            //
            this.lblVCategoria.AutoSize = true;
            this.lblVCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVCategoria.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVCategoria.Location = new System.Drawing.Point(100, 65);
            this.lblVCategoria.Name = "lblVCategoria";
            this.lblVCategoria.Size = new System.Drawing.Size(12, 15);
            this.lblVCategoria.TabIndex = 5;
            this.lblVCategoria.Text = "-";
            //
            // lblLStockActual
            //
            this.lblLStockActual.AutoSize = true;
            this.lblLStockActual.Location = new System.Drawing.Point(280, 65);
            this.lblLStockActual.Name = "lblLStockActual";
            this.lblLStockActual.Size = new System.Drawing.Size(80, 15);
            this.lblLStockActual.TabIndex = 6;
            this.lblLStockActual.Text = "Stock Actual:";
            //
            // lblVStockActual
            //
            this.lblVStockActual.AutoSize = true;
            this.lblVStockActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVStockActual.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVStockActual.Location = new System.Drawing.Point(390, 65);
            this.lblVStockActual.Name = "lblVStockActual";
            this.lblVStockActual.Size = new System.Drawing.Size(12, 15);
            this.lblVStockActual.TabIndex = 7;
            this.lblVStockActual.Text = "-";
            //
            // lblLStockMin
            //
            this.lblLStockMin.AutoSize = true;
            this.lblLStockMin.Location = new System.Drawing.Point(20, 95);
            this.lblLStockMin.Name = "lblLStockMin";
            this.lblLStockMin.Size = new System.Drawing.Size(87, 15);
            this.lblLStockMin.TabIndex = 8;
            this.lblLStockMin.Text = "Stock Mínimo:";
            //
            // lblVStockMin
            //
            this.lblVStockMin.AutoSize = true;
            this.lblVStockMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVStockMin.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVStockMin.Location = new System.Drawing.Point(120, 95);
            this.lblVStockMin.Name = "lblVStockMin";
            this.lblVStockMin.Size = new System.Drawing.Size(12, 15);
            this.lblVStockMin.TabIndex = 9;
            this.lblVStockMin.Text = "-";
            //
            // lblLStockMax
            //
            this.lblLStockMax.AutoSize = true;
            this.lblLStockMax.Location = new System.Drawing.Point(280, 95);
            this.lblLStockMax.Name = "lblLStockMax";
            this.lblLStockMax.Size = new System.Drawing.Size(90, 15);
            this.lblLStockMax.TabIndex = 10;
            this.lblLStockMax.Text = "Stock Máximo:";
            //
            // lblVStockMax
            //
            this.lblVStockMax.AutoSize = true;
            this.lblVStockMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVStockMax.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVStockMax.Location = new System.Drawing.Point(385, 95);
            this.lblVStockMax.Name = "lblVStockMax";
            this.lblVStockMax.Size = new System.Drawing.Size(12, 15);
            this.lblVStockMax.TabIndex = 11;
            this.lblVStockMax.Text = "-";
            //
            // lblLEstado
            //
            this.lblLEstado.AutoSize = true;
            this.lblLEstado.Location = new System.Drawing.Point(20, 125);
            this.lblLEstado.Name = "lblLEstado";
            this.lblLEstado.Size = new System.Drawing.Size(84, 15);
            this.lblLEstado.TabIndex = 12;
            this.lblLEstado.Text = "Estado Actual:";
            //
            // lblVEstado
            //
            this.lblVEstado.AutoSize = true;
            this.lblVEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVEstado.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVEstado.Location = new System.Drawing.Point(125, 125);
            this.lblVEstado.Name = "lblVEstado";
            this.lblVEstado.Size = new System.Drawing.Size(12, 15);
            this.lblVEstado.TabIndex = 13;
            this.lblVEstado.Text = "-";
            //
            // lblLCantAlertas
            //
            this.lblLCantAlertas.AutoSize = true;
            this.lblLCantAlertas.Location = new System.Drawing.Point(280, 125);
            this.lblLCantAlertas.Name = "lblLCantAlertas";
            this.lblLCantAlertas.Size = new System.Drawing.Size(106, 15);
            this.lblLCantAlertas.TabIndex = 14;
            this.lblLCantAlertas.Text = "Alertas Históricas:";
            //
            // lblVCantAlertas
            //
            this.lblVCantAlertas.AutoSize = true;
            this.lblVCantAlertas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVCantAlertas.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblVCantAlertas.Location = new System.Drawing.Point(410, 125);
            this.lblVCantAlertas.Name = "lblVCantAlertas";
            this.lblVCantAlertas.Size = new System.Drawing.Size(12, 15);
            this.lblVCantAlertas.TabIndex = 15;
            this.lblVCantAlertas.Text = "-";
            //
            // pnlGraficos
            //
            this.pnlGraficos.Controls.Add(this.cmbVistaGrafico);
            this.pnlGraficos.Controls.Add(this.chartAlertas);
            this.pnlGraficos.Location = new System.Drawing.Point(20, 155);
            this.pnlGraficos.Name = "pnlGraficos";
            this.pnlGraficos.Size = new System.Drawing.Size(860, 460);
            this.pnlGraficos.TabIndex = 9;
            this.pnlGraficos.Visible = false;
            //
            // cmbVistaGrafico
            //
            this.cmbVistaGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVistaGrafico.Items.AddRange(new object[] {
            "Alertas por Tipo de Alerta",
            "Alertas por Producto",
            "Alertas por Categoría",
            "Alertas por Período (Mes)"});
            this.cmbVistaGrafico.Location = new System.Drawing.Point(0, 0);
            this.cmbVistaGrafico.Name = "cmbVistaGrafico";
            this.cmbVistaGrafico.Size = new System.Drawing.Size(300, 21);
            this.cmbVistaGrafico.TabIndex = 0;
            this.cmbVistaGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbVistaGrafico_SelectedIndexChanged);
            //
            // chartAlertas
            //
            this.chartAlertas.Location = new System.Drawing.Point(0, 35);
            this.chartAlertas.Name = "chartAlertas";
            this.chartAlertas.Size = new System.Drawing.Size(860, 425);
            this.chartAlertas.TabIndex = 1;
            this.chartAlertas.Text = "chartAlertas";
            //
            // btnVolver
            //
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnVolver.Location = new System.Drawing.Point(20, 630);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 32);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // FormAlertas
            //
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            this.ClientSize = new System.Drawing.Size(900, 695);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlGraficos);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.chkFiltrarFecha);
            this.Controls.Add(this.btnAlternarVista);
            this.Controls.Add(this.cmbEstadoAlerta);
            this.Controls.Add(this.cmbTipoAlerta);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormAlertas";
            this.Text = "Sistema AviGestión";
            this.pnlHeader.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.pnlGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbTipoAlerta;
        private System.Windows.Forms.ComboBox cmbEstadoAlerta;
        private System.Windows.Forms.Button btnAlternarVista;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridView dgvAlertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoriaAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaResolucion;
        private System.Windows.Forms.DataGridViewButtonColumn colSeleccionarAlerta;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblLCodigo;
        private System.Windows.Forms.Label lblVCodigo;
        private System.Windows.Forms.Label lblLProducto;
        private System.Windows.Forms.Label lblVProducto;
        private System.Windows.Forms.Label lblLCategoria;
        private System.Windows.Forms.Label lblVCategoria;
        private System.Windows.Forms.Label lblLStockActual;
        private System.Windows.Forms.Label lblVStockActual;
        private System.Windows.Forms.Label lblLStockMin;
        private System.Windows.Forms.Label lblVStockMin;
        private System.Windows.Forms.Label lblLStockMax;
        private System.Windows.Forms.Label lblVStockMax;
        private System.Windows.Forms.Label lblLEstado;
        private System.Windows.Forms.Label lblVEstado;
        private System.Windows.Forms.Label lblLCantAlertas;
        private System.Windows.Forms.Label lblVCantAlertas;
        private System.Windows.Forms.Panel pnlGraficos;
        private System.Windows.Forms.ComboBox cmbVistaGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlertas;
        private System.Windows.Forms.Button btnVolver;
    }
}