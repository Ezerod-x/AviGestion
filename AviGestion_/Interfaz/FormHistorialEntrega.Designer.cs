namespace AviGestion_.Interfaz
{
    partial class FormHistorialEntrega
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblResumenHistorial = new System.Windows.Forms.Label();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleEntrega = new System.Windows.Forms.DataGridView();
            this.btnVerComprobante = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDesdeH = new System.Windows.Forms.Label();
            this.lblHastaH = new System.Windows.Forms.Label();
            this.picLupa = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(56, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(311, 23);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(555, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(326, 21);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.ColumnHeadersHeight = 26;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Location = new System.Drawing.Point(40, 50);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(824, 250);
            this.dgvHistorial.TabIndex = 3;
            this.dgvHistorial.SelectionChanged += new System.EventHandler(this.dgvHistorial_SelectionChanged);
            // 
            // lblResumenHistorial
            // 
            this.lblResumenHistorial.AutoSize = true;
            this.lblResumenHistorial.Location = new System.Drawing.Point(40, 303);
            this.lblResumenHistorial.Name = "lblResumenHistorial";
            this.lblResumenHistorial.Size = new System.Drawing.Size(35, 13);
            this.lblResumenHistorial.TabIndex = 4;
            this.lblResumenHistorial.Text = "label1";
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Location = new System.Drawing.Point(43, 337);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblDetalleTitulo.TabIndex = 5;
            this.lblDetalleTitulo.Text = "label1";
            // 
            // dgvDetalleEntrega
            // 
            this.dgvDetalleEntrega.AllowUserToAddRows = false;
            this.dgvDetalleEntrega.AllowUserToDeleteRows = false;
            this.dgvDetalleEntrega.AllowUserToResizeRows = false;
            this.dgvDetalleEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleEntrega.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleEntrega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleEntrega.EnableHeadersVisualStyles = false;
            this.dgvDetalleEntrega.Location = new System.Drawing.Point(43, 354);
            this.dgvDetalleEntrega.MultiSelect = false;
            this.dgvDetalleEntrega.Name = "dgvDetalleEntrega";
            this.dgvDetalleEntrega.ReadOnly = true;
            this.dgvDetalleEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleEntrega.Size = new System.Drawing.Size(821, 150);
            this.dgvDetalleEntrega.TabIndex = 6;
            // 
            // btnVerComprobante
            // 
            this.btnVerComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnVerComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerComprobante.ForeColor = System.Drawing.Color.White;
            this.btnVerComprobante.Location = new System.Drawing.Point(735, 303);
            this.btnVerComprobante.Name = "btnVerComprobante";
            this.btnVerComprobante.Size = new System.Drawing.Size(129, 42);
            this.btnVerComprobante.TabIndex = 7;
            this.btnVerComprobante.Text = "Ver Comprobante";
            this.btnVerComprobante.UseVisualStyleBackColor = false;
            this.btnVerComprobante.Click += new System.EventHandler(this.btnVerComprobante_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(776, 510);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 38);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDesdeH
            // 
            this.lblDesdeH.AutoSize = true;
            this.lblDesdeH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesdeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesdeH.Location = new System.Drawing.Point(12, 29);
            this.lblDesdeH.Name = "lblDesdeH";
            this.lblDesdeH.Size = new System.Drawing.Size(42, 15);
            this.lblDesdeH.TabIndex = 9;
            this.lblDesdeH.Text = "Desde:";
            // 
            // lblHastaH
            // 
            this.lblHastaH.AutoSize = true;
            this.lblHastaH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHastaH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHastaH.Location = new System.Drawing.Point(265, 28);
            this.lblHastaH.Name = "lblHastaH";
            this.lblHastaH.Size = new System.Drawing.Size(40, 15);
            this.lblHastaH.TabIndex = 10;
            this.lblHastaH.Text = "Hasta:";
            // 
            // picLupa
            // 
            this.picLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLupa.AutoSize = true;
            this.picLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLupa.ForeColor = System.Drawing.Color.DarkGreen;
            this.picLupa.Location = new System.Drawing.Point(527, 24);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(36, 24);
            this.picLupa.TabIndex = 11;
            this.picLupa.Text = "🔍 ";
            // 
            // lblFiltros
            // 
            this.lblFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblFiltros.Location = new System.Drawing.Point(537, 5);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(361, 15);
            this.lblFiltros.TabIndex = 12;
            this.lblFiltros.Text = "Filtra por patente, vehículo o responsable y actualiza el resumen";
            // 
            // FormHistorialEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(902, 560);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.lblHastaH);
            this.Controls.Add(this.lblDesdeH);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerComprobante);
            this.Controls.Add(this.dgvDetalleEntrega);
            this.Controls.Add(this.lblDetalleTitulo);
            this.Controls.Add(this.lblResumenHistorial);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorialEntrega";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHistorialEntrega";
            this.Load += new System.EventHandler(this.FormHistorialEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblResumenHistorial;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.DataGridView dgvDetalleEntrega;
        private System.Windows.Forms.Button btnVerComprobante;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblDesdeH;
        private System.Windows.Forms.Label lblHastaH;
        private System.Windows.Forms.Label picLupa;
        private System.Windows.Forms.Label lblFiltros;
    }
}