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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnVerDetalle = new System.Windows.Forms.Button();
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
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Controls.Add(this.txtBusqueda);
            this.pnlFiltros.Location = new System.Drawing.Point(5, 92);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(907, 28);
            this.pnlFiltros.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Beige;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(768, -1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 26);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseMnemonic = false;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(737, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.Text = "Filtrar por N°Pedido, Fecha...";
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDetalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalle.Location = new System.Drawing.Point(784, 529);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(122, 41);
            this.btnVerDetalle.TabIndex = 11;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
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
            this.pnlResumen.Location = new System.Drawing.Point(4, 403);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(908, 108);
            this.pnlResumen.TabIndex = 10;
            // 
            // lblUltimaCompraValor
            // 
            this.lblUltimaCompraValor.AutoSize = true;
            this.lblUltimaCompraValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompraValor.Location = new System.Drawing.Point(756, 79);
            this.lblUltimaCompraValor.Name = "lblUltimaCompraValor";
            this.lblUltimaCompraValor.Size = new System.Drawing.Size(11, 16);
            this.lblUltimaCompraValor.TabIndex = 22;
            this.lblUltimaCompraValor.Text = "-";
            // 
            // lblUltimaCompra
            // 
            this.lblUltimaCompra.AutoSize = true;
            this.lblUltimaCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompra.Location = new System.Drawing.Point(657, 79);
            this.lblUltimaCompra.Name = "lblUltimaCompra";
            this.lblUltimaCompra.Size = new System.Drawing.Size(93, 16);
            this.lblUltimaCompra.TabIndex = 21;
            this.lblUltimaCompra.Text = "Última Compra";
            // 
            // lblMontoMaximoValor
            // 
            this.lblMontoMaximoValor.AutoSize = true;
            this.lblMontoMaximoValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximoValor.Location = new System.Drawing.Point(523, 79);
            this.lblMontoMaximoValor.Name = "lblMontoMaximoValor";
            this.lblMontoMaximoValor.Size = new System.Drawing.Size(11, 16);
            this.lblMontoMaximoValor.TabIndex = 20;
            this.lblMontoMaximoValor.Text = "-";
            // 
            // lblMontoMaximo
            // 
            this.lblMontoMaximo.AutoSize = true;
            this.lblMontoMaximo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximo.Location = new System.Drawing.Point(371, 79);
            this.lblMontoMaximo.Name = "lblMontoMaximo";
            this.lblMontoMaximo.Size = new System.Drawing.Size(93, 16);
            this.lblMontoMaximo.TabIndex = 19;
            this.lblMontoMaximo.Text = "Monto Máximo";
            // 
            // lblMontoMinimoValor
            // 
            this.lblMontoMinimoValor.AutoSize = true;
            this.lblMontoMinimoValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimoValor.Location = new System.Drawing.Point(245, 79);
            this.lblMontoMinimoValor.Name = "lblMontoMinimoValor";
            this.lblMontoMinimoValor.Size = new System.Drawing.Size(11, 16);
            this.lblMontoMinimoValor.TabIndex = 18;
            this.lblMontoMinimoValor.Text = "-";
            // 
            // lblMontoMinimo
            // 
            this.lblMontoMinimo.AutoSize = true;
            this.lblMontoMinimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimo.Location = new System.Drawing.Point(95, 79);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(89, 16);
            this.lblMontoMinimo.TabIndex = 17;
            this.lblMontoMinimo.Text = "Monto Mínimo";
            // 
            // lblAntiguedadValor
            // 
            this.lblAntiguedadValor.AutoSize = true;
            this.lblAntiguedadValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedadValor.Location = new System.Drawing.Point(749, 39);
            this.lblAntiguedadValor.Name = "lblAntiguedadValor";
            this.lblAntiguedadValor.Size = new System.Drawing.Size(11, 16);
            this.lblAntiguedadValor.TabIndex = 16;
            this.lblAntiguedadValor.Text = "-";
            // 
            // lblAntiguedadEtiqueta
            // 
            this.lblAntiguedadEtiqueta.AutoSize = true;
            this.lblAntiguedadEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedadEtiqueta.Location = new System.Drawing.Point(657, 39);
            this.lblAntiguedadEtiqueta.Name = "lblAntiguedadEtiqueta";
            this.lblAntiguedadEtiqueta.Size = new System.Drawing.Size(72, 16);
            this.lblAntiguedadEtiqueta.TabIndex = 15;
            this.lblAntiguedadEtiqueta.Text = "Antigüedad";
            // 
            // lblPorcentajeValor
            // 
            this.lblPorcentajeValor.AutoSize = true;
            this.lblPorcentajeValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeValor.Location = new System.Drawing.Point(464, 39);
            this.lblPorcentajeValor.Name = "lblPorcentajeValor";
            this.lblPorcentajeValor.Size = new System.Drawing.Size(11, 16);
            this.lblPorcentajeValor.TabIndex = 14;
            this.lblPorcentajeValor.Text = "-";
            // 
            // lblPorcentajeEtiqueta
            // 
            this.lblPorcentajeEtiqueta.AutoSize = true;
            this.lblPorcentajeEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeEtiqueta.Location = new System.Drawing.Point(371, 39);
            this.lblPorcentajeEtiqueta.Name = "lblPorcentajeEtiqueta";
            this.lblPorcentajeEtiqueta.Size = new System.Drawing.Size(67, 16);
            this.lblPorcentajeEtiqueta.TabIndex = 13;
            this.lblPorcentajeEtiqueta.Text = "% Pagado";
            // 
            // lblPromedioValor
            // 
            this.lblPromedioValor.AutoSize = true;
            this.lblPromedioValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioValor.Location = new System.Drawing.Point(247, 39);
            this.lblPromedioValor.Name = "lblPromedioValor";
            this.lblPromedioValor.Size = new System.Drawing.Size(11, 16);
            this.lblPromedioValor.TabIndex = 12;
            this.lblPromedioValor.Text = "-";
            // 
            // lblPromedioEtiqueta
            // 
            this.lblPromedioEtiqueta.AutoSize = true;
            this.lblPromedioEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioEtiqueta.Location = new System.Drawing.Point(95, 39);
            this.lblPromedioEtiqueta.Name = "lblPromedioEtiqueta";
            this.lblPromedioEtiqueta.Size = new System.Drawing.Size(129, 16);
            this.lblPromedioEtiqueta.TabIndex = 11;
            this.lblPromedioEtiqueta.Text = "Promedio de Compra";
            // 
            // lblResumenFinancieroEtiqueta
            // 
            this.lblResumenFinancieroEtiqueta.AutoSize = true;
            this.lblResumenFinancieroEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenFinancieroEtiqueta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResumenFinancieroEtiqueta.Location = new System.Drawing.Point(9, 11);
            this.lblResumenFinancieroEtiqueta.Name = "lblResumenFinancieroEtiqueta";
            this.lblResumenFinancieroEtiqueta.Size = new System.Drawing.Size(153, 16);
            this.lblResumenFinancieroEtiqueta.TabIndex = 10;
            this.lblResumenFinancieroEtiqueta.Text = "RESUMEN FINANCIERO";
            // 
            // dgvHistorial
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvHistorial.Location = new System.Drawing.Point(4, 124);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(908, 273);
            this.dgvHistorial.TabIndex = 9;
            // 
            // colN
            // 
            this.colN.HeaderText = "NumeroFila";
            this.colN.Name = "colN";
            this.colN.ReadOnly = true;
            // 
            // colNumPedidos
            // 
            this.colNumPedidos.HeaderText = "N°Pedido";
            this.colNumPedidos.Name = "colNumPedidos";
            this.colNumPedidos.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Productos";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colPagado
            // 
            this.colPagado.HeaderText = "Pagado";
            this.colPagado.Name = "colPagado";
            this.colPagado.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
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
            this.panel1.Location = new System.Drawing.Point(5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 39);
            this.panel1.TabIndex = 8;
            // 
            // lblSaldoPendienteValor
            // 
            this.lblSaldoPendienteValor.AutoSize = true;
            this.lblSaldoPendienteValor.Location = new System.Drawing.Point(790, 11);
            this.lblSaldoPendienteValor.Name = "lblSaldoPendienteValor";
            this.lblSaldoPendienteValor.Size = new System.Drawing.Size(10, 13);
            this.lblSaldoPendienteValor.TabIndex = 9;
            this.lblSaldoPendienteValor.Text = "-";
            // 
            // lblSaldoPendienteEtiqueta
            // 
            this.lblSaldoPendienteEtiqueta.AutoSize = true;
            this.lblSaldoPendienteEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPendienteEtiqueta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaldoPendienteEtiqueta.Location = new System.Drawing.Point(646, 10);
            this.lblSaldoPendienteEtiqueta.Name = "lblSaldoPendienteEtiqueta";
            this.lblSaldoPendienteEtiqueta.Size = new System.Drawing.Size(128, 16);
            this.lblSaldoPendienteEtiqueta.TabIndex = 8;
            this.lblSaldoPendienteEtiqueta.Text = "SALDO PENDIENTE";
            // 
            // lblTotalPagadoValor
            // 
            this.lblTotalPagadoValor.AutoSize = true;
            this.lblTotalPagadoValor.Location = new System.Drawing.Point(472, 13);
            this.lblTotalPagadoValor.Name = "lblTotalPagadoValor";
            this.lblTotalPagadoValor.Size = new System.Drawing.Size(10, 13);
            this.lblTotalPagadoValor.TabIndex = 7;
            this.lblTotalPagadoValor.Text = "-";
            // 
            // lblTotalCompradoValor
            // 
            this.lblTotalCompradoValor.AutoSize = true;
            this.lblTotalCompradoValor.Location = new System.Drawing.Point(159, 14);
            this.lblTotalCompradoValor.Name = "lblTotalCompradoValor";
            this.lblTotalCompradoValor.Size = new System.Drawing.Size(10, 13);
            this.lblTotalCompradoValor.TabIndex = 6;
            this.lblTotalCompradoValor.Text = "-";
            // 
            // lblTotalPagadoEtiqueta
            // 
            this.lblTotalPagadoEtiqueta.AutoSize = true;
            this.lblTotalPagadoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagadoEtiqueta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalPagadoEtiqueta.Location = new System.Drawing.Point(346, 11);
            this.lblTotalPagadoEtiqueta.Name = "lblTotalPagadoEtiqueta";
            this.lblTotalPagadoEtiqueta.Size = new System.Drawing.Size(108, 16);
            this.lblTotalPagadoEtiqueta.TabIndex = 6;
            this.lblTotalPagadoEtiqueta.Text = "TOTAL PAGADO";
            // 
            // lblTotalCompradoEtiqueta
            // 
            this.lblTotalCompradoEtiqueta.AutoSize = true;
            this.lblTotalCompradoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompradoEtiqueta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalCompradoEtiqueta.Location = new System.Drawing.Point(12, 11);
            this.lblTotalCompradoEtiqueta.Name = "lblTotalCompradoEtiqueta";
            this.lblTotalCompradoEtiqueta.Size = new System.Drawing.Size(129, 16);
            this.lblTotalCompradoEtiqueta.TabIndex = 6;
            this.lblTotalCompradoEtiqueta.Text = "TOTAL COMPRADO";
            // 
            // pnlInfoCliente
            // 
            this.pnlInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlInfoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoCliente.Controls.Add(this.lblDireccionValor);
            this.pnlInfoCliente.Controls.Add(this.lblDireccionEtiqueta);
            this.pnlInfoCliente.Controls.Add(this.lblContactoValor);
            this.pnlInfoCliente.Controls.Add(this.lblContactoEtiqueta);
            this.pnlInfoCliente.Controls.Add(this.lblClienteValor);
            this.pnlInfoCliente.Controls.Add(this.lblClienteEtiqueta);
            this.pnlInfoCliente.Location = new System.Drawing.Point(6, 3);
            this.pnlInfoCliente.Name = "pnlInfoCliente";
            this.pnlInfoCliente.Size = new System.Drawing.Size(907, 38);
            this.pnlInfoCliente.TabIndex = 7;
            // 
            // lblDireccionValor
            // 
            this.lblDireccionValor.AutoSize = true;
            this.lblDireccionValor.ForeColor = System.Drawing.Color.White;
            this.lblDireccionValor.Location = new System.Drawing.Point(729, 6);
            this.lblDireccionValor.Name = "lblDireccionValor";
            this.lblDireccionValor.Size = new System.Drawing.Size(10, 13);
            this.lblDireccionValor.TabIndex = 5;
            this.lblDireccionValor.Text = "-";
            // 
            // lblDireccionEtiqueta
            // 
            this.lblDireccionEtiqueta.AutoSize = true;
            this.lblDireccionEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblDireccionEtiqueta.Location = new System.Drawing.Point(645, 4);
            this.lblDireccionEtiqueta.Name = "lblDireccionEtiqueta";
            this.lblDireccionEtiqueta.Size = new System.Drawing.Size(78, 16);
            this.lblDireccionEtiqueta.TabIndex = 4;
            this.lblDireccionEtiqueta.Text = "DIRECCIÓN";
            // 
            // lblContactoValor
            // 
            this.lblContactoValor.AutoSize = true;
            this.lblContactoValor.ForeColor = System.Drawing.Color.White;
            this.lblContactoValor.Location = new System.Drawing.Point(428, 8);
            this.lblContactoValor.Name = "lblContactoValor";
            this.lblContactoValor.Size = new System.Drawing.Size(10, 13);
            this.lblContactoValor.TabIndex = 3;
            this.lblContactoValor.Text = "-";
            // 
            // lblContactoEtiqueta
            // 
            this.lblContactoEtiqueta.AutoSize = true;
            this.lblContactoEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblContactoEtiqueta.Location = new System.Drawing.Point(326, 6);
            this.lblContactoEtiqueta.Name = "lblContactoEtiqueta";
            this.lblContactoEtiqueta.Size = new System.Drawing.Size(78, 16);
            this.lblContactoEtiqueta.TabIndex = 2;
            this.lblContactoEtiqueta.Text = "CONTACTO";
            // 
            // lblClienteValor
            // 
            this.lblClienteValor.AutoSize = true;
            this.lblClienteValor.ForeColor = System.Drawing.Color.White;
            this.lblClienteValor.Location = new System.Drawing.Point(93, 6);
            this.lblClienteValor.Name = "lblClienteValor";
            this.lblClienteValor.Size = new System.Drawing.Size(10, 13);
            this.lblClienteValor.TabIndex = 1;
            this.lblClienteValor.Text = "-";
            // 
            // lblClienteEtiqueta
            // 
            this.lblClienteEtiqueta.AutoSize = true;
            this.lblClienteEtiqueta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblClienteEtiqueta.Location = new System.Drawing.Point(9, 4);
            this.lblClienteEtiqueta.Name = "lblClienteEtiqueta";
            this.lblClienteEtiqueta.Size = new System.Drawing.Size(61, 16);
            this.lblClienteEtiqueta.TabIndex = 0;
            this.lblClienteEtiqueta.Text = "CLIENTE";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCerrar.Location = new System.Drawing.Point(672, 532);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 35);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(920, 576);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnVerDetalle;
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