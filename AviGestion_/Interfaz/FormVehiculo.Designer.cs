namespace AviGestion
{
    partial class FormVehiculo
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidadMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAltaModificacion = new System.Windows.Forms.Panel();
            this.lblAltaModificacion = new System.Windows.Forms.Label();
            this.lblRegistrarVehiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblCapacidadMax = new System.Windows.Forms.Label();
            this.nudCapacidadMax = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.pnlAltaModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(910, 65);
            this.pnlEncabezado.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Vehículos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(15, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtBuscar.Size = new System.Drawing.Size(675, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(700, 75);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(195, 30);
            this.btnAgregarVehiculo.TabIndex = 2;
            this.btnAgregarVehiculo.Text = "+ Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoGenerateColumns = false;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvVehiculos.EnableHeadersVisualStyles = false;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMarca,
            this.colModelo,
            this.colPatente,
            this.colCapacidadMax,
            this.colCapacidadActual,
            this.colEstado,
            this.colEditar,
            this.colBaja});
            this.dgvVehiculos.Location = new System.Drawing.Point(15, 115);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(880, 190);
            this.dgvVehiculos.TabIndex = 3;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            this.dgvVehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehiculos_CellFormatting);
            // 
            // colMarca
            // 
            this.colMarca.FillWeight = 100F;
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.FillWeight = 100F;
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colPatente
            // 
            this.colPatente.FillWeight = 90F;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            // 
            // colCapacidadMax
            // 
            this.colCapacidadMax.FillWeight = 110F;
            this.colCapacidadMax.HeaderText = "CapacidadMax";
            this.colCapacidadMax.Name = "colCapacidadMax";
            this.colCapacidadMax.ReadOnly = true;
            // 
            // colCapacidadActual
            // 
            this.colCapacidadActual.FillWeight = 110F;
            this.colCapacidadActual.HeaderText = "CapacidadActual";
            this.colCapacidadActual.Name = "colCapacidadActual";
            this.colCapacidadActual.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 80F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.FillWeight = 85F;
            this.colEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEditar.HeaderText = "Acción";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            // 
            // colBaja
            // 
            this.colBaja.FillWeight = 95F;
            this.colBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBaja.HeaderText = "";
            this.colBaja.Name = "colBaja";
            this.colBaja.ReadOnly = true;
            // 
            // pnlAltaModificacion
            // 
            this.pnlAltaModificacion.BackColor = System.Drawing.Color.FromArgb(245, 240, 220);
            this.pnlAltaModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAltaModificacion.Controls.Add(this.lblAltaModificacion);
            this.pnlAltaModificacion.Controls.Add(this.lblRegistrarVehiculo);
            this.pnlAltaModificacion.Controls.Add(this.lblMarca);
            this.pnlAltaModificacion.Controls.Add(this.cmbMarca);
            this.pnlAltaModificacion.Controls.Add(this.lblModelo);
            this.pnlAltaModificacion.Controls.Add(this.txtModelo);
            this.pnlAltaModificacion.Controls.Add(this.lblPatente);
            this.pnlAltaModificacion.Controls.Add(this.txtPatente);
            this.pnlAltaModificacion.Controls.Add(this.lblCapacidadMax);
            this.pnlAltaModificacion.Controls.Add(this.nudCapacidadMax);
            this.pnlAltaModificacion.Controls.Add(this.lblEstado);
            this.pnlAltaModificacion.Controls.Add(this.cmbEstado);
            this.pnlAltaModificacion.Controls.Add(this.btnCancelar);
            this.pnlAltaModificacion.Controls.Add(this.btnRegistrarVehiculo);
            this.pnlAltaModificacion.Location = new System.Drawing.Point(15, 315);
            this.pnlAltaModificacion.Name = "pnlAltaModificacion";
            this.pnlAltaModificacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAltaModificacion.Size = new System.Drawing.Size(880, 245);
            this.pnlAltaModificacion.TabIndex = 4;
            // 
            // lblAltaModificacion
            // 
            this.lblAltaModificacion.AutoSize = true;
            this.lblAltaModificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAltaModificacion.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblAltaModificacion.Location = new System.Drawing.Point(10, 15);
            this.lblAltaModificacion.Name = "lblAltaModificacion";
            this.lblAltaModificacion.Size = new System.Drawing.Size(99, 15);
            this.lblAltaModificacion.TabIndex = 0;
            this.lblAltaModificacion.Text = "Alta de Vehículo";
            // 
            // lblRegistrarVehiculo
            // 
            this.lblRegistrarVehiculo.AutoSize = true;
            this.lblRegistrarVehiculo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarVehiculo.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.lblRegistrarVehiculo.Location = new System.Drawing.Point(10, 32);
            this.lblRegistrarVehiculo.Name = "lblRegistrarVehiculo";
            this.lblRegistrarVehiculo.Size = new System.Drawing.Size(250, 25);
            this.lblRegistrarVehiculo.TabIndex = 1;
            this.lblRegistrarVehiculo.Text = "Registrar Nuevo Vehículo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(20, 80);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "MARCA";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Items.AddRange(new object[] {
            "Mercedes-Benz",
            "Toyota",
            "Ford",
            "Iveco",
            "Volkswagen"});
            this.cmbMarca.Location = new System.Drawing.Point(20, 98);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(250, 21);
            this.cmbMarca.TabIndex = 0;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelo.Location = new System.Drawing.Point(300, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 15);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "MODELO";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(300, 98);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(250, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPatente.Location = new System.Drawing.Point(580, 80);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(61, 15);
            this.lblPatente.TabIndex = 4;
            this.lblPatente.Text = "PATENTE";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(580, 98);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(250, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // lblCapacidadMax
            // 
            this.lblCapacidadMax.AutoSize = true;
            this.lblCapacidadMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCapacidadMax.Location = new System.Drawing.Point(20, 135);
            this.lblCapacidadMax.Name = "lblCapacidadMax";
            this.lblCapacidadMax.Size = new System.Drawing.Size(127, 15);
            this.lblCapacidadMax.TabIndex = 5;
            this.lblCapacidadMax.Text = "CAPACIDAD MAX (Kg)";
            // 
            // nudCapacidadMax
            // 
            this.nudCapacidadMax.Location = new System.Drawing.Point(20, 153);
            this.nudCapacidadMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCapacidadMax.Name = "nudCapacidadMax";
            this.nudCapacidadMax.Size = new System.Drawing.Size(250, 20);
            this.nudCapacidadMax.TabIndex = 3;
            this.nudCapacidadMax.ThousandsSeparator = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(300, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 15);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "ESTADO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(300, 153);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(250, 21);
            this.cmbEstado.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(580, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnRegistrarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(700, 195);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(150, 32);
            this.btnRegistrarVehiculo.TabIndex = 6;
            this.btnRegistrarVehiculo.Text = "Registrar Vehículo";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = false;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // FormVehiculo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            this.ClientSize = new System.Drawing.Size(910, 575);
            this.Controls.Add(this.pnlAltaModificacion);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema AviGestión";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.pnlAltaModificacion.ResumeLayout(false);
            this.pnlAltaModificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidadMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colBaja;
        private System.Windows.Forms.Panel pnlAltaModificacion;
        private System.Windows.Forms.Label lblAltaModificacion;
        private System.Windows.Forms.Label lblRegistrarVehiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblCapacidadMax;
        private System.Windows.Forms.NumericUpDown nudCapacidadMax;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
    }
}