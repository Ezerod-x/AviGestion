namespace AviGestion_.Interfaz
{
    partial class FormControlEntregas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.picLupa = new System.Windows.Forms.Label();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.grbEntrega = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblTituloEntrega = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEntrega = new System.Windows.Forms.Button();
            this.lblEtiquetaAdjuntar = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.dgvPedidosCamion = new System.Windows.Forms.DataGridView();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.grbEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(57, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 21);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // picLupa
            // 
            this.picLupa.AutoSize = true;
            this.picLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLupa.ForeColor = System.Drawing.Color.DarkGreen;
            this.picLupa.Location = new System.Drawing.Point(15, 8);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(36, 24);
            this.picLupa.TabIndex = 1;
            this.picLupa.Text = "🔍 ";
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.AllowUserToAddRows = false;
            this.dgvCamiones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCamiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCamiones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCamiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCamiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvCamiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCamiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCamiones.ColumnHeadersHeight = 26;
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCamiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCamiones.EnableHeadersVisualStyles = false;
            this.dgvCamiones.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCamiones.Location = new System.Drawing.Point(12, 40);
            this.dgvCamiones.MultiSelect = false;
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.ReadOnly = true;
            this.dgvCamiones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvCamiones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCamiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamiones.Size = new System.Drawing.Size(760, 244);
            this.dgvCamiones.TabIndex = 2;
            this.dgvCamiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamiones_CellDoubleClick);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAyuda.Location = new System.Drawing.Point(12, 286);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(508, 13);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Doble clic en un camión para ver sus pedidos. Destilda los que no se entregaron y" +
    " adjuntá el comprobante\r\n";
            // 
            // grbEntrega
            // 
            this.grbEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEntrega.Controls.Add(this.lblMensaje);
            this.grbEntrega.Controls.Add(this.lblResumen);
            this.grbEntrega.Controls.Add(this.lblTituloEntrega);
            this.grbEntrega.Controls.Add(this.btnCancelar);
            this.grbEntrega.Controls.Add(this.btnConfirmarEntrega);
            this.grbEntrega.Controls.Add(this.lblEtiquetaAdjuntar);
            this.grbEntrega.Controls.Add(this.lblResponsable);
            this.grbEntrega.Controls.Add(this.cboResponsable);
            this.grbEntrega.Controls.Add(this.lblArchivo);
            this.grbEntrega.Controls.Add(this.btnAdjuntar);
            this.grbEntrega.Controls.Add(this.dgvPedidosCamion);
            this.grbEntrega.Location = new System.Drawing.Point(0, 311);
            this.grbEntrega.Name = "grbEntrega";
            this.grbEntrega.Size = new System.Drawing.Size(784, 250);
            this.grbEntrega.TabIndex = 4;
            this.grbEntrega.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(441, 150);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 34;
            this.lblMensaje.Text = "label1";
            // 
            // lblResumen
            // 
            this.lblResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResumen.Location = new System.Drawing.Point(15, 186);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(35, 13);
            this.lblResumen.TabIndex = 33;
            this.lblResumen.Text = "label1";
            // 
            // lblTituloEntrega
            // 
            this.lblTituloEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTituloEntrega.AutoSize = true;
            this.lblTituloEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTituloEntrega.Location = new System.Drawing.Point(12, 11);
            this.lblTituloEntrega.Name = "lblTituloEntrega";
            this.lblTituloEntrega.Size = new System.Drawing.Size(47, 15);
            this.lblTituloEntrega.TabIndex = 32;
            this.lblTituloEntrega.Text = "label1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Location = new System.Drawing.Point(444, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 37);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnConfirmarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEntrega.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEntrega.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(576, 207);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(175, 37);
            this.btnConfirmarEntrega.TabIndex = 31;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = false;
            this.btnConfirmarEntrega.Click += new System.EventHandler(this.btnConfirmarEntrega_Click);
            // 
            // lblEtiquetaAdjuntar
            // 
            this.lblEtiquetaAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtiquetaAdjuntar.AutoSize = true;
            this.lblEtiquetaAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaAdjuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEtiquetaAdjuntar.Location = new System.Drawing.Point(432, 32);
            this.lblEtiquetaAdjuntar.Name = "lblEtiquetaAdjuntar";
            this.lblEtiquetaAdjuntar.Size = new System.Drawing.Size(202, 15);
            this.lblEtiquetaAdjuntar.TabIndex = 29;
            this.lblEtiquetaAdjuntar.Text = "COMPROBANTE DE ENTREGA";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblResponsable.Location = new System.Drawing.Point(432, 108);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(349, 15);
            this.lblResponsable.TabIndex = 28;
            this.lblResponsable.Text = "RESPONSABLE DE LA ENTREGA (usuario registrado)";
            // 
            // cboResponsable
            // 
            this.cboResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(435, 126);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(337, 21);
            this.cboResponsable.TabIndex = 27;
            this.cboResponsable.SelectedIndexChanged += new System.EventHandler(this.cboResponsable_SelectedIndexChanged);
            // 
            // lblArchivo
            // 
            this.lblArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(573, 70);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(35, 13);
            this.lblArchivo.TabIndex = 26;
            this.lblArchivo.Text = "label1";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjuntar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAdjuntar.FlatAppearance.BorderSize = 2;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAdjuntar.Location = new System.Drawing.Point(435, 50);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(132, 33);
            this.btnAdjuntar.TabIndex = 25;
            this.btnAdjuntar.Text = "Adjuntar Imagen ...";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // dgvPedidosCamion
            // 
            this.dgvPedidosCamion.AllowUserToAddRows = false;
            this.dgvPedidosCamion.AllowUserToDeleteRows = false;
            this.dgvPedidosCamion.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPedidosCamion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidosCamion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosCamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosCamion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosCamion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedidosCamion.ColumnHeadersHeight = 26;
            this.dgvPedidosCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidosCamion.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidosCamion.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPedidosCamion.EnableHeadersVisualStyles = false;
            this.dgvPedidosCamion.GridColor = System.Drawing.Color.White;
            this.dgvPedidosCamion.Location = new System.Drawing.Point(12, 32);
            this.dgvPedidosCamion.MultiSelect = false;
            this.dgvPedidosCamion.Name = "dgvPedidosCamion";
            this.dgvPedidosCamion.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvPedidosCamion.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPedidosCamion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosCamion.Size = new System.Drawing.Size(417, 150);
            this.dgvPedidosCamion.TabIndex = 24;
            this.dgvPedidosCamion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosCamion_CellValueChanged);
            this.dgvPedidosCamion.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPedidosCamion_CurrentCellDirtyStateChanged);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorial.ForeColor = System.Drawing.Color.White;
            this.btnVerHistorial.Location = new System.Drawing.Point(614, 5);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(158, 29);
            this.btnVerHistorial.TabIndex = 5;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = false;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // FormControlEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.grbEntrega);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvCamiones);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.txtBuscar);
            this.Name = "FormControlEntregas";
            this.Text = "Control Entregas de Pedidos";
            this.Load += new System.EventHandler(this.FormControlEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.grbEntrega.ResumeLayout(false);
            this.grbEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCamion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label picLupa;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.GroupBox grbEntrega;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblTituloEntrega;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.Label lblEtiquetaAdjuntar;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.DataGridView dgvPedidosCamion;
        private System.Windows.Forms.Button btnVerHistorial;
    }
}