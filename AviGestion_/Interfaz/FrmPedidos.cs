using AviGestion_.Datos;
using AviGestion_.Interfaz;
using AviGestion_.Logica;
using AviGestion_.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PdfDocument = iTextSharp.text.Document;
using PdfFont = iTextSharp.text.Font;

namespace AviGestion_.Interfaz
{
    public partial class FrmPedidos : Form
    {
        private PedidoLogica logica = new PedidoLogica();
        private Dictionary<string, string> _codigoPorNombre = new Dictionary<string, string>();
        private int _idPedidoDetalle = -1;
        private const string SUGERENCIA = "Filtrar por N°Pedido, Cliente, Fecha, Estado o Productos";

        #region Constructor
        public FrmPedidos()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            CargarPedidos();
            ConfigurarBuscador();
            dtpFecha.Value = DateTime.Today;
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 999;
            nudCantidad.Value = 1;
            OcultarPaneles();
            dgvDetProductos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 245, 220);
            dgvDetProductos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        #endregion

        #region Helpers paneles
        private void OcultarPaneles()
        {
            pnlDetalle.Visible = false;
            pnlAlta.Visible = false;
            dgvPedidos.Size = new System.Drawing.Size(1040, 560);
            lblAyuda.Location = new System.Drawing.Point(12, dgvPedidos.Bottom + 4);
        }

        private void MostrarPanelDetalle()
        {
            pnlAlta.Visible = false;
            dgvPedidos.Size = new System.Drawing.Size(1040, 270);
            lblAyuda.Location = new System.Drawing.Point(12, dgvPedidos.Bottom + 4);
            pnlDetalle.Location = new System.Drawing.Point(10, lblAyuda.Bottom + 4);
            pnlDetalle.Visible = true;
            pnlDetalle.BringToFront();
        }

        private void MostrarPanelAlta()
        {
            pnlDetalle.Visible = false;
            dgvPedidos.Size = new System.Drawing.Size(1040, 270);
            lblAyuda.Location = new System.Drawing.Point(12, dgvPedidos.Bottom + 4);
            pnlAlta.Location = new System.Drawing.Point(10, lblAyuda.Bottom + 4);
            pnlAlta.Visible = true;
        }
        #endregion

        #region Carga de datos
        private void CargarClientes()
        {
            try
            {
                cboCliente.Items.Clear();
                foreach (var c in logica.ObtenerClientes())
                    cboCliente.Items.Add(c);
                cboCliente.Items.Add("+ Agregar nuevo cliente");
                cboCliente.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                lstProductos.Items.Clear();
                foreach (var p in logica.ObtenerProductos())
                    lstProductos.Items.Add(p);
                lstProductos.DisplayMember = "Display";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPedidos()
        {
            try
            {
                dgvPedidos.Rows.Clear();
                foreach (var p in logica.ObtenerPedidos())
                {
                    dgvPedidos.Rows.Add(p.Id.ToString(), p.Cliente,
                        p.Productos, p.Fecha, p.Estado);

                    if (p.Estado == "Cancelado")
                    {
                        int i = dgvPedidos.Rows.Count - 1;
                        dgvPedidos.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                        dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Doble clic en grilla → Panel Detalle
        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (e.RowIndex < 0) return;

                _idPedidoDetalle = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
                string cliente = dgvPedidos.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string productos = dgvPedidos.Rows[e.RowIndex].Cells[2].Value?.ToString();
                string fecha = dgvPedidos.Rows[e.RowIndex].Cells[3].Value?.ToString();
                string estado = dgvPedidos.Rows[e.RowIndex].Cells[4].Value?.ToString();

                lblDetNroPedido.Text = $"Detalle del Pedido #{_idPedidoDetalle}";
                txtDetCliente.Text = cliente;
                txtDetFecha.Text = fecha;
                txtDetEstado.Text = estado;
                txtDetEstado.ForeColor = estado == "Cancelado" ? Color.DarkRed :
                                         estado == "Pendiente" ? Color.DarkGoldenrod :
                                         Color.DarkGreen;

                dgvDetProductos.Rows.Clear();
                if (!string.IsNullOrEmpty(productos))
                {
                    foreach (var item in productos.Split(','))
                    {
                        string prod = item.Trim();
                        if (string.IsNullOrEmpty(prod)) continue;
                        string nombre = prod;
                        string cantidad = "-";
                        int idx = prod.LastIndexOf(" x");
                        if (idx > 0)
                        {
                            nombre = prod.Substring(0, idx).Trim();
                            cantidad = prod.Substring(idx + 2).Trim();
                        }
                        dgvDetProductos.Rows.Add(nombre, cantidad);
                    }
                }

                bool puedeCancel = estado == "Pendiente" || estado == "En preparación";
                bool puedeFacturar = estado == "Pendiente";
                btnFacturacion.Enabled = puedeFacturar;
                btnFacturacion.BackColor = puedeFacturar ?
                    Color.FromArgb(46, 125, 50) : Color.Gray;

                btnCancelarPedido.Enabled = puedeCancel;
                btnCancelarPedido.BackColor = puedeCancel ?
                    Color.FromArgb(155, 28, 28) : Color.Gray;

                // ← Limpiar selección azul del DGV
                dgvPedidos.ClearSelection();
                dgvDetProductos.ClearSelection();

                MostrarPanelDetalle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error en detalle",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Acciones del panel detalle
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                $"¿Cancelar el pedido #{_idPedidoDetalle} de {txtDetCliente.Text}?",
                "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    logica.CancelarPedido(_idPedidoDetalle, txtDetEstado.Text);
                    MessageBox.Show("Pedido cancelado. El stock fue restaurado.",
                        "Cancelación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OcultarPaneles();
                    CargarPedidos();
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            string nro = _idPedidoDetalle.ToString();
            string cliente = txtDetCliente.Text;
            string productos = string.Join(", ", ObtenerProductosDetalle());
            string fecha = txtDetFecha.Text;
            string estado = txtDetEstado.Text;

            string ruta = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                $"Comprobante_Pedido_{nro}.pdf");

            try
            {
                PdfDocument doc = new PdfDocument();
                PdfWriter.GetInstance(doc, new System.IO.FileStream(ruta, System.IO.FileMode.Create));
                doc.Open();

                PdfFont fuenteTitulo = new PdfFont(PdfFont.FontFamily.HELVETICA, 18f,
                    PdfFont.BOLD, new BaseColor(34, 139, 34));
                PdfFont fuenteNormal = new PdfFont(PdfFont.FontFamily.HELVETICA, 11f);
                PdfFont fuenteBold = new PdfFont(PdfFont.FontFamily.HELVETICA, 11f, PdfFont.BOLD);

                doc.Add(new Paragraph("AviGestión - Avícola Don José", fuenteTitulo));
                doc.Add(new Paragraph("Comprobante de Pedido", fuenteBold));
                doc.Add(new Paragraph("─────────────────────────────────"));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"N° Pedido:   #{nro}", fuenteNormal));
                doc.Add(new Paragraph($"Cliente:     {cliente}", fuenteNormal));
                doc.Add(new Paragraph($"Productos:   {productos}", fuenteNormal));
                doc.Add(new Paragraph($"Fecha:       {fecha}", fuenteNormal));
                doc.Add(new Paragraph($"Estado:      {estado}", fuenteNormal));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("─────────────────────────────────"));
                doc.Add(new Paragraph($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm}", fuenteNormal));
                doc.Close();

                MessageBox.Show("Comprobante generado en el escritorio.",
                    "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo(ruta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObtenerProductosDetalle()
        {
            var lista = new List<string>();
            foreach (DataGridViewRow fila in dgvDetProductos.Rows)
            {
                string prod = fila.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(prod)) lista.Add(prod);
            }
            return lista;
        }

        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
        }
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // FrmPedidos vive dentro del panel del menú, así que ParentForm es el FormMenu
            FormMenu menu = this.ParentForm as FormMenu;
            if (menu != null)
                menu.AbrirPantalla("Facturación");
        }
        #endregion

        #region Panel Alta
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            cboCliente.SelectedIndex = -1;
            dgvProductosPedido.Rows.Clear();
            _codigoPorNombre.Clear();
            nudCantidad.Value = 1;
            dtpFecha.Value = DateTime.Today;
            MostrarPanelAlta();
            cboCliente.Focus();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem?.ToString() == "+ Agregar nuevo cliente")
            {
                Form principal = this.TopLevelControl as Form ?? this;

                // Capa oscura semitransparente sobre toda la pantalla, para que el historial "flote" encima
                using (Form velo = new Form())
                {
                    velo.FormBorderStyle = FormBorderStyle.None;
                    velo.BackColor = Color.Black;
                    velo.Opacity = 0.45;
                    velo.ShowInTaskbar = false;
                    velo.StartPosition = FormStartPosition.Manual;
                    velo.Bounds = principal.Bounds;
                    velo.Show(principal);

                    using (FrmAgregarCliente frmAlta = new FrmAgregarCliente())
                    {
                        if (frmAlta.ShowDialog() == DialogResult.OK)
                        {
                            CargarClientes();
                            cboCliente.SelectedItem = frmAlta.NuevoClienteNombre;
                        }
                        else
                            cboCliente.SelectedIndex = -1;
                        
                    }
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.", "Campo obligatorio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductoItem prod = (ProductoItem)lstProductos.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > prod.Stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {prod.Stock} cajones.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
            {
                if (fila.Cells[0].Value?.ToString() == prod.Nombre)
                {
                    MessageBox.Show("Ese producto ya fue agregado.",
                        "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            _codigoPorNombre[prod.Nombre] = prod.Codigo;
            dgvProductosPedido.Rows.Add(prod.Nombre, cantidad,
                (prod.Stock - cantidad) + " cajones", "✕ Quitar");

            nudCantidad.Value = 1;
            lstProductos.ClearSelected();
            ActualizarStockListbox();
        }

        private void ActualizarStockListbox()
        {
            var productosActuales = logica.ObtenerProductos();
            foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
            {
                string nombreProd = fila.Cells[0].Value?.ToString();
                int cantPedida = Convert.ToInt32(fila.Cells[1].Value);
                var prod = productosActuales.Find(p => p.Nombre == nombreProd);
                if (prod != null) prod.Stock -= cantPedida;
            }
            lstProductos.Items.Clear();
            foreach (var p in productosActuales)
                lstProductos.Items.Add(p);
            lstProductos.DisplayMember = "Display";
        }

        private void dgvProductosPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string nombre = dgvProductosPedido.Rows[e.RowIndex].Cells[0].Value?.ToString();
                _codigoPorNombre.Remove(nombre);
                dgvProductosPedido.Rows.RemoveAt(e.RowIndex);
                ActualizarStockListbox();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem == null ||
                cboCliente.SelectedItem.ToString() == "+ Agregar nuevo cliente")
            {
                MessageBox.Show("Seleccioná un cliente.", "Campo obligatorio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvProductosPedido.Rows.Count == 0)
            {
                MessageBox.Show("Agregá al menos un producto.", "Campo obligatorio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClienteItem cliente = (ClienteItem)cboCliente.SelectedItem;
                var productos = new List<(string Codigo, int Cantidad)>();
                string prodTexto = "";

                foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
                {
                    string nombre = fila.Cells[0].Value?.ToString();
                    int cantidad = Convert.ToInt32(fila.Cells[1].Value);
                    string codigo = _codigoPorNombre[nombre];
                    productos.Add((codigo, cantidad));
                    prodTexto += $"{nombre} x{cantidad}, ";
                }

                int idPedido = logica.RegistrarPedido(cliente.Id, dtpFecha.Value, productos);
                prodTexto = prodTexto.TrimEnd(',', ' ');

                MessageBox.Show("Pedido registrado exitosamente con estado Pendiente.",
                    "Pedido registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OcultarPaneles();
                _codigoPorNombre.Clear();
                CargarPedidos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            _codigoPorNombre.Clear();
            OcultarPaneles();
        }

        #endregion

        #region Búsqueda
        private void ConfigurarBuscador()
        {
            txtBuscar.Text = SUGERENCIA;
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == SUGERENCIA) { txtBuscar.Text = ""; txtBuscar.ForeColor = Color.Black; }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = SUGERENCIA; txtBuscar.ForeColor = Color.Gray; }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text == SUGERENCIA ? "" : txtBuscar.Text.Trim().ToLower();
            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                if (fila.IsNewRow) continue;
                string nro = fila.Cells[0].Value?.ToString().ToLower() ?? "";
                string cli = fila.Cells[1].Value?.ToString().ToLower() ?? "";
                string prod = fila.Cells[2].Value?.ToString().ToLower() ?? "";
                string fec = fila.Cells[3].Value?.ToString().ToLower() ?? "";
                string est = fila.Cells[4].Value?.ToString().ToLower() ?? "";
                fila.Visible = nro.Contains(busqueda) || cli.Contains(busqueda) || prod.Contains(busqueda)
                            || fec.Contains(busqueda) || est.Contains(busqueda);
            }
        }
        #endregion
    }
}