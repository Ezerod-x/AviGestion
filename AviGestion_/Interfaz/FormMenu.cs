using AviGestion;
using AviGestion_.Interfaz;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    public partial class FormMenu : Form
    {
        #region Campos y constructor
        private Usuario usuarioActual;
        private Form pantallaActual;                  // pantalla abierta en el panel central (null = inicio)
        private const string TITULO_INICIO = "Menú Principal - Sistema AviGestión";

        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            WindowState = FormWindowState.Maximized;
            AgregarBotonCerrarSesion();
            CrearTitulosDeSeccion();
            ConfigurarVisibilidadPorRol();
            lblUsuario.Text = usuarioActual.Nombre + " · " + usuarioActual.Rol;
            MostrarInicio();
        }
        #endregion

        #region Permisos por rol (igual que antes; con FlowLayoutPanel ya no quedan huecos)
        private void ConfigurarVisibilidadPorRol()
        {
            // Por defecto, ocultamos todo excepto Inicio y Ayuda (que ven todos)
            lblStockTitulo.Visible = true;
            btnInicio.Visible = true;
            btnClientes.Visible = false;
            btnUsuarios.Visible = false;
            btnPedidos.Visible = false;
            btnProductos.Visible = false;
            btnAsignarPedidos.Visible = false;
            btnStock.Visible = false;
            btnCategorias.Visible = false;
            btnVehiculos.Visible = false;
            btnBitacora.Visible = false;
            btnBackup.Visible = false;
            btnFacturacion.Visible = false;
            btnRegistrarPago.Visible = false;
            btnAyuda.Visible = true;
            lblProductosDescripcion.Visible = false;
            lblStockDescripcion.Visible = false;

            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    lblSecAdministracion.Visible = true;
                    btnClientes.Visible = true;
                    btnUsuarios.Visible = true;
                    btnStock.Visible = false;
                    btnFacturacion.Visible = true;
                    btnRegistrarPago.Visible = true;
                    btnBitacora.Visible = true;
                    btnBackup.Visible = true;
                    break;

                case "Administrador de pedidos":
                    lblSecVentas.Visible = true;
                    btnPedidos.Visible = true;
                    break;

                case "Jefe de Deposito":
                    lblSecDeposito.Visible = true;
                    btnProductos.Visible = true;
                    btnAsignarPedidos.Visible = true;
                    btnVehiculos.Visible = true;
                    btnStock.Visible = true;
                    btnCategorias.Visible = true;
                    lblProductosDescripcion.Visible = true;
                    lblStockDescripcion.Visible = true;
                    break;
            }

            ActualizarSecciones();
        }

        // Cada título con los botones que agrupa
        private readonly List<KeyValuePair<Label, Control[]>> secciones =
            new List<KeyValuePair<Label, Control[]>>();

        //Crea los títulos de sección y los inserta en flpSidebar justo antes del primer botón de cada grupo.
        private void CrearTitulosDeSeccion()
        {
            AgregarTitulo("VENTAS", btnClientes, btnPedidos, btnFacturacion, btnRegistrarPago);
            AgregarTitulo("DEPÓSITO", btnProductos, btnAsignarPedidos, btnStock, btnCategorias, btnVehiculos);
            AgregarTitulo("ADMINISTRACIÓN", btnUsuarios, btnBitacora, btnBackup);
            AgregarTitulo("SISTEMA", btnAyuda);
        }

        private void AgregarTitulo(string texto, params Control[] botones)
        {
            var lbl = new Label
            {
                Text = texto,
                AutoSize = false,
                Width = 200,
                Height = 22,
                TextAlign = ContentAlignment.BottomLeft,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.Gray,
                Margin = new Padding(0, 10, 0, 2)
            };
            flpSidebar.Controls.Add(lbl);
            flpSidebar.Controls.SetChildIndex(lbl, flpSidebar.Controls.GetChildIndex(botones[0]));
            secciones.Add(new KeyValuePair<Label, Control[]>(lbl, botones));
        }

        // Muestra el título solo si al menos uno de sus botones es visible para el rol
        private void ActualizarSecciones()
        {
            foreach (var s in secciones)
                s.Key.Visible = s.Value.Any(b => b.Visible);
        }
        #endregion

        #region Botones del menú (cada uno abre su pantalla dentro del panel central)
        private void btnInicio_Click(object sender, EventArgs e) { MostrarInicio(); }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormClientes(usuarioActual), "Gestión de Clientes", btnClientes);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormUsuarios(usuarioActual), "Gestión de Usuarios", btnUsuarios);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmPedidos(), "Gestión de Pedidos", btnPedidos);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormProducto(usuarioActual), "Gestión de Productos", btnProductos);
        }
       
        private void btnAsignarPedidos_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormAsignarPedidos(usuarioActual), "Asignar Pedidos", btnAsignarPedidos);
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormCargaStock(usuarioActual), "Stock e Inventario", btnStock);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmCategorias(), "Gestión de Categorías", btnCategorias);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormVehiculo(usuarioActual), "Gestión de Vehículos", btnVehiculos);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormFacturacion(usuarioActual), "Facturación y Despacho de Pedidos", btnFacturacion);
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormRegistrarPago(usuarioActual), "Registrar Pago", btnRegistrarPago);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormBitacora(usuarioActual), "Bitácora", btnBitacora);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FormBackup(usuarioActual), "Backup", btnBackup);
        }
        #endregion

        #region Pantallas incrustadas en el área central
        /// Muestra un formulario dentro de pnlContenido (no como ventana aparte), cambia el título
        /// del header por el de la gestión y resalta el botón del menú.
        private void AbrirEnPanel(Form pantalla, string titulo, Control itemMenu)
        {
            CerrarPantalla();
            pantallaActual = pantalla;

            pantalla.TopLevel = false;                        // se muestra dentro de un panel
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.MaximumSize = Size.Empty;
            pantalla.AutoScroll = true;                       // si el espacio es chico, scroll en vez de cortarse
            pantalla.AutoScrollMinSize = pantalla.Size;       // tamaño original del diseño
            pantalla.Dock = DockStyle.Fill;
            OcultarEncabezadoPropio(pantalla);

            pnlContenido.Controls.Add(pantalla);
            pantalla.FormClosed += Pantalla_FormClosed;       // al cerrarse ("Atrás"), vuelve al inicio
            pantalla.Show();
            pantalla.BringToFront();

            lblTitulo.Text = titulo;
            Resaltar(itemMenu);
        }

        private void Pantalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender == pantallaActual)
            {
                pantallaActual = null;
                MostrarInicio();
            }
        }

        private void CerrarPantalla()
        {
            Form f = pantallaActual;
            pantallaActual = null;                            // evita que FormClosed dispare MostrarInicio
            if (f != null) { f.Close(); f.Dispose(); }
        }

        // Vuelve al panel de inicio: título original, sin botón resaltado y gráficos actualizados.
        private void MostrarInicio()
        {
            CerrarPantalla();
            lblTitulo.Text = TITULO_INICIO;
            Resaltar(null);
            CargarGraficos();
        }

        // Oculta el header propio del formulario
        // (Si se cambia los lbl del titulo/encabezado de cada form al nombre pnlEncabezado se oculta sin necesidad de borrarlo)
        //Ejemplo: FormClientes funciona asi
        private void OcultarEncabezadoPropio(Form pantalla)
        {
            Control encabezado = pantalla.Controls.Find("pnlEncabezado", true).FirstOrDefault();
            if (encabezado != null) encabezado.Visible = false;
        }
        #endregion

        #region Resaltado del botón activo
        private IEnumerable<Control> ItemsMenu()
        {
            return flpSidebar.Controls.Cast<Control>().Where(c => c.Name.StartsWith("btn"));
        }

        private void Resaltar(Control activo)
        {
            foreach (Control item in ItemsMenu())
            {
                bool esActivo = (item == activo);
                item.BackColor = esActivo ? Color.ForestGreen : Color.White;
                if (item is Button) item.ForeColor = esActivo ? Color.White : Color.ForestGreen;

                foreach (Label l in item.Controls.OfType<Label>())
                {
                    l.BackColor = Color.Transparent;
                    bool esDescripcion = l.Name.Contains("Descripcion");
                    l.ForeColor = esActivo ? Color.White : (esDescripcion ? Color.Gray : Color.ForestGreen);
                }
            }
        }
        #endregion

        #region Gráficos del inicio (por ahora vacío; se completa cuando decidan usarlos)
        private void CargarGraficos()
        {
            // Acá se llena pnlStockResumen, pnlGraficoPedidos y pnlGraficoProductos
            // con datos de la capa Logica (usando el PintarBarras del borrador).
        }
        #endregion

        #region Pantalla completa con F11
        protected override bool ProcessCmdKey(ref Message msg, Keys tecla)
        {
            if (tecla == Keys.F11 || (tecla == Keys.Escape && FormBorderStyle == FormBorderStyle.None))
            {
                bool completa = (FormBorderStyle == FormBorderStyle.None);
                WindowState = FormWindowState.Normal;         // truco: sin esto no cubre la barra de tareas
                FormBorderStyle = completa ? FormBorderStyle.Sizable : FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                return true;
            }
            return base.ProcessCmdKey(ref msg, tecla);
        }
        #endregion

        #region Cerrar sesión
        // Crea el botón "Cerrar Sesión" en la barra superior.
        // Si el Designer ya tiene un btnCerrarSesion, no hace nada.
        private void AgregarBotonCerrarSesion()
        {
            if (this.Controls.Find("btnCerrarSesion", true).Length > 0) return;

            var btn = new Button
            {
                Name = "btnCerrarSesion",
                Text = "Cerrar Sesión",
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.OliveDrab,
                Size = new Size(140, 27),
                Location = new Point(this.ClientSize.Width - 150, 4),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderColor = Color.White;
            btn.Click += btnCerrarSesion_Click;

            this.Controls.Add(btn);
            btn.BringToFront();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            BitacoraLogica.Registrar(usuarioActual.Nombre, "Cierre de Sesión", "Seguridad");

            CerrarPantalla();
            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.Show();
            this.Close();
        }
        #endregion

        #region Eventos vacíos (enlazados desde el Designer: no borrar sin quitar antes el enlace)
        private void btnUsuarios_Paint(object sender, PaintEventArgs e) { }
        private void btnProductos_Paint(object sender, PaintEventArgs e) { }
        private void btnCategorias_Paint(object sender, PaintEventArgs e) { }
        private void lblProductosTitulo_Click(object sender, EventArgs e) { }
        private void FormMenu_Load(object sender, EventArgs e) { }
        #endregion

        
    }
}