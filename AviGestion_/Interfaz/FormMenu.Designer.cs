namespace AviGestion_.UI
{
    partial class FormMenu
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();

            this.btnClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();

            this.btnUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();

            this.btnPedidos = new System.Windows.Forms.Panel();
            this.lblPedidos = new System.Windows.Forms.Label();

            this.btnProductos = new System.Windows.Forms.Panel();
            this.lblProductosTitulo = new System.Windows.Forms.Label();
            this.lblProductosDescripcion = new System.Windows.Forms.Label();

            this.btnAsignarPedidos = new System.Windows.Forms.Panel();
            this.lblAsignarPedidos = new System.Windows.Forms.Label();

            this.btnFacturacion = new System.Windows.Forms.Panel();
            this.lblFacturacion = new System.Windows.Forms.Label();

            this.btnRegistrarPago = new System.Windows.Forms.Panel();
            this.lblRegistrarPago = new System.Windows.Forms.Label();

            this.btnStock = new System.Windows.Forms.Panel();
            this.lblStockTitulo = new System.Windows.Forms.Label();
            this.lblStockDescripcion = new System.Windows.Forms.Label();

            this.btnCategorias = new System.Windows.Forms.Panel();
            this.lblCategorias = new System.Windows.Forms.Label();

            this.btnVehiculos = new System.Windows.Forms.Panel();
            this.lblVehiculos = new System.Windows.Forms.Label();

            this.btnBitacora = new System.Windows.Forms.Panel();
            this.lblBitacora = new System.Windows.Forms.Label();

            this.btnBackup = new System.Windows.Forms.Panel();
            this.lblBackup = new System.Windows.Forms.Label();

            this.btnAyuda = new System.Windows.Forms.Panel();
            this.lblAyuda = new System.Windows.Forms.Label();

            this.pnlStockResumen = new System.Windows.Forms.Panel();
            this.lblStockResumenTitulo = new System.Windows.Forms.Label();

            this.pnlGraficoPedidos = new System.Windows.Forms.Panel();
            this.lblGraficoPedidosTitulo = new System.Windows.Forms.Label();

            this.pnlGraficoProductos = new System.Windows.Forms.Panel();
            this.lblGraficoProductosTitulo = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.btnClientes.SuspendLayout();
            this.btnUsuarios.SuspendLayout();
            this.btnPedidos.SuspendLayout();
            this.btnProductos.SuspendLayout();
            this.btnAsignarPedidos.SuspendLayout();
            this.btnFacturacion.SuspendLayout();
            this.btnRegistrarPago.SuspendLayout();
            this.btnStock.SuspendLayout();
            this.btnCategorias.SuspendLayout();
            this.btnVehiculos.SuspendLayout();
            this.btnBitacora.SuspendLayout();
            this.btnBackup.SuspendLayout();
            this.btnAyuda.SuspendLayout();
            this.pnlStockResumen.SuspendLayout();
            this.pnlGraficoPedidos.SuspendLayout();
            this.pnlGraficoProductos.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1020, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú Principal - Sistema AviGestión";
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnClientes);
            this.pnlSidebar.Controls.Add(this.btnUsuarios);
            this.pnlSidebar.Controls.Add(this.btnPedidos);
            this.pnlSidebar.Controls.Add(this.btnProductos);
            this.pnlSidebar.Controls.Add(this.btnAsignarPedidos);
            this.pnlSidebar.Controls.Add(this.btnFacturacion);
            this.pnlSidebar.Controls.Add(this.btnRegistrarPago);
            this.pnlSidebar.Controls.Add(this.btnStock);
            this.pnlSidebar.Controls.Add(this.btnCategorias);
            this.pnlSidebar.Controls.Add(this.btnVehiculos);
            this.pnlSidebar.Controls.Add(this.btnBitacora);
            this.pnlSidebar.Controls.Add(this.btnBackup);
            this.pnlSidebar.Controls.Add(this.btnAyuda);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 540);
            this.pnlSidebar.TabIndex = 1;
            //
            // btnClientes
            //
            this.btnClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClientes.Controls.Add(this.lblClientes);
            this.btnClientes.Location = new System.Drawing.Point(10, 16);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 30);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            //
            // lblClientes
            //
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblClientes.Location = new System.Drawing.Point(12, 6);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(60, 19);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            //
            // btnUsuarios
            //
            this.btnUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUsuarios.Controls.Add(this.lblUsuarios);
            this.btnUsuarios.Location = new System.Drawing.Point(10, 52);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 30);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            //
            // lblUsuarios
            //
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblUsuarios.Location = new System.Drawing.Point(12, 6);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(65, 19);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuarios";
            //
            // btnPedidos
            //
            this.btnPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPedidos.Controls.Add(this.lblPedidos);
            this.btnPedidos.Location = new System.Drawing.Point(10, 88);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 30);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            //
            // lblPedidos
            //
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPedidos.Location = new System.Drawing.Point(12, 6);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(62, 19);
            this.lblPedidos.TabIndex = 0;
            this.lblPedidos.Text = "Pedidos";
            //
            // btnProductos
            //
            this.btnProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProductos.Controls.Add(this.lblProductosDescripcion);
            this.btnProductos.Controls.Add(this.lblProductosTitulo);
            this.btnProductos.Location = new System.Drawing.Point(10, 124);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 30);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            //
            // lblProductosTitulo
            //
            this.lblProductosTitulo.AutoSize = true;
            this.lblProductosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblProductosTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblProductosTitulo.Name = "lblProductosTitulo";
            this.lblProductosTitulo.Size = new System.Drawing.Size(80, 19);
            this.lblProductosTitulo.TabIndex = 0;
            this.lblProductosTitulo.Text = "Productos";
            //
            // lblProductosDescripcion
            //
            this.lblProductosDescripcion.AutoSize = true;
            this.lblProductosDescripcion.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblProductosDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblProductosDescripcion.Location = new System.Drawing.Point(92, 10);
            this.lblProductosDescripcion.Name = "lblProductosDescripcion";
            this.lblProductosDescripcion.Size = new System.Drawing.Size(60, 12);
            this.lblProductosDescripcion.TabIndex = 1;
            this.lblProductosDescripcion.Text = "catálogo";
            this.lblProductosDescripcion.Visible = false;
            //
            // btnAsignarPedidos
            //
            this.btnAsignarPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAsignarPedidos.Controls.Add(this.lblAsignarPedidos);
            this.btnAsignarPedidos.Location = new System.Drawing.Point(10, 160);
            this.btnAsignarPedidos.Name = "btnAsignarPedidos";
            this.btnAsignarPedidos.Size = new System.Drawing.Size(200, 30);
            this.btnAsignarPedidos.TabIndex = 4;
            //
            // lblAsignarPedidos
            //
            this.lblAsignarPedidos.AutoSize = true;
            this.lblAsignarPedidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAsignarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblAsignarPedidos.Location = new System.Drawing.Point(12, 6);
            this.lblAsignarPedidos.Name = "lblAsignarPedidos";
            this.lblAsignarPedidos.Size = new System.Drawing.Size(110, 19);
            this.lblAsignarPedidos.TabIndex = 0;
            this.lblAsignarPedidos.Text = "Asignar Pedidos";
            //
            // btnFacturacion
            //
            this.btnFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFacturacion.Controls.Add(this.lblFacturacion);
            this.btnFacturacion.Location = new System.Drawing.Point(10, 196);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(200, 30);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            //
            // lblFacturacion
            //
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFacturacion.Location = new System.Drawing.Point(12, 6);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(85, 19);
            this.lblFacturacion.TabIndex = 0;
            this.lblFacturacion.Text = "Facturación";
            //
            // btnRegistrarPago
            //
            this.btnRegistrarPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRegistrarPago.Controls.Add(this.lblRegistrarPago);
            this.btnRegistrarPago.Location = new System.Drawing.Point(10, 232);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(200, 30);
            this.btnRegistrarPago.TabIndex = 6;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            //
            // lblRegistrarPago
            //
            this.lblRegistrarPago.AutoSize = true;
            this.lblRegistrarPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblRegistrarPago.Location = new System.Drawing.Point(12, 6);
            this.lblRegistrarPago.Name = "lblRegistrarPago";
            this.lblRegistrarPago.Size = new System.Drawing.Size(115, 19);
            this.lblRegistrarPago.TabIndex = 0;
            this.lblRegistrarPago.Text = "Registrar Pagos";
            //
            // btnStock
            //
            this.btnStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStock.Controls.Add(this.lblStockDescripcion);
            this.btnStock.Controls.Add(this.lblStockTitulo);
            this.btnStock.Location = new System.Drawing.Point(10, 268);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(200, 30);
            this.btnStock.TabIndex = 7;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click_1);
            //
            // lblStockTitulo
            //
            this.lblStockTitulo.AutoSize = true;
            this.lblStockTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblStockTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblStockTitulo.Name = "lblStockTitulo";
            this.lblStockTitulo.Size = new System.Drawing.Size(48, 19);
            this.lblStockTitulo.TabIndex = 0;
            this.lblStockTitulo.Text = "Stock";
            //
            // lblStockDescripcion
            //
            this.lblStockDescripcion.AutoSize = true;
            this.lblStockDescripcion.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStockDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblStockDescripcion.Location = new System.Drawing.Point(64, 10);
            this.lblStockDescripcion.Name = "lblStockDescripcion";
            this.lblStockDescripcion.Size = new System.Drawing.Size(60, 12);
            this.lblStockDescripcion.TabIndex = 1;
            this.lblStockDescripcion.Text = "inventario";
            this.lblStockDescripcion.Visible = false;
            //
            // btnCategorias
            //
            this.btnCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCategorias.Controls.Add(this.lblCategorias);
            this.btnCategorias.Location = new System.Drawing.Point(10, 304);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(200, 30);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            //
            // lblCategorias
            //
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCategorias.Location = new System.Drawing.Point(12, 6);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(85, 19);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "Categorías";
            //
            // btnVehiculos
            //
            this.btnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVehiculos.Controls.Add(this.lblVehiculos);
            this.btnVehiculos.Location = new System.Drawing.Point(10, 340);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(200, 30);
            this.btnVehiculos.TabIndex = 9;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            //
            // lblVehiculos
            //
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblVehiculos.Location = new System.Drawing.Point(12, 6);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(85, 19);
            this.lblVehiculos.TabIndex = 0;
            this.lblVehiculos.Text = "Vehículos";
            //
            // btnBitacora
            //
            this.btnBitacora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBitacora.Controls.Add(this.lblBitacora);
            this.btnBitacora.Location = new System.Drawing.Point(10, 376);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(200, 30);
            this.btnBitacora.TabIndex = 10;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            //
            // lblBitacora
            //
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblBitacora.Location = new System.Drawing.Point(12, 6);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(70, 19);
            this.lblBitacora.TabIndex = 0;
            this.lblBitacora.Text = "Bitácora";
            //
            // btnBackup
            //
            this.btnBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBackup.Controls.Add(this.lblBackup);
            this.btnBackup.Location = new System.Drawing.Point(10, 412);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 30);
            this.btnBackup.TabIndex = 11;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            //
            // lblBackup
            //
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblBackup.Location = new System.Drawing.Point(12, 6);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(65, 19);
            this.lblBackup.TabIndex = 0;
            this.lblBackup.Text = "Backup";
            //
            // btnAyuda
            //
            this.btnAyuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAyuda.Controls.Add(this.lblAyuda);
            this.btnAyuda.Location = new System.Drawing.Point(10, 448);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(200, 30);
            this.btnAyuda.TabIndex = 12;
            //
            // lblAyuda
            //
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblAyuda.Location = new System.Drawing.Point(12, 6);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(55, 19);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "Ayuda";
            //
            // pnlStockResumen
            //
            this.pnlStockResumen.BackColor = System.Drawing.Color.White;
            this.pnlStockResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockResumen.Controls.Add(this.lblStockResumenTitulo);
            this.pnlStockResumen.Location = new System.Drawing.Point(240, 80);
            this.pnlStockResumen.Name = "pnlStockResumen";
            this.pnlStockResumen.Size = new System.Drawing.Size(740, 150);
            this.pnlStockResumen.TabIndex = 2;
            //
            // lblStockResumenTitulo
            //
            this.lblStockResumenTitulo.AutoSize = true;
            this.lblStockResumenTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblStockResumenTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblStockResumenTitulo.Name = "lblStockResumenTitulo";
            this.lblStockResumenTitulo.Size = new System.Drawing.Size(260, 20);
            this.lblStockResumenTitulo.TabIndex = 0;
            this.lblStockResumenTitulo.Text = "Stock de los diferentes productos";
            //
            // pnlGraficoPedidos
            //
            this.pnlGraficoPedidos.BackColor = System.Drawing.Color.White;
            this.pnlGraficoPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoPedidos.Controls.Add(this.lblGraficoPedidosTitulo);
            this.pnlGraficoPedidos.Location = new System.Drawing.Point(240, 250);
            this.pnlGraficoPedidos.Name = "pnlGraficoPedidos";
            this.pnlGraficoPedidos.Size = new System.Drawing.Size(360, 300);
            this.pnlGraficoPedidos.TabIndex = 3;
            //
            // lblGraficoPedidosTitulo
            //
            this.lblGraficoPedidosTitulo.AutoSize = true;
            this.lblGraficoPedidosTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGraficoPedidosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblGraficoPedidosTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblGraficoPedidosTitulo.Name = "lblGraficoPedidosTitulo";
            this.lblGraficoPedidosTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblGraficoPedidosTitulo.TabIndex = 0;
            this.lblGraficoPedidosTitulo.Text = "Pedidos por cliente";
            //
            // pnlGraficoProductos
            //
            this.pnlGraficoProductos.BackColor = System.Drawing.Color.White;
            this.pnlGraficoProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoProductos.Controls.Add(this.lblGraficoProductosTitulo);
            this.pnlGraficoProductos.Location = new System.Drawing.Point(620, 250);
            this.pnlGraficoProductos.Name = "pnlGraficoProductos";
            this.pnlGraficoProductos.Size = new System.Drawing.Size(360, 300);
            this.pnlGraficoProductos.TabIndex = 4;
            //
            // lblGraficoProductosTitulo
            //
            this.lblGraficoProductosTitulo.AutoSize = true;
            this.lblGraficoProductosTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGraficoProductosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblGraficoProductosTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblGraficoProductosTitulo.Name = "lblGraficoProductosTitulo";
            this.lblGraficoProductosTitulo.Size = new System.Drawing.Size(260, 20);
            this.lblGraficoProductosTitulo.TabIndex = 0;
            this.lblGraficoProductosTitulo.Text = "Cantidad de productos vendidos";
            //
            // FormMenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.pnlGraficoProductos);
            this.Controls.Add(this.pnlGraficoPedidos);
            this.Controls.Add(this.pnlStockResumen);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.btnClientes.ResumeLayout(false);
            this.btnClientes.PerformLayout();
            this.btnUsuarios.ResumeLayout(false);
            this.btnUsuarios.PerformLayout();
            this.btnPedidos.ResumeLayout(false);
            this.btnPedidos.PerformLayout();
            this.btnProductos.ResumeLayout(false);
            this.btnProductos.PerformLayout();
            this.btnAsignarPedidos.ResumeLayout(false);
            this.btnAsignarPedidos.PerformLayout();
            this.btnFacturacion.ResumeLayout(false);
            this.btnFacturacion.PerformLayout();
            this.btnRegistrarPago.ResumeLayout(false);
            this.btnRegistrarPago.PerformLayout();
            this.btnStock.ResumeLayout(false);
            this.btnStock.PerformLayout();
            this.btnCategorias.ResumeLayout(false);
            this.btnCategorias.PerformLayout();
            this.btnVehiculos.ResumeLayout(false);
            this.btnVehiculos.PerformLayout();
            this.btnBitacora.ResumeLayout(false);
            this.btnBitacora.PerformLayout();
            this.btnBackup.ResumeLayout(false);
            this.btnBackup.PerformLayout();
            this.btnAyuda.ResumeLayout(false);
            this.btnAyuda.PerformLayout();
            this.pnlStockResumen.ResumeLayout(false);
            this.pnlStockResumen.PerformLayout();
            this.pnlGraficoPedidos.ResumeLayout(false);
            this.pnlGraficoPedidos.PerformLayout();
            this.pnlGraficoProductos.ResumeLayout(false);
            this.pnlGraficoProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSidebar;

        private System.Windows.Forms.Panel btnClientes;
        private System.Windows.Forms.Label lblClientes;

        private System.Windows.Forms.Panel btnUsuarios;
        private System.Windows.Forms.Label lblUsuarios;

        private System.Windows.Forms.Panel btnPedidos;
        private System.Windows.Forms.Label lblPedidos;

        private System.Windows.Forms.Panel btnProductos;
        private System.Windows.Forms.Label lblProductosTitulo;
        private System.Windows.Forms.Label lblProductosDescripcion;

        private System.Windows.Forms.Panel btnAsignarPedidos;
        private System.Windows.Forms.Label lblAsignarPedidos;

        private System.Windows.Forms.Panel btnFacturacion;
        private System.Windows.Forms.Label lblFacturacion;

        private System.Windows.Forms.Panel btnRegistrarPago;
        private System.Windows.Forms.Label lblRegistrarPago;

        private System.Windows.Forms.Panel btnStock;
        private System.Windows.Forms.Label lblStockTitulo;
        private System.Windows.Forms.Label lblStockDescripcion;

        private System.Windows.Forms.Panel btnCategorias;
        private System.Windows.Forms.Label lblCategorias;

        private System.Windows.Forms.Panel btnVehiculos;
        private System.Windows.Forms.Label lblVehiculos;

        private System.Windows.Forms.Panel btnBitacora;
        private System.Windows.Forms.Label lblBitacora;

        private System.Windows.Forms.Panel btnBackup;
        private System.Windows.Forms.Label lblBackup;

        private System.Windows.Forms.Panel btnAyuda;
        private System.Windows.Forms.Label lblAyuda;

        private System.Windows.Forms.Panel pnlStockResumen;
        private System.Windows.Forms.Label lblStockResumenTitulo;

        private System.Windows.Forms.Panel pnlGraficoPedidos;
        private System.Windows.Forms.Label lblGraficoPedidosTitulo;

        private System.Windows.Forms.Panel pnlGraficoProductos;
        private System.Windows.Forms.Label lblGraficoProductosTitulo;
    }
}