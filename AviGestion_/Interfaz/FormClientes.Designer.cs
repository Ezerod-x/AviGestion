namespace AviGestion_.Interfaz
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaFiltrado = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTablaClientes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.grbRegistrarModificar = new System.Windows.Forms.GroupBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDniCuil = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDniCuil = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.lblRegistrarModificar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).BeginInit();
            this.grbRegistrarModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBusquedaFiltrado);
            this.panel1.Location = new System.Drawing.Point(16, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 58);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "🔍 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaFiltrado
            // 
            this.txtBusquedaFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaFiltrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaFiltrado.Location = new System.Drawing.Point(59, 15);
            this.txtBusquedaFiltrado.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaFiltrado.Name = "txtBusquedaFiltrado";
            this.txtBusquedaFiltrado.Size = new System.Drawing.Size(795, 22);
            this.txtBusquedaFiltrado.TabIndex = 1;
            this.txtBusquedaFiltrado.TextChanged += new System.EventHandler(this.txtBusquedaFiltrado_TextChanged);
            this.txtBusquedaFiltrado.Enter += new System.EventHandler(this.txtBusquedaFiltrado_Enter);
            this.txtBusquedaFiltrado.Leave += new System.EventHandler(this.txtBusquedaFiltrado_Leave);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(935, 2);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(227, 58);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "+ Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(15, 68);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Beige;
            this.splitContainer1.Panel1.Controls.Add(this.dgvTablaClientes);
            this.splitContainer1.Panel1.Controls.Add(this.lblAyuda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbRegistrarModificar);
            this.splitContainer1.Size = new System.Drawing.Size(1147, 550);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 12;
            // 
            // dgvTablaClientes
            // 
            this.dgvTablaClientes.AllowUserToAddRows = false;
            this.dgvTablaClientes.AllowUserToDeleteRows = false;
            this.dgvTablaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvTablaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTablaClientes.ColumnHeadersHeight = 26;
            this.dgvTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colEmpresa,
            this.colTelefono,
            this.colCorreo,
            this.colDniCuil,
            this.colDireccion});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaClientes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTablaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaClientes.EnableHeadersVisualStyles = false;
            this.dgvTablaClientes.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTablaClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTablaClientes.MultiSelect = false;
            this.dgvTablaClientes.Name = "dgvTablaClientes";
            this.dgvTablaClientes.ReadOnly = true;
            this.dgvTablaClientes.RowHeadersVisible = false;
            this.dgvTablaClientes.RowHeadersWidth = 51;
            this.dgvTablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaClientes.Size = new System.Drawing.Size(1147, 243);
            this.dgvTablaClientes.TabIndex = 3;
            this.dgvTablaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaClientes_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colId.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 85.88832F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FillWeight = 85.88832F;
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.MinimumWidth = 6;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 85.88832F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 85.88832F;
            this.colCorreo.HeaderText = "Correo electronico";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // colDniCuil
            // 
            this.colDniCuil.FillWeight = 85.88832F;
            this.colDniCuil.HeaderText = "DNI/CUIL";
            this.colDniCuil.MinimumWidth = 6;
            this.colDniCuil.Name = "colDniCuil";
            this.colDniCuil.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.MinimumWidth = 6;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAyuda.Location = new System.Drawing.Point(0, 243);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(44, 16);
            this.lblAyuda.TabIndex = 4;
            this.lblAyuda.Text = "label2";
            // 
            // grbRegistrarModificar
            // 
            this.grbRegistrarModificar.AutoSize = true;
            this.grbRegistrarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.grbRegistrarModificar.Controls.Add(this.lblEtiqueta);
            this.grbRegistrarModificar.Controls.Add(this.btnVerHistorial);
            this.grbRegistrarModificar.Controls.Add(this.btnCancelar);
            this.grbRegistrarModificar.Controls.Add(this.btnGuardar);
            this.grbRegistrarModificar.Controls.Add(this.txtDireccion);
            this.grbRegistrarModificar.Controls.Add(this.txtDniCuil);
            this.grbRegistrarModificar.Controls.Add(this.txtEmail);
            this.grbRegistrarModificar.Controls.Add(this.txtTelefono);
            this.grbRegistrarModificar.Controls.Add(this.lblDireccion);
            this.grbRegistrarModificar.Controls.Add(this.lblCorreo);
            this.grbRegistrarModificar.Controls.Add(this.lblDniCuil);
            this.grbRegistrarModificar.Controls.Add(this.lblTelefono);
            this.grbRegistrarModificar.Controls.Add(this.txtResponsable);
            this.grbRegistrarModificar.Controls.Add(this.lblResponsable);
            this.grbRegistrarModificar.Controls.Add(this.txtNombreNegocio);
            this.grbRegistrarModificar.Controls.Add(this.lblNombreNegocio);
            this.grbRegistrarModificar.Controls.Add(this.lblRegistrarModificar);
            this.grbRegistrarModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRegistrarModificar.Location = new System.Drawing.Point(0, 0);
            this.grbRegistrarModificar.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistrarModificar.Name = "grbRegistrarModificar";
            this.grbRegistrarModificar.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistrarModificar.Size = new System.Drawing.Size(1147, 286);
            this.grbRegistrarModificar.TabIndex = 4;
            this.grbRegistrarModificar.TabStop = false;
            this.grbRegistrarModificar.Text = "Modificacion";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEtiqueta.Location = new System.Drawing.Point(420, 254);
            this.lblEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(217, 17);
            this.lblEtiqueta.TabIndex = 15;
            this.lblEtiqueta.Text = "Campos con ( * ) son obligatorios";
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorial.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorial.ForeColor = System.Drawing.Color.White;
            this.btnVerHistorial.Location = new System.Drawing.Point(31, 244);
            this.btnVerHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(144, 34);
            this.btnVerHistorial.TabIndex = 10;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = false;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancelar.Location = new System.Drawing.Point(780, 244);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(921, 244);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 34);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(635, 196);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(329, 26);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtDniCuil
            // 
            this.txtDniCuil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDniCuil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCuil.Location = new System.Drawing.Point(635, 129);
            this.txtDniCuil.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniCuil.Name = "txtDniCuil";
            this.txtDniCuil.Size = new System.Drawing.Size(329, 27);
            this.txtDniCuil.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(183, 196);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(183, 130);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(329, 27);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuiones_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Beige;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblDireccion.Location = new System.Drawing.Point(631, 175);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 17);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "*DIRECCIÓN";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Beige;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblCorreo.Location = new System.Drawing.Point(179, 175);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(197, 17);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "*CORREO ELÉCTRONICO";
            // 
            // lblDniCuil
            // 
            this.lblDniCuil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDniCuil.AutoSize = true;
            this.lblDniCuil.BackColor = System.Drawing.Color.Beige;
            this.lblDniCuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblDniCuil.Location = new System.Drawing.Point(631, 108);
            this.lblDniCuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniCuil.Name = "lblDniCuil";
            this.lblDniCuil.Size = new System.Drawing.Size(90, 17);
            this.lblDniCuil.TabIndex = 6;
            this.lblDniCuil.Text = "*DNI / CUIL";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Beige;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblTelefono.Location = new System.Drawing.Point(179, 110);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(97, 17);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "*TELÉFONO";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponsable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(635, 68);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(329, 27);
            this.txtResponsable.TabIndex = 4;
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.BackColor = System.Drawing.Color.Beige;
            this.lblResponsable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblResponsable.Location = new System.Drawing.Point(631, 47);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(273, 17);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "*RESPONSABLE (nombre y apellido)";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreNegocio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNegocio.Location = new System.Drawing.Point(183, 69);
            this.txtNombreNegocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(329, 27);
            this.txtNombreNegocio.TabIndex = 2;
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.BackColor = System.Drawing.Color.Beige;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblNombreNegocio.Location = new System.Drawing.Point(179, 48);
            this.lblNombreNegocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(193, 17);
            this.lblNombreNegocio.TabIndex = 1;
            this.lblNombreNegocio.Text = "*NOMBRE DEL NEGOCIO";
            // 
            // lblRegistrarModificar
            // 
            this.lblRegistrarModificar.BackColor = System.Drawing.Color.Beige;
            this.lblRegistrarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegistrarModificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarModificar.Location = new System.Drawing.Point(13, 20);
            this.lblRegistrarModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarModificar.Name = "lblRegistrarModificar";
            this.lblRegistrarModificar.Size = new System.Drawing.Size(340, 32);
            this.lblRegistrarModificar.TabIndex = 0;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).EndInit();
            this.grbRegistrarModificar.ResumeLayout(false);
            this.grbRegistrarModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaFiltrado;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTablaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.GroupBox grbRegistrarModificar;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDniCuil;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDniCuil;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.Label lblRegistrarModificar;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label lblAyuda;
    }
}