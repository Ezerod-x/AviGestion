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
        #region Campos y constantes
        private Usuario usuarioActual;
        private Form pantallaActual;                           // pantalla abierta en pnlContenido (null = inicio)
        private const string TITULO_INICIO = "Menú Principal - Sistema AviGestión";
        private static readonly Color VERDE = Color.FromArgb(46, 125, 50);

        // Marco alrededor de pnlContenido y límites de tamaño
        private const int MARGEN_X = 110, MARGEN_Y = 50;
        private const int MIN_ANCHO = 880, MIN_ALTO = 500;
        private const int MAX_ANCHO = 1100, MAX_ALTO = 640;
        #endregion

        #region Constructor
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            WindowState = FormWindowState.Maximized;

            pnlFondo.Resize += (s, e) => AjustarContenido();   // recentra el panel si cambia el tamaño de la ventana
            pnlContenido.Resize += (s, e) => DistribuirPanelesInicio();
            CrearGraficos();

            AgregarBotonCerrarSesion();
            ConstruirMenu();                                   // arma títulos y botones según el rol
            lblUsuario.Text = usuarioActual.Nombre + " · " + usuarioActual.Rol;
            AjustarContenido();
            MostrarInicio();
        }
        #endregion

        #region Menú lateral: una sola lista define qué ve cada rol
        private class ItemDeMenu
        {
            public string Seccion;        // título de la sección donde aparece
            public string Texto;          // texto del botón
            public string Etiqueta;       // texto chico a la derecha (opcional)
            public string Titulo;         // título del header al abrir la pantalla
            public string[] Roles;        // roles con acceso; null = todos
            public Func<Form> Crear;      // pantalla que abre (null si usa Accion)
            public Action Accion;         // para ítems que no abren una pantalla (Inicio, Ayuda)
            public Button Boton;          // se completa al construir el menú
        }

        private readonly List<ItemDeMenu> items = new List<ItemDeMenu>();

        // Define TODOS los accesos del sistema. Para cambiar quién ve qué, o para agregar una
        // pantalla nueva, se edita solo esta lista.
        private void DefinirItems()
        {
            string[] admin = { "Administrador" };
            string[] pedidos = { "Administrador de pedidos" };
            string[] deposito = { "Jefe de Deposito" };

            items.Clear();
            items.Add(new ItemDeMenu { Seccion = "INICIO", Texto = "Inicio", Accion = MostrarInicio });

            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Clientes", Titulo = "Gestión de Clientes", Roles = pedidos, Crear = () => new FormClientes(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Pedidos", Titulo = "Gestión de Pedidos", Roles = pedidos, Crear = () => new FrmPedidos() });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Facturación", Titulo = "Facturación y Despacho de Pedidos", Roles = pedidos, Crear = () => new FormFacturacion(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Registrar Pagos", Titulo = "Registrar Pago", Roles = pedidos, Crear = () => new FormRegistrarPago(usuarioActual) });

            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Productos", Etiqueta = "catálogo", Titulo = "Gestión de Productos", Roles = deposito, Crear = () => new FormProducto(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Asignar Pedidos", Titulo = "Asignar Pedidos", Roles = deposito, Crear = () => new FormAsignarPedidos(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Stock", Etiqueta = "inventario", Titulo = "Stock e Inventario", Roles = deposito, Crear = () => new FormCargaStock(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Categorías", Titulo = "Gestión de Categorías", Roles = deposito, Crear = () => new FrmCategorias() });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Vehículos", Titulo = "Gestión de Vehículos", Roles = deposito, Crear = () => new FormVehiculo(usuarioActual) });

            items.Add(new ItemDeMenu { Seccion = "ADMINISTRACIÓN", Texto = "Usuarios", Titulo = "Gestión de Usuarios", Roles = admin, Crear = () => new FormUsuarios(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "ADMINISTRACIÓN", Texto = "Bitácora", Titulo = "Bitácora", Roles = admin, Crear = () => new FormBitacora(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "ADMINISTRACIÓN", Texto = "Backup", Titulo = "Backup", Roles = admin, Crear = () => new FormBackup(usuarioActual) });

            items.Add(new ItemDeMenu { Seccion = "SISTEMA", Texto = "Cambiar contraseña", Accion = AbrirCambiarContrasena });
            items.Add(new ItemDeMenu { Seccion = "SISTEMA", Texto = "Ayuda", Accion = () => MessageBox.Show("Ayuda en construcción.", "AviGestión") });
        }

        //Indica si el usuario actual puede ver y usar el ítem (Roles == null significa "todos").
        private bool TieneAcceso(ItemDeMenu item)
        {
            if (item.Roles == null) return true;
            string rol = (usuarioActual.Rol ?? "").Trim();
            return item.Roles.Contains(rol, StringComparer.OrdinalIgnoreCase);
        }

        //Arma el menú lateral: crea solo los botones permitidos y, antes de cada grupo, su título.
        // Una sección sin botones permitidos no genera ni el título. Se puede volver a llamar si cambia el rol.
        private void ConstruirMenu()
        {
            DefinirItems();
            flpSidebar.SuspendLayout();
            flpSidebar.Controls.Clear();

            foreach (var grupo in items.Where(TieneAcceso).GroupBy(i => i.Seccion))   // respeta el orden de la lista
            {
                flpSidebar.Controls.Add(CrearTitulo(grupo.Key));
                foreach (var item in grupo)
                {
                    item.Boton = CrearBoton(item);
                    flpSidebar.Controls.Add(item.Boton);
                }
            }
            flpSidebar.ResumeLayout();
        }

        private Label CrearTitulo(string texto)
        {
            return new Label
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
        }

        private Button CrearBoton(ItemDeMenu item)
        {
            var b = new Button
            {
                Text = item.Texto,
                Width = 200,
                Height = 34,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = VERDE,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 6),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            b.FlatAppearance.BorderColor = Color.DimGray;
            b.Click += (s, e) => AbrirItem(item);

            if (!string.IsNullOrEmpty(item.Etiqueta))                  // "catálogo", "inventario"
                b.Paint += (s, e) =>
                {
                    Color c = (b.ForeColor == Color.White) ? Color.FromArgb(220, 240, 220) : Color.Gray;
                    using (var f = new Font("Segoe UI", 8F))
                        TextRenderer.DrawText(e.Graphics, item.Etiqueta, f,
                            new Rectangle(0, 0, b.Width - 10, b.Height), c,
                            TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                };
            return b;
        }

        //Clic en un botón: verifica el permiso otra vez y abre la pantalla o ejecuta la acción.
        private void AbrirItem(ItemDeMenu item)
        {
            if (!TieneAcceso(item)) return;                            // doble control de seguridad
            if (item.Crear != null) AbrirEnPanel(item.Crear(), item.Titulo ?? item.Texto, item.Boton);
            else if (item.Accion != null) item.Accion();
        }

        // Cambio de contraseña del usuario con sesión iniciada: se abre como ventana modal.
        private void AbrirCambiarContrasena()
        {
            using (FrmCambiarContrasena frm = new FrmCambiarContrasena(usuarioActual))
            {
                frm.ShowDialog(this);
            }
        }

        // Permite que una pantalla pida abrir otra del menú (se usa para: Pedidos -> Facturación)
        public void AbrirPantalla(string textoDelMenu)
        {
            ItemDeMenu item = items.Find(i => i.Texto == textoDelMenu);
            if (item != null) AbrirItem(item);
        }

        //Pinta de verde el botón de la pantalla abierta y deja los demás en blanco (null = ninguno).
        private void Resaltar(Control activo)
        {
            foreach (var item in items)
            {
                if (item.Boton == null) continue;
                bool on = (item.Boton == activo);
                item.Boton.BackColor = on ? VERDE : Color.White;
                item.Boton.ForeColor = on ? Color.White : VERDE;
                item.Boton.Invalidate();                               // repinta también la etiqueta chica
            }
        }
        #endregion

        #region Panel de fondo y panel de contenido
        // Calcula el tamaño de pnlContenido según el espacio libre (con un marco fijo para que se vea
        // el fondo decorativo, entre un mínimo y un máximo) y lo centra dentro de pnlFondo.
        private void AjustarContenido()
        {
            if (pnlFondo.ClientSize.Width <= 0 || pnlFondo.ClientSize.Height <= 0) return;

            int w = Math.Max(MIN_ANCHO, Math.Min(MAX_ANCHO, pnlFondo.ClientSize.Width - 2 * MARGEN_X));
            int h = Math.Max(MIN_ALTO, Math.Min(MAX_ALTO, pnlFondo.ClientSize.Height - 2 * MARGEN_Y));
            pnlContenido.Size = new Size(w, h);
            pnlContenido.Location = new Point(
                Math.Max(0, (pnlFondo.ClientSize.Width - w) / 2),
                Math.Max(0, (pnlFondo.ClientSize.Height - h) / 2));
        }
        #endregion

        #region Pantallas incrustadas en el panel de contenido
        //Muestra un formulario dentro de pnlContenido (no como ventana aparte), cambia el título
        // del header por el de la gestión y resalta el botón del menú.
        private void AbrirEnPanel(Form pantalla, string titulo, Control botonMenu)
        {
            CerrarPantalla();
            pantallaActual = pantalla;

            pantalla.TopLevel = false;                                 // se muestra dentro de un panel
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.MaximumSize = Size.Empty;
            pantalla.AutoScroll = true;                                // si el espacio es chico, scroll en vez de cortarse
            pantalla.AutoScrollMinSize = pantalla.Size;                // tamaño original del diseño
            pantalla.Dock = DockStyle.Fill;
            OcultarEncabezadoPropio(pantalla);

            MostrarPanelesInicio(false);                          // oculta los gráficos del inicio
            pnlContenido.Controls.Add(pantalla);
            pantalla.FormClosed += Pantalla_FormClosed;                // al cerrarse, vuelve al inicio
            pantalla.Show();
            pantalla.BringToFront();

            lblTitulo.Text = titulo;
            Resaltar(botonMenu);
        }

        // Cuando se cierra la pantalla incrustada, vuelve al inicio.
        private void Pantalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender == pantallaActual)
            {
                pantallaActual = null;
                MostrarInicio();
            }
        }

        // Cierra la pantalla incrustada (si hay alguna) y libera sus recursos.
        private void CerrarPantalla()
        {
            Form f = pantallaActual;
            pantallaActual = null;                                     // evita que FormClosed dispare MostrarInicio
            if (f != null) { f.Close(); f.Dispose(); }
        }

        //Vuelve al panel de inicio: título original, sin botón resaltado y gráficos actualizados.
        private void MostrarInicio()
        {
            CerrarPantalla();
            MostrarPanelesInicio(true);
            lblTitulo.Text = TITULO_INICIO;
            Resaltar(null);
            CargarGraficos();
        }

        // Oculta el header propio del formulario (el panel que se llame "pnlEncabezado")
        private void OcultarEncabezadoPropio(Form pantalla)
        {
            Control encabezado = pantalla.Controls.Find("pnlEncabezado", true).FirstOrDefault();
            if (encabezado != null) encabezado.Visible = false;
        }
        #endregion

        #region Paneles del inicio 
        //Muestra u oculta los tres paneles del inicio.
        private void MostrarPanelesInicio(bool visible)
        {
            pnlStockResumen.Visible = visible;
            pnlGraficoPedidos.Visible = visible;
            pnlGraficoProductos.Visible = visible;
        }

        //Reparte los tres paneles: stock arriba (ancho completo) y los otros dos abajo, lado a lado.
        private void DistribuirPanelesInicio()
        {
            const int P = 10;                                          // separación entre paneles
            int ancho = pnlContenido.ClientSize.Width - 2 * P;
            int alto = pnlContenido.ClientSize.Height - 2 * P;
            if (ancho <= 0 || alto <= 0) return;

            int altoSup = (int)(alto * 0.36);
            int altoInf = alto - altoSup - P;
            int mitad = (ancho - P) / 2;

            pnlStockResumen.SetBounds(P, P, ancho, altoSup);
            pnlGraficoPedidos.SetBounds(P, 2 * P + altoSup, mitad, altoInf);
            pnlGraficoProductos.SetBounds(2 * P + mitad, 2 * P + altoSup, ancho - mitad - P, altoInf);
        }
        #endregion

        #region Gráficos del inicio
        private const bool USAR_DATOS_DEMO = false;        // false = usa la base de datos | true= usa datos de ejemplo (para probar sin base)
        private GraficoBarras grafStock, grafPedidos, grafProductos;
        private readonly GraficosInicioLogica dashboard = new GraficosInicioLogica();

        //Crea las tres gráficas y las coloca debajo del título de cada panel.
        private void CrearGraficos()
        {
            grafStock = new GraficoBarras { MostrarLimites = true, Columnas = 2 };
            grafPedidos = new GraficoBarras();
            grafProductos = new GraficoBarras { ColorBarra = Color.SeaGreen };

            ColocarGrafico(pnlStockResumen, grafStock);
            ColocarGrafico(pnlGraficoPedidos, grafPedidos);
            ColocarGrafico(pnlGraficoProductos, grafProductos);
        }

        private void ColocarGrafico(Panel panel, GraficoBarras grafico)
        {
            grafico.SetBounds(10, 44, panel.ClientSize.Width - 20, panel.ClientSize.Height - 54);   // 44 px = alto del título
            grafico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Controls.Add(grafico);
        }

        //Carga los datos en las tres gráficas. Si falla la base, el menú no se cae: muestra un aviso.
        private void CargarGraficos()
        {
            try
            {
                grafStock.Datos = ObtenerStock();
                grafPedidos.Datos = ObtenerPedidosPorCliente();
                grafProductos.Datos = ObtenerProductosVendidos();
            }
            catch (Exception)
            {
                foreach (GraficoBarras g in new[] { grafStock, grafPedidos, grafProductos })
                {
                    g.Datos = new List<ItemGrafico>();
                    g.TextoVacio = "No se pudieron cargar los datos.";
                }
            }
            grafStock.Invalidate();
            grafPedidos.Invalidate();
            grafProductos.Invalidate();
        }

        private static ItemGrafico ItemStock(string nombre, int stock, int min, int max)
        {
            return new ItemGrafico { Nombre = nombre, Valor = stock, Minimo = min, Maximo = max, Texto = stock + "/" + max };
        }

        private List<ItemGrafico> ObtenerStock()
        {
            if (USAR_DATOS_DEMO)
                return new List<ItemGrafico>
            {
                ItemStock("Huevo B1", 120, 40, 200), ItemStock("Huevo B2", 35, 40, 200),
                ItemStock("Huevo C1", 150, 30, 150), ItemStock("Pollo entero", 90, 30, 160),
                ItemStock("Pollo trozado", 15, 25, 100), ItemStock("Huevo SUP", 60, 20, 100)
            };

            return dashboard.StockActivo()
                .Select(p => ItemStock(p.Descripcion, p.Stock, p.StockMinimo, p.StockMaximo))
                .ToList();
        }

        private List<ItemGrafico> ObtenerPedidosPorCliente()
        {
            if (USAR_DATOS_DEMO)
                return new List<ItemGrafico>
            {
                new ItemGrafico { Nombre = "Almacén El Sol", Valor = 5 },
                new ItemGrafico { Nombre = "Rotisería Don Pepe", Valor = 3 },
                new ItemGrafico { Nombre = "Granja Los Aromos", Valor = 2 }
            };

            return dashboard.PedidosPorCliente()
                .Select(kv => new ItemGrafico { Nombre = kv.Key, Valor = kv.Value })
                .ToList();
        }

        private List<ItemGrafico> ObtenerProductosVendidos()
        {
            // Pendiente: falta el procedimiento SP_ProductosVendidos (ver mensaje anterior). Por ahora, ejemplo.
            return new List<ItemGrafico>
            {
                new ItemGrafico { Nombre = "Pollo entero", Valor = 30 },
                new ItemGrafico { Nombre = "Huevo C1", Valor = 25 },
                new ItemGrafico { Nombre = "Huevo B1", Valor = 20 }
            };
        }
        #endregion

        #region Pantalla completa con F11
        protected override bool ProcessCmdKey(ref Message msg, Keys tecla)
        {
            if (tecla == Keys.F11 || (tecla == Keys.Escape && FormBorderStyle == FormBorderStyle.None))
            {
                bool completa = (FormBorderStyle == FormBorderStyle.None);
                WindowState = FormWindowState.Normal;                  // truco: sin esto no cubre la barra de tareas
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
                BackColor = VERDE,
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

        #region Evento enlazado desde el Designer (dejar vacío)
        private void FormMenu_Load(object sender, EventArgs e) { }
        #endregion

    }
}