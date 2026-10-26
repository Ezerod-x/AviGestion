namespace AviGestion_.UI
{
    partial class FormBitacora
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
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblDesdeB = new System.Windows.Forms.Label();
            this.lblHastaB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtBuscarUsuario
            //
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscarUsuario.Location = new System.Drawing.Point(15, 30);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscarUsuario.Size = new System.Drawing.Size(290, 25);
            this.txtBuscarUsuario.TabIndex = 1;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // cmbAccion
            //
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.Items.AddRange(new object[] {
            "Todas",
            "Inicio de Sesión",
            "Cierre de Sesión",
            "Acceso Fallido",
            "Alta",
            "Baja",
            "Modificación",
            "Cambio de Permisos",
            "Backup",
            "Bloqueo por Integridad"});
            this.cmbAccion.Location = new System.Drawing.Point(315, 30);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(170, 23);
            this.cmbAccion.TabIndex = 2;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // cmbModulo
            //
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.Items.AddRange(new object[] {
            "Todos",
            "Usuarios",
            "Productos",
            "Stock",
            "Alertas",
            "Clientes",
            "Pedidos",
            "Backup",
            "Seguridad"});
            this.cmbModulo.Location = new System.Drawing.Point(495, 30);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(150, 23);
            this.cmbModulo.TabIndex = 3;
            this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // chkFiltrarFecha
            //
            this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFiltrarFecha.Location = new System.Drawing.Point(15, 69);
            this.chkFiltrarFecha.Name = "chkFiltrarFecha";
            this.chkFiltrarFecha.Text = "Filtrar por fecha";
            this.chkFiltrarFecha.UseVisualStyleBackColor = true;
            this.chkFiltrarFecha.CheckedChanged += new System.EventHandler(this.chkFiltrarFecha_CheckedChanged);
            //
            // dtpDesde
            //
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(185, 67);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 20);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // dtpHasta
            //
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(365, 67);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.Filtro_Changed);
            //
            // btnLimpiarFiltros
            //
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(705, 65);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(160, 27);
            this.btnLimpiarFiltros.TabIndex = 6;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            //
            // dgvBitacora
            //
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AutoGenerateColumns = false;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colUsuario,
            this.colAccion,
            this.colModulo,
            this.colDetalle});
            this.dgvBitacora.Location = new System.Drawing.Point(15, 102);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(850, 388);
            this.dgvBitacora.TabIndex = 7;
            //
            // colFecha
            //
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.HeaderText = "Fecha y Hora";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 130;
            //
            // colUsuario
            //
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 150;
            //
            // colAccion
            //
            this.colAccion.DataPropertyName = "Accion";
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Width = 140;
            //
            // colModulo
            //
            this.colModulo.DataPropertyName = "Modulo";
            this.colModulo.HeaderText = "Módulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.ReadOnly = true;
            this.colModulo.Width = 110;
            //
            // colDetalle
            //
            this.colDetalle.DataPropertyName = "Detalle";
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            this.colDetalle.Width = 320;
            //
            // FormBitacora
            //
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblFiltros.Location = new System.Drawing.Point(15, 8);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Text = "Aplicar filtros de búsqueda: escribí texto, elegí acción y módulo, o filtrá por fecha";
            this.Controls.Add(this.lblFiltros);
            // 
            // lblDesdeB
            // 
            this.lblDesdeB.AutoSize = true;
            this.lblDesdeB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblDesdeB.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.lblDesdeB.Location = new System.Drawing.Point(140, 71);
            this.lblDesdeB.Name = "lblDesdeB";
            this.lblDesdeB.Text = "Desde:";
            this.Controls.Add(this.lblDesdeB);
            // 
            // lblHastaB
            // 
            this.lblHastaB.AutoSize = true;
            this.lblHastaB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblHastaB.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.lblHastaB.Location = new System.Drawing.Point(320, 71);
            this.lblHastaB.Name = "lblHastaB";
            this.lblHastaB.Text = "Hasta:";
            this.Controls.Add(this.lblHastaB);
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.chkFiltrarFecha);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.txtBuscarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormBitacora";
            this.Text = "Sistema AviGestión";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblDesdeB;
        private System.Windows.Forms.Label lblHastaB;
    }
}