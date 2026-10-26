namespace AviGestion_.UI
{
    partial class FormCargaStock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizarInventario = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIngreso = new System.Windows.Forms.Panel();
            this.lblTituloIngreso = new System.Windows.Forms.Label();
            this.lblProductoSel = new System.Windows.Forms.Label();
            this.txtProductoSeleccionado = new System.Windows.Forms.TextBox();
            this.lblStockActualTxt = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblNuevoStock = new System.Windows.Forms.Label();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.lblValidacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            //
            // txtBuscar
            //
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(15, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtBuscar.Size = new System.Drawing.Size(675, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            //
            // btnActualizarInventario
            //
            this.btnActualizarInventario.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnActualizarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInventario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizarInventario.ForeColor = System.Drawing.Color.White;
            this.btnActualizarInventario.Location = new System.Drawing.Point(705, 10);
            this.btnActualizarInventario.Name = "btnActualizarInventario";
            this.btnActualizarInventario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizarInventario.Size = new System.Drawing.Size(160, 30);
            this.btnActualizarInventario.TabIndex = 2;
            this.btnActualizarInventario.Text = "↻ Actualizar Inventario";
            this.btnActualizarInventario.UseVisualStyleBackColor = false;
            this.btnActualizarInventario.Click += new System.EventHandler(this.btnActualizarInventario_Click);
            //
            // dgvStock
            //
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCategoria,
            this.colStockActual,
            this.colStockMin,
            this.colStockMax,
            this.colEstadoStock});
            this.dgvStock.Location = new System.Drawing.Point(15, 50);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(850, 215);
            this.dgvStock.TabIndex = 3;
            this.dgvStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellDoubleClick);
            this.dgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStock_CellFormatting);
            //
            // colCodigo
            //
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 75;
            //
            // colProducto
            //
            this.colProducto.DataPropertyName = "Descripcion";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 180;
            //
            // colCategoria
            //
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 90;
            //
            // colStockActual
            //
            this.colStockActual.DataPropertyName = "Stock";
            this.colStockActual.HeaderText = "Stock Actual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            this.colStockActual.Width = 90;
            //
            // colStockMin
            //
            this.colStockMin.DataPropertyName = "StockMinimo";
            this.colStockMin.HeaderText = "Stock Mín.";
            this.colStockMin.Name = "colStockMin";
            this.colStockMin.ReadOnly = true;
            this.colStockMin.Width = 85;
            //
            // colStockMax
            //
            this.colStockMax.DataPropertyName = "StockMaximo";
            this.colStockMax.HeaderText = "Stock Máx.";
            this.colStockMax.Name = "colStockMax";
            this.colStockMax.ReadOnly = true;
            this.colStockMax.Width = 85;
            //
            // colEstadoStock
            //
            this.colEstadoStock.DataPropertyName = "EstadoStock";
            this.colEstadoStock.HeaderText = "Estado";
            this.colEstadoStock.Name = "colEstadoStock";
            this.colEstadoStock.ReadOnly = true;
            this.colEstadoStock.Width = 110;
            //
            // pnlIngreso
            //
            this.pnlIngreso.BackColor = System.Drawing.Color.FromArgb(245, 240, 220);
            this.pnlIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIngreso.Controls.Add(this.lblTituloIngreso);
            this.pnlIngreso.Controls.Add(this.lblProductoSel);
            this.pnlIngreso.Controls.Add(this.txtProductoSeleccionado);
            this.pnlIngreso.Controls.Add(this.lblStockActualTxt);
            this.pnlIngreso.Controls.Add(this.txtStockActual);
            this.pnlIngreso.Controls.Add(this.lblCantidad);
            this.pnlIngreso.Controls.Add(this.nudCantidad);
            this.pnlIngreso.Controls.Add(this.lblNuevoStock);
            this.pnlIngreso.Controls.Add(this.txtNuevoStock);
            this.pnlIngreso.Controls.Add(this.lblValidacion);
            this.pnlIngreso.Controls.Add(this.btnCancelar);
            this.pnlIngreso.Controls.Add(this.btnRegistrarIngreso);
            this.pnlIngreso.Location = new System.Drawing.Point(15, 275);
            this.pnlIngreso.Name = "pnlIngreso";
            this.pnlIngreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlIngreso.Size = new System.Drawing.Size(850, 215);
            this.pnlIngreso.TabIndex = 4;
            //
            // lblTituloIngreso
            //
            this.lblTituloIngreso.AutoSize = true;
            this.lblTituloIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloIngreso.Location = new System.Drawing.Point(15, 12);
            this.lblTituloIngreso.Name = "lblTituloIngreso";
            this.lblTituloIngreso.Text = "Registrar Ingreso de Stock";
            //
            // lblProductoSel
            //
            this.lblProductoSel.AutoSize = true;
            this.lblProductoSel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoSel.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblProductoSel.Location = new System.Drawing.Point(20, 42);
            this.lblProductoSel.Name = "lblProductoSel";
            this.lblProductoSel.Text = "PRODUCTO SELECCIONADO";
            //
            // txtProductoSeleccionado
            //
            this.txtProductoSeleccionado.Location = new System.Drawing.Point(20, 60);
            this.txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            this.txtProductoSeleccionado.ReadOnly = true;
            this.txtProductoSeleccionado.Size = new System.Drawing.Size(400, 20);
            this.txtProductoSeleccionado.TabIndex = 0;
            //
            // lblStockActualTxt
            //
            this.lblStockActualTxt.AutoSize = true;
            this.lblStockActualTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockActualTxt.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblStockActualTxt.Location = new System.Drawing.Point(450, 42);
            this.lblStockActualTxt.Name = "lblStockActualTxt";
            this.lblStockActualTxt.Text = "STOCK ACTUAL";
            //
            // txtStockActual
            //
            this.txtStockActual.Location = new System.Drawing.Point(450, 60);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(380, 20);
            this.txtStockActual.TabIndex = 1;
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblCantidad.Location = new System.Drawing.Point(20, 95);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Text = "CANTIDAD A INGRESAR";
            //
            // nudCantidad
            //
            this.nudCantidad.Location = new System.Drawing.Point(20, 113);
            this.nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(400, 20);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            //
            // lblNuevoStock
            //
            this.lblNuevoStock.AutoSize = true;
            this.lblNuevoStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNuevoStock.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblNuevoStock.Location = new System.Drawing.Point(450, 95);
            this.lblNuevoStock.Name = "lblNuevoStock";
            this.lblNuevoStock.Text = "NUEVO STOCK RESULTANTE";
            //
            // txtNuevoStock
            //
            this.txtNuevoStock.Location = new System.Drawing.Point(450, 113);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.ReadOnly = true;
            this.txtNuevoStock.Size = new System.Drawing.Size(380, 20);
            this.txtNuevoStock.TabIndex = 3;
            //
            // lblValidacion
            //
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValidacion.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblValidacion.Location = new System.Drawing.Point(20, 148);
            this.lblValidacion.Name = "lblValidacion";
            //
            // btnCancelar
            //
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(560, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnRegistrarIngreso
            //
            this.btnRegistrarIngreso.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnRegistrarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngreso.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(690, 170);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(140, 32);
            this.btnRegistrarIngreso.TabIndex = 6;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = false;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            //
            // FormCargaStock
            //
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.pnlIngreso);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnActualizarInventario);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormCargaStock";
            this.Text = "Sistema AviGestión";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlIngreso.ResumeLayout(false);
            this.pnlIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizarInventario;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoStock;
        private System.Windows.Forms.Panel pnlIngreso;
        private System.Windows.Forms.Label lblTituloIngreso;
        private System.Windows.Forms.Label lblProductoSel;
        private System.Windows.Forms.TextBox txtProductoSeleccionado;
        private System.Windows.Forms.Label lblStockActualTxt;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblNuevoStock;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarIngreso;
    }
}