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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtpDesde.Location = new System.Drawing.Point(75, 30);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(415, 28);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(740, 31);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(433, 24);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.ColumnHeadersHeight = 26;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Location = new System.Drawing.Point(53, 62);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1099, 308);
            this.dgvHistorial.TabIndex = 3;
            this.dgvHistorial.SelectionChanged += new System.EventHandler(this.dgvHistorial_SelectionChanged);
            // 
            // lblResumenHistorial
            // 
            this.lblResumenHistorial.AutoSize = true;
            this.lblResumenHistorial.Location = new System.Drawing.Point(53, 373);
            this.lblResumenHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumenHistorial.Name = "lblResumenHistorial";
            this.lblResumenHistorial.Size = new System.Drawing.Size(44, 16);
            this.lblResumenHistorial.TabIndex = 4;
            this.lblResumenHistorial.Text = "label1";
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Location = new System.Drawing.Point(57, 415);
            this.lblDetalleTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(44, 16);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleEntrega.ColumnHeadersHeight = 29;
            this.dgvDetalleEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleEntrega.EnableHeadersVisualStyles = false;
            this.dgvDetalleEntrega.Location = new System.Drawing.Point(57, 436);
            this.dgvDetalleEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetalleEntrega.MultiSelect = false;
            this.dgvDetalleEntrega.Name = "dgvDetalleEntrega";
            this.dgvDetalleEntrega.ReadOnly = true;
            this.dgvDetalleEntrega.RowHeadersWidth = 51;
            this.dgvDetalleEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleEntrega.Size = new System.Drawing.Size(1095, 185);
            this.dgvDetalleEntrega.TabIndex = 6;
            // 
            // btnVerComprobante
            // 
            this.btnVerComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnVerComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerComprobante.ForeColor = System.Drawing.Color.White;
            this.btnVerComprobante.Location = new System.Drawing.Point(980, 373);
            this.btnVerComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerComprobante.Name = "btnVerComprobante";
            this.btnVerComprobante.Size = new System.Drawing.Size(172, 52);
            this.btnVerComprobante.TabIndex = 7;
            this.btnVerComprobante.Text = "Ver Comprobante";
            this.btnVerComprobante.UseVisualStyleBackColor = false;
            this.btnVerComprobante.Click += new System.EventHandler(this.btnVerComprobante_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1035, 628);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(117, 47);
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
            this.lblDesdeH.Location = new System.Drawing.Point(16, 36);
            this.lblDesdeH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesdeH.Name = "lblDesdeH";
            this.lblDesdeH.Size = new System.Drawing.Size(54, 20);
            this.lblDesdeH.TabIndex = 9;
            this.lblDesdeH.Text = "Desde:";
            // 
            // lblHastaH
            // 
            this.lblHastaH.AutoSize = true;
            this.lblHastaH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHastaH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHastaH.Location = new System.Drawing.Point(353, 34);
            this.lblHastaH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaH.Name = "lblHastaH";
            this.lblHastaH.Size = new System.Drawing.Size(50, 20);
            this.lblHastaH.TabIndex = 10;
            this.lblHastaH.Text = "Hasta:";
            // 
            // picLupa
            // 
            this.picLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLupa.AutoSize = true;
            this.picLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLupa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.picLupa.Location = new System.Drawing.Point(703, 30);
            this.picLupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(45, 29);
            this.picLupa.TabIndex = 11;
            this.picLupa.Text = "🔍 ";
            // 
            // lblFiltros
            // 
            this.lblFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblFiltros.Location = new System.Drawing.Point(716, 6);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(456, 20);
            this.lblFiltros.TabIndex = 12;
            this.lblFiltros.Text = "Filtra por patente, vehículo o responsable y actualiza el resumen";
            // 
            // FormHistorialEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1203, 689);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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