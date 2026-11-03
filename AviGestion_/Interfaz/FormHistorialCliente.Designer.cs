namespace AviGestion_.Interfaz
{
    partial class FormHistorialCliente
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblUltimaCompraValor = new System.Windows.Forms.Label();
            this.lblUltimaCompra = new System.Windows.Forms.Label();
            this.lblMontoMaximoValor = new System.Windows.Forms.Label();
            this.lblMontoMaximo = new System.Windows.Forms.Label();
            this.lblMontoMinimoValor = new System.Windows.Forms.Label();
            this.lblMontoMinimo = new System.Windows.Forms.Label();
            this.lblAntiguedadValor = new System.Windows.Forms.Label();
            this.lblAntiguedadEtiqueta = new System.Windows.Forms.Label();
            this.lblPorcentajeValor = new System.Windows.Forms.Label();
            this.lblPorcentajeEtiqueta = new System.Windows.Forms.Label();
            this.lblPromedioValor = new System.Windows.Forms.Label();
            this.lblPromedioEtiqueta = new System.Windows.Forms.Label();
            this.lblResumenFinancieroEtiqueta = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaldoPendienteValor = new System.Windows.Forms.Label();
            this.lblSaldoPendienteEtiqueta = new System.Windows.Forms.Label();
            this.lblTotalPagadoValor = new System.Windows.Forms.Label();
            this.lblTotalCompradoValor = new System.Windows.Forms.Label();
            this.lblTotalPagadoEtiqueta = new System.Windows.Forms.Label();
            this.lblTotalCompradoEtiqueta = new System.Windows.Forms.Label();
            this.pnlInfoCliente = new System.Windows.Forms.Panel();
            this.lblDireccionValor = new System.Windows.Forms.Label();
            this.lblDireccionEtiqueta = new System.Windows.Forms.Label();
            this.lblContactoValor = new System.Windows.Forms.Label();
            this.lblContactoEtiqueta = new System.Windows.Forms.Label();
            this.lblClienteValor = new System.Windows.Forms.Label();
            this.lblClienteEtiqueta = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlInfoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Controls.Add(this.txtBusqueda);
            this.pnlFiltros.Location = new System.Drawing.Point(7, 113);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1209, 34);
            this.pnlFiltros.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnLimpiar.Location = new System.Drawing.Point(1024, -1);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(173, 32);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseMnemonic = false;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(16, 5);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(981, 22);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.Text = "Filtrar por N°Pedido, Fecha...";
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumen.Controls.Add(this.lblUltimaCompraValor);
            this.pnlResumen.Controls.Add(this.lblUltimaCompra);
            this.pnlResumen.Controls.Add(this.lblMontoMaximoValor);
            this.pnlResumen.Controls.Add(this.lblMontoMaximo);
            this.pnlResumen.Controls.Add(this.lblMontoMinimoValor);
            this.pnlResumen.Controls.Add(this.lblMontoMinimo);
            this.pnlResumen.Controls.Add(this.lblAntiguedadValor);
            this.pnlResumen.Controls.Add(this.lblAntiguedadEtiqueta);
            this.pnlResumen.Controls.Add(this.lblPorcentajeValor);
            this.pnlResumen.Controls.Add(this.lblPorcentajeEtiqueta);
            this.pnlResumen.Controls.Add(this.lblPromedioValor);
            this.pnlResumen.Controls.Add(this.lblPromedioEtiqueta);
            this.pnlResumen.Controls.Add(this.lblResumenFinancieroEtiqueta);
            this.pnlResumen.Location = new System.Drawing.Point(5, 496);
            this.pnlResumen.Margin = new System.Windows.Forms.Padding(4);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(1210, 132);
            this.pnlResumen.TabIndex = 10;
            // 
            // lblUltimaCompraValor
            // 
            this.lblUltimaCompraValor.AutoSize = true;
            this.lblUltimaCompraValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompraValor.Location = new System.Drawing.Point(1008, 97);
            this.lblUltimaCompraValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimaCompraValor.Name = "lblUltimaCompraValor";
            this.lblUltimaCompraValor.Size = new System.Drawing.Size(15, 19);
            this.lblUltimaCompraValor.TabIndex = 22;
            this.lblUltimaCompraValor.Text = "-";
            // 
            // lblUltimaCompra
            // 
            this.lblUltimaCompra.AutoSize = true;
            this.lblUltimaCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompra.Location = new System.Drawing.Point(876, 97);
            this.lblUltimaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimaCompra.Name = "lblUltimaCompra";
            this.lblUltimaCompra.Size = new System.Drawing.Size(116, 19);
            this.lblUltimaCompra.TabIndex = 21;
            this.lblUltimaCompra.Text = "Última Compra";
            // 
            // lblMontoMaximoValor
            // 
            this.lblMontoMaximoValor.AutoSize = true;
            this.lblMontoMaximoValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximoValor.Location = new System.Drawing.Point(697, 97);
            this.lblMontoMaximoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaximoValor.Name = "lblMontoMaximoValor";
            this.lblMontoMaximoValor.Size = new System.Drawing.Size(15, 19);
            this.lblMontoMaximoValor.TabIndex = 20;
            this.lblMontoMaximoValor.Text = "-";
            // 
            // lblMontoMaximo
            // 
            this.lblMontoMaximo.AutoSize = true;
            this.lblMontoMaximo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximo.Location = new System.Drawing.Point(495, 97);
            this.lblMontoMaximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaximo.Name = "lblMontoMaximo";
            this.lblMontoMaximo.Size = new System.Drawing.Size(113, 19);
            this.lblMontoMaximo.TabIndex = 19;
            this.lblMontoMaximo.Text = "Monto Máximo";
            // 
            // lblMontoMinimoValor
            // 
            this.lblMontoMinimoValor.AutoSize = true;
            this.lblMontoMinimoValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimoValor.Location = new System.Drawing.Point(327, 97);
            this.lblMontoMinimoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinimoValor.Name = "lblMontoMinimoValor";
            this.lblMontoMinimoValor.Size = new System.Drawing.Size(15, 19);
            this.lblMontoMinimoValor.TabIndex = 18;
            this.lblMontoMinimoValor.Text = "-";
            // 
            // lblMontoMinimo
            // 
            this.lblMontoMinimo.AutoSize = true;
            this.lblMontoMinimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimo.Location = new System.Drawing.Point(127, 97);
            this.lblMontoMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(111, 19);
            this.lblMontoMinimo.TabIndex = 17;
            this.lblMontoMinimo.Text = "Monto Mínimo";
            // 
            // lblAntiguedadValor
            // 
            this.lblAntiguedadValor.AutoSize = true;
            this.lblAntiguedadValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedadValor.Location = new System.Drawing.Point(999, 48);
            this.lblAntiguedadValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntiguedadValor.Name = "lblAntiguedadValor";
            this.lblAntiguedadValor.Size = new System.Drawing.Size(15, 19);
            this.lblAntiguedadValor.TabIndex = 16;
            this.lblAntiguedadValor.Text = "-";
            // 
            // lblAntiguedadEtiqueta
            // 
            this.lblAntiguedadEtiqueta.AutoSize = true;
            this.lblAntiguedadEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedadEtiqueta.Location = new System.Drawing.Point(876, 48);
            this.lblAntiguedadEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntiguedadEtiqueta.Name = "lblAntiguedadEtiqueta";
            this.lblAntiguedadEtiqueta.Size = new System.Drawing.Size(91, 19);
            this.lblAntiguedadEtiqueta.TabIndex = 15;
            this.lblAntiguedadEtiqueta.Text = "Antigüedad";
            // 
            // lblPorcentajeValor
            // 
            this.lblPorcentajeValor.AutoSize = true;
            this.lblPorcentajeValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeValor.Location = new System.Drawing.Point(619, 48);
            this.lblPorcentajeValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeValor.Name = "lblPorcentajeValor";
            this.lblPorcentajeValor.Size = new System.Drawing.Size(15, 19);
            this.lblPorcentajeValor.TabIndex = 14;
            this.lblPorcentajeValor.Text = "-";
            // 
            // lblPorcentajeEtiqueta
            // 
            this.lblPorcentajeEtiqueta.AutoSize = true;
            this.lblPorcentajeEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeEtiqueta.Location = new System.Drawing.Point(495, 48);
            this.lblPorcentajeEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeEtiqueta.Name = "lblPorcentajeEtiqueta";
            this.lblPorcentajeEtiqueta.Size = new System.Drawing.Size(85, 19);
            this.lblPorcentajeEtiqueta.TabIndex = 13;
            this.lblPorcentajeEtiqueta.Text = "% Pagado";
            // 
            // lblPromedioValor
            // 
            this.lblPromedioValor.AutoSize = true;
            this.lblPromedioValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioValor.Location = new System.Drawing.Point(329, 48);
            this.lblPromedioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioValor.Name = "lblPromedioValor";
            this.lblPromedioValor.Size = new System.Drawing.Size(15, 19);
            this.lblPromedioValor.TabIndex = 12;
            this.lblPromedioValor.Text = "-";
            // 
            // lblPromedioEtiqueta
            // 
            this.lblPromedioEtiqueta.AutoSize = true;
            this.lblPromedioEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioEtiqueta.Location = new System.Drawing.Point(127, 48);
            this.lblPromedioEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioEtiqueta.Name = "lblPromedioEtiqueta";
            this.lblPromedioEtiqueta.Size = new System.Drawing.Size(165, 19);
            this.lblPromedioEtiqueta.TabIndex = 11;
            this.lblPromedioEtiqueta.Text = "Promedio de Compra";
            // 
            // lblResumenFinancieroEtiqueta
            // 
            this.lblResumenFinancieroEtiqueta.AutoSize = true;
            this.lblResumenFinancieroEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenFinancieroEtiqueta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblResumenFinancieroEtiqueta.Location = new System.Drawing.Point(12, 14);
            this.lblResumenFinancieroEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumenFinancieroEtiqueta.Name = "lblResumenFinancieroEtiqueta";
            this.lblResumenFinancieroEtiqueta.Size = new System.Drawing.Size(197, 19);
            this.lblResumenFinancieroEtiqueta.TabIndex = 10;
            this.lblResumenFinancieroEtiqueta.Text = "RESUMEN FINANCIERO";
            // 
            // dgvHistorial
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeight = 29;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colN,
            this.colNumPedidos,
            this.colFecha,
            this.colProducto,
            this.colMonto,
            this.colPagado,
            this.colSaldo,
            this.colEstado});
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Location = new System.Drawing.Point(5, 153);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1211, 336);
            this.dgvHistorial.TabIndex = 9;
            // 
            // colN
            // 
            this.colN.HeaderText = "NumeroFila";
            this.colN.MinimumWidth = 6;
            this.colN.Name = "colN";
            this.colN.ReadOnly = true;
            // 
            // colNumPedidos
            // 
            this.colNumPedidos.HeaderText = "N°Pedido";
            this.colNumPedidos.MinimumWidth = 6;
            this.colNumPedidos.Name = "colNumPedidos";
            this.colNumPedidos.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Productos";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.MinimumWidth = 6;
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colPagado
            // 
            this.colPagado.HeaderText = "Pagado";
            this.colPagado.MinimumWidth = 6;
            this.colPagado.Name = "colPagado";
            this.colPagado.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.MinimumWidth = 6;
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSaldoPendienteValor);
            this.panel1.Controls.Add(this.lblSaldoPendienteEtiqueta);
            this.panel1.Controls.Add(this.lblTotalPagadoValor);
            this.panel1.Controls.Add(this.lblTotalCompradoValor);
            this.panel1.Controls.Add(this.lblTotalPagadoEtiqueta);
            this.panel1.Controls.Add(this.lblTotalCompradoEtiqueta);
            this.panel1.Location = new System.Drawing.Point(7, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 48);
            this.panel1.TabIndex = 8;
            // 
            // lblSaldoPendienteValor
            // 
            this.lblSaldoPendienteValor.AutoSize = true;
            this.lblSaldoPendienteValor.Location = new System.Drawing.Point(1053, 14);
            this.lblSaldoPendienteValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoPendienteValor.Name = "lblSaldoPendienteValor";
            this.lblSaldoPendienteValor.Size = new System.Drawing.Size(11, 16);
            this.lblSaldoPendienteValor.TabIndex = 9;
            this.lblSaldoPendienteValor.Text = "-";
            // 
            // lblSaldoPendienteEtiqueta
            // 
            this.lblSaldoPendienteEtiqueta.AutoSize = true;
            this.lblSaldoPendienteEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPendienteEtiqueta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblSaldoPendienteEtiqueta.Location = new System.Drawing.Point(861, 12);
            this.lblSaldoPendienteEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoPendienteEtiqueta.Name = "lblSaldoPendienteEtiqueta";
            this.lblSaldoPendienteEtiqueta.Size = new System.Drawing.Size(165, 19);
            this.lblSaldoPendienteEtiqueta.TabIndex = 8;
            this.lblSaldoPendienteEtiqueta.Text = "SALDO PENDIENTE";
            // 
            // lblTotalPagadoValor
            // 
            this.lblTotalPagadoValor.AutoSize = true;
            this.lblTotalPagadoValor.Location = new System.Drawing.Point(629, 16);
            this.lblTotalPagadoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagadoValor.Name = "lblTotalPagadoValor";
            this.lblTotalPagadoValor.Size = new System.Drawing.Size(11, 16);
            this.lblTotalPagadoValor.TabIndex = 7;
            this.lblTotalPagadoValor.Text = "-";
            // 
            // lblTotalCompradoValor
            // 
            this.lblTotalCompradoValor.AutoSize = true;
            this.lblTotalCompradoValor.Location = new System.Drawing.Point(212, 17);
            this.lblTotalCompradoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCompradoValor.Name = "lblTotalCompradoValor";
            this.lblTotalCompradoValor.Size = new System.Drawing.Size(11, 16);
            this.lblTotalCompradoValor.TabIndex = 6;
            this.lblTotalCompradoValor.Text = "-";
            // 
            // lblTotalPagadoEtiqueta
            // 
            this.lblTotalPagadoEtiqueta.AutoSize = true;
            this.lblTotalPagadoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagadoEtiqueta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblTotalPagadoEtiqueta.Location = new System.Drawing.Point(461, 14);
            this.lblTotalPagadoEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagadoEtiqueta.Name = "lblTotalPagadoEtiqueta";
            this.lblTotalPagadoEtiqueta.Size = new System.Drawing.Size(137, 19);
            this.lblTotalPagadoEtiqueta.TabIndex = 6;
            this.lblTotalPagadoEtiqueta.Text = "TOTAL PAGADO";
            // 
            // lblTotalCompradoEtiqueta
            // 
            this.lblTotalCompradoEtiqueta.AutoSize = true;
            this.lblTotalCompradoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompradoEtiqueta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.lblTotalCompradoEtiqueta.Location = new System.Drawing.Point(16, 14);
            this.lblTotalCompradoEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCompradoEtiqueta.Name = "lblTotalCompradoEtiqueta";
            this.lblTotalCompradoEtiqueta.Size = new System.Drawing.Size(164, 19);
            this.lblTotalCompradoEtiqueta.TabIndex = 6;
            this.lblTotalCompradoEtiqueta.Text = "TOTAL COMPRADO";
            // 
            // pnlInfoCliente
            // 
            this.pnlInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.pnlInfoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoCliente.Controls.Add(this.lblDireccionValor);
            this.pnlInfoCliente.Controls.Add(this.lblDireccionEtiqueta);
            this.pnlInfoCliente.Controls.Add(this.lblContactoValor);
            this.pnlInfoCliente.Controls.Add(this.lblContactoEtiqueta);
            this.pnlInfoCliente.Controls.Add(this.lblClienteValor);
            this.pnlInfoCliente.Controls.Add(this.lblClienteEtiqueta);
            this.pnlInfoCliente.Location = new System.Drawing.Point(8, 4);
            this.pnlInfoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInfoCliente.Name = "pnlInfoCliente";
            this.pnlInfoCliente.Size = new System.Drawing.Size(1209, 46);
            this.pnlInfoCliente.TabIndex = 7;
            // 
            // lblDireccionValor
            // 
            this.lblDireccionValor.AutoSize = true;
            this.lblDireccionValor.ForeColor = System.Drawing.Color.White;
            this.lblDireccionValor.Location = new System.Drawing.Point(972, 7);
            this.lblDireccionValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionValor.Name = "lblDireccionValor";
            this.lblDireccionValor.Size = new System.Drawing.Size(11, 16);
            this.lblDireccionValor.TabIndex = 5;
            this.lblDireccionValor.Text = "-";
            // 
            // lblDireccionEtiqueta
            // 
            this.lblDireccionEtiqueta.AutoSize = true;
            this.lblDireccionEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblDireccionEtiqueta.Location = new System.Drawing.Point(860, 5);
            this.lblDireccionEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionEtiqueta.Name = "lblDireccionEtiqueta";
            this.lblDireccionEtiqueta.Size = new System.Drawing.Size(101, 19);
            this.lblDireccionEtiqueta.TabIndex = 4;
            this.lblDireccionEtiqueta.Text = "DIRECCIÓN";
            // 
            // lblContactoValor
            // 
            this.lblContactoValor.AutoSize = true;
            this.lblContactoValor.ForeColor = System.Drawing.Color.White;
            this.lblContactoValor.Location = new System.Drawing.Point(571, 10);
            this.lblContactoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactoValor.Name = "lblContactoValor";
            this.lblContactoValor.Size = new System.Drawing.Size(11, 16);
            this.lblContactoValor.TabIndex = 3;
            this.lblContactoValor.Text = "-";
            // 
            // lblContactoEtiqueta
            // 
            this.lblContactoEtiqueta.AutoSize = true;
            this.lblContactoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblContactoEtiqueta.Location = new System.Drawing.Point(435, 7);
            this.lblContactoEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactoEtiqueta.Name = "lblContactoEtiqueta";
            this.lblContactoEtiqueta.Size = new System.Drawing.Size(101, 19);
            this.lblContactoEtiqueta.TabIndex = 2;
            this.lblContactoEtiqueta.Text = "CONTACTO";
            // 
            // lblClienteValor
            // 
            this.lblClienteValor.AutoSize = true;
            this.lblClienteValor.ForeColor = System.Drawing.Color.White;
            this.lblClienteValor.Location = new System.Drawing.Point(124, 7);
            this.lblClienteValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteValor.Name = "lblClienteValor";
            this.lblClienteValor.Size = new System.Drawing.Size(11, 16);
            this.lblClienteValor.TabIndex = 1;
            this.lblClienteValor.Text = "-";
            // 
            // lblClienteEtiqueta
            // 
            this.lblClienteEtiqueta.AutoSize = true;
            this.lblClienteEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblClienteEtiqueta.Location = new System.Drawing.Point(12, 5);
            this.lblClienteEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteEtiqueta.Name = "lblClienteEtiqueta";
            this.lblClienteEtiqueta.Size = new System.Drawing.Size(79, 19);
            this.lblClienteEtiqueta.TabIndex = 0;
            this.lblClienteEtiqueta.Text = "CLIENTE";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCerrar.Location = new System.Drawing.Point(1088, 651);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(128, 43);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1227, 709);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHistorialCliente";
            this.Text = "Historial Cliente";
            this.Load += new System.EventHandler(this.FormHistorialCliente_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInfoCliente.ResumeLayout(false);
            this.pnlInfoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblUltimaCompraValor;
        private System.Windows.Forms.Label lblUltimaCompra;
        private System.Windows.Forms.Label lblMontoMaximoValor;
        private System.Windows.Forms.Label lblMontoMaximo;
        private System.Windows.Forms.Label lblMontoMinimoValor;
        private System.Windows.Forms.Label lblMontoMinimo;
        private System.Windows.Forms.Label lblAntiguedadValor;
        private System.Windows.Forms.Label lblAntiguedadEtiqueta;
        private System.Windows.Forms.Label lblPorcentajeValor;
        private System.Windows.Forms.Label lblPorcentajeEtiqueta;
        private System.Windows.Forms.Label lblPromedioValor;
        private System.Windows.Forms.Label lblPromedioEtiqueta;
        private System.Windows.Forms.Label lblResumenFinancieroEtiqueta;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaldoPendienteValor;
        private System.Windows.Forms.Label lblSaldoPendienteEtiqueta;
        private System.Windows.Forms.Label lblTotalPagadoValor;
        private System.Windows.Forms.Label lblTotalCompradoValor;
        private System.Windows.Forms.Label lblTotalPagadoEtiqueta;
        private System.Windows.Forms.Label lblTotalCompradoEtiqueta;
        private System.Windows.Forms.Panel pnlInfoCliente;
        private System.Windows.Forms.Label lblDireccionValor;
        private System.Windows.Forms.Label lblDireccionEtiqueta;
        private System.Windows.Forms.Label lblContactoValor;
        private System.Windows.Forms.Label lblContactoEtiqueta;
        private System.Windows.Forms.Label lblClienteValor;
        private System.Windows.Forms.Label lblClienteEtiqueta;
        private System.Windows.Forms.Button btnCerrar;
    }
}