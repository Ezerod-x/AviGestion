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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtras = new System.Windows.Forms.Button();
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
            this.btnHistorial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbRegistrarModificar = new System.Windows.Forms.GroupBox();
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
            this.pnlEncabezado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaFiltrado = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).BeginInit();
            this.grbRegistrarModificar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAtras.FlatAppearance.BorderSize = 2;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAtras.Location = new System.Drawing.Point(14, 472);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(83, 36);
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 96);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTablaClientes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbRegistrarModificar);
            this.splitContainer1.Size = new System.Drawing.Size(876, 370);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 16;
            // 
            // dgvTablaClientes
            // 
            this.dgvTablaClientes.AllowUserToAddRows = false;
            this.dgvTablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaClientes.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvTablaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colEmpresa,
            this.colTelefono,
            this.colCorreo,
            this.colDniCuil,
            this.colDireccion,
            this.btnHistorial,
            this.colAccion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaClientes.GridColor = System.Drawing.Color.LimeGreen;
            this.dgvTablaClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaClientes.Name = "dgvTablaClientes";
            this.dgvTablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaClientes.Size = new System.Drawing.Size(874, 95);
            this.dgvTablaClientes.TabIndex = 3;
            this.dgvTablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaClientes_CellContentClick);
            this.dgvTablaClientes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTablaClientes_CellMouseUp);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 85.88832F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FillWeight = 85.88832F;
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 85.88832F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 85.88832F;
            this.colCorreo.HeaderText = "Correo electronico";
            this.colCorreo.Name = "colCorreo";
            // 
            // colDniCuil
            // 
            this.colDniCuil.FillWeight = 85.88832F;
            this.colDniCuil.HeaderText = "DNI/CUIL";
            this.colDniCuil.Name = "colDniCuil";
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // btnHistorial
            // 
            this.btnHistorial.HeaderText = "Historial";
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Text = "Ver";
            this.btnHistorial.UseColumnTextForButtonValue = true;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.Text = "Modificar";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // grbRegistrarModificar
            // 
            this.grbRegistrarModificar.AutoSize = true;
            this.grbRegistrarModificar.BackColor = System.Drawing.Color.White;
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
            this.grbRegistrarModificar.Name = "grbRegistrarModificar";
            this.grbRegistrarModificar.Size = new System.Drawing.Size(874, 267);
            this.grbRegistrarModificar.TabIndex = 4;
            this.grbRegistrarModificar.TabStop = false;
            this.grbRegistrarModificar.Text = "Modificacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Location = new System.Drawing.Point(613, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(726, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(462, 178);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(346, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtDniCuil
            // 
            this.txtDniCuil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCuil.Location = new System.Drawing.Point(462, 123);
            this.txtDniCuil.Name = "txtDniCuil";
            this.txtDniCuil.Size = new System.Drawing.Size(346, 23);
            this.txtDniCuil.TabIndex = 11;
            this.txtDniCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuiones_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(86, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(346, 23);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuiones_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDireccion.Location = new System.Drawing.Point(459, 161);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 14);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.White;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCorreo.Location = new System.Drawing.Point(83, 161);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(161, 14);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "*CORREO ELÉCTRONICO";
            // 
            // lblDniCuil
            // 
            this.lblDniCuil.AutoSize = true;
            this.lblDniCuil.BackColor = System.Drawing.Color.White;
            this.lblDniCuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCuil.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDniCuil.Location = new System.Drawing.Point(459, 106);
            this.lblDniCuil.Name = "lblDniCuil";
            this.lblDniCuil.Size = new System.Drawing.Size(72, 14);
            this.lblDniCuil.TabIndex = 6;
            this.lblDniCuil.Text = "*DNI / CUIL";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTelefono.Location = new System.Drawing.Point(83, 106);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 14);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "*TELÉFONO";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(462, 64);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(346, 23);
            this.txtResponsable.TabIndex = 4;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.BackColor = System.Drawing.Color.White;
            this.lblResponsable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResponsable.Location = new System.Drawing.Point(459, 47);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(220, 14);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "*RESPONSABLE (nombre y apellido)";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNegocio.Location = new System.Drawing.Point(86, 64);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(346, 23);
            this.txtNombreNegocio.TabIndex = 2;
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.BackColor = System.Drawing.Color.White;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNegocio.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNombreNegocio.Location = new System.Drawing.Point(83, 46);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(157, 14);
            this.lblNombreNegocio.TabIndex = 1;
            this.lblNombreNegocio.Text = "*NOMBRE DEL NEGOCIO";
            // 
            // lblRegistrarModificar
            // 
            this.lblRegistrarModificar.BackColor = System.Drawing.Color.White;
            this.lblRegistrarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegistrarModificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarModificar.Location = new System.Drawing.Point(10, 16);
            this.lblRegistrarModificar.Name = "lblRegistrarModificar";
            this.lblRegistrarModificar.Size = new System.Drawing.Size(255, 26);
            this.lblRegistrarModificar.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlEncabezado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEncabezado.ForeColor = System.Drawing.Color.White;
            this.pnlEncabezado.Location = new System.Drawing.Point(-4, -1);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(906, 42);
            this.pnlEncabezado.TabIndex = 20;
            this.pnlEncabezado.Text = "Gestión de Clientes";
            this.pnlEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBusquedaFiltrado);
            this.panel1.Location = new System.Drawing.Point(14, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 47);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "🔍 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaFiltrado
            // 
            this.txtBusquedaFiltrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaFiltrado.Location = new System.Drawing.Point(44, 12);
            this.txtBusquedaFiltrado.Name = "txtBusquedaFiltrado";
            this.txtBusquedaFiltrado.Size = new System.Drawing.Size(668, 20);
            this.txtBusquedaFiltrado.TabIndex = 1;
            this.txtBusquedaFiltrado.TextChanged += new System.EventHandler(this.txtBusquedaFiltrado_TextChanged);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(750, 51);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(138, 35);
            this.btnAgregarCliente.TabIndex = 18;
            this.btnAgregarCliente.Text = "+ Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormClientes";
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaClientes)).EndInit();
            this.grbRegistrarModificar.ResumeLayout(false);
            this.grbRegistrarModificar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTablaClientes;
        private System.Windows.Forms.GroupBox grbRegistrarModificar;
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
        private System.Windows.Forms.Label pnlEncabezado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaFiltrado;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn btnHistorial;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
    }
}