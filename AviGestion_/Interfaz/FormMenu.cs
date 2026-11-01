using AviGestion;
using AviGestion_.Interfaz;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private const int MIN_ANCHO = 700, MIN_ALTO = 450;
        private const int MAX_ANCHO = 1300, MAX_ALTO = 700;

        private const int MARGEN_MIN_X = 8;      // margen mínimo a los lados cuando una pantalla necesita lugar
        private const int MARGEN_MIN_Y = 5;      // margen mínimo arriba y abajo
        private Size tamanoDeseado = Size.Empty;           // tamaño de diseño de la pantalla abierta (vacío = inicio)

        private const int ANCHO_BOTON = 170;     // ancho de botones y títulos del menú lateral
        private const int PAD_MENU = 8;          // margen interno de flpSidebar
        #endregion

        #region Constructor
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            flpSidebar.Padding = new Padding(PAD_MENU);
            pnlSidebar.Width = ANCHO_BOTON + 2 * PAD_MENU + SystemInformation.VerticalScrollBarWidth;   // 170 + 16 + 17 = 203
            pnlFondo.AutoScroll = true;

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
            items.Add(new ItemDeMenu { Texto = "Inicio", Accion = MostrarInicio });

            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Clientes", Titulo = "Gestión de Clientes", Roles = pedidos, Crear = () => new FormClientes(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Pedidos", Titulo = "Gestión de Pedidos", Roles = pedidos, Crear = () => new FrmPedidos() });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Facturación", Titulo = "Facturación y Despacho de Pedidos", Roles = pedidos, Crear = () => new FormFacturacion(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "VENTAS", Texto = "Registrar Pagos", Titulo = "Registrar Pago", Roles = pedidos, Crear = () => new FormRegistrarPago(usuarioActual) });

            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Productos", Etiqueta = "catálogo", Titulo = "Gestión de Productos", Roles = deposito, Crear = () => new FormProducto(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Asignar Pedidos", Titulo = "Asignar Pedidos", Roles = deposito, Crear = () => new FormAsignarPedidos(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Stock", Etiqueta = "inventario", Titulo = "Stock e Inventario", Roles = deposito, Crear = () => new FormCargaStock(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Alertas", Etiqueta = "stock", Titulo = "Gestión de Alertas", Roles = deposito, Crear = () => new FormAlertas(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Categorías", Titulo = "Gestión de Categorías", Roles = deposito, Crear = () => new FrmCategorias() });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Vehículos", Titulo = "Gestión de Vehículos", Roles = deposito, Crear = () => new FormVehiculo(usuarioActual) });
            items.Add(new ItemDeMenu { Seccion = "DEPÓSITO", Texto = "Entregas", Titulo = "Registrar Entregas", Roles = deposito, Crear = () => new FormControlEntregas(usuarioActual) });

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
                Width = ANCHO_BOTON,
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
                Width = ANCHO_BOTON,
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
            Form principal = this.TopLevelControl as Form ?? this;

            // Capa oscura semitransparente sobre toda la pantalla
            using (Form velo = new Form())
            {
                velo.FormBorderStyle = FormBorderStyle.None;
                velo.BackColor = Color.Black;
                velo.Opacity = 0.45;
                velo.ShowInTaskbar = false;
                velo.StartPosition = FormStartPosition.Manual;
                velo.Bounds = principal.Bounds;
                velo.Show(principal);

                using (FrmCambiarContrasena frm = new FrmCambiarContrasena(usuarioActual))
                {
                    frm.ShowDialog(this);
                }
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
        // Calcula el tamaño de pnlContenido. En el inicio usa el tamaño estándar con marco para el fondo.
        // Con una pantalla abierta, se adapta a su tamaño de diseño sin pasarse del espacio libre.

        private void AjustarContenido()
        {
            if (pnlFondo.AutoScroll)
            {
                pnlFondo.AutoScrollPosition = new Point(0, 0);
            }

            int dispW = pnlFondo.ClientSize.Width, dispH = pnlFondo.ClientSize.Height;
            if (dispW <= 0 || dispH <= 0) return;

            int w, h;
            if (tamanoDeseado.IsEmpty)
            {
                // Estado de inicio tradicional
                w = Math.Max(MIN_ANCHO, Math.Min(MAX_ANCHO, dispW - 2 * MARGEN_X));
                h = Math.Max(MIN_ALTO, Math.Min(MAX_ALTO, dispH - 2 * MARGEN_Y));
            }
            else
            {
                // El panel toma las dimensiones nativas exactas solicitadas por la pantalla + la holgura
                w = tamanoDeseado.Width;
                h = tamanoDeseado.Height;

                // Si el ANCHO supera al monitor, se limita para que no tape el menú lateral
                if (w > dispW - 2 * MARGEN_MIN_X)
                {
                    w = dispW - 2 * MARGEN_MIN_X;
                }

                // Si el ALTO supera al monitor no se recorta
                // Se mantiene su altura completa para que 'pnlFondo' active la barra de scroll.
                // Solo se recorta si superara el máximo histórico configurado (MAX_ALTO)
                if (h > MAX_ALTO)
                {
                    h = MAX_ALTO;
                }
            }

            pnlContenido.Size = new Size(w, h);

            // Centrado geométrico perfecto en el fondo de la aplicación
            int contenedorW = pnlFondo.ClientSize.Width;
            int contenedorH = pnlFondo.ClientSize.Height;

            // Si la pantalla es más alta que el monitor, la posición 'Y' arranca arriba de todo (MARGEN_MIN_Y)
            // para que el usuario pueda empezar a leer desde el principio y hacer scroll hacia abajo.
            int posY = (contenedorH > h) ? (contenedorH - h) / 2 : MARGEN_MIN_Y;

            pnlContenido.Location = new Point(
                Math.Max(MARGEN_MIN_X, (contenedorW - w) / 2),
                posY
            );

            if (pantallaActual != null)
            {
                pantallaActual.Size = pnlContenido.ClientSize;
            }
        }

        #endregion

        #region Pantallas incrustadas en el panel de contenido
        //Muestra un formulario dentro de pnlContenido (no como ventana aparte), cambia el título
        // del header por el de la gestión y resalta el botón del menú.
        private void AbrirEnPanel(Form pantalla, string titulo, Control botonMenu)
        {
            // Esto fuerza a Windows a dibujar la pantalla en memoria antes de mostrarla, eliminando el lag.
            typeof(Form).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, pantalla, new object[] { true });

            pnlContenido.SuspendLayout();
            pnlFondo.SuspendLayout();

            if (pnlFondo.AutoScroll)
            {
                pnlFondo.AutoScrollPosition = new Point(0, 0);
            }
            CerrarPantalla();
            pantallaActual = pantalla;

            Size disenio = pantalla.ClientSize;                       

            pantalla.TopLevel = false;
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.MaximumSize = Size.Empty;
            pantalla.AutoScroll = true;                                // si el espacio es chico, scroll en vez de cortarse
            pantalla.AutoScrollMinSize = pantalla.Size;                // tamaño original del diseño
            pantalla.Dock = DockStyle.Fill;
            OcultarEncabezadoPropio(pantalla);
            BloquearGrillas(pantalla);

            int altoEncabezado = OcultarEncabezadoPropio(pantalla);       // devuelve el alto que se liberó
            disenio.Height -= altoEncabezado;

            tamanoDeseado = new Size(disenio.Width, disenio.Height);      // el panel se adapta a la pantalla
            AjustarContenido();

            pantalla.AutoScroll = true;
            pantalla.Dock = DockStyle.None;
            pantalla.Location = new Point(0, 0);
            pantalla.Size = pnlContenido.ClientSize;                      // Toma exactamente el tamaño del panel calculado

            pnlContenido.Controls.Add(pantalla);
            pantalla.FormClosed += Pantalla_FormClosed;
            pantalla.Show();
            pantalla.BringToFront();

            lblTitulo.Text = titulo;
            Resaltar(botonMenu);
            pnlContenido.ResumeLayout(true);
            pnlFondo.ResumeLayout(true);
        }

        // Todas las grillas: una sola fila seleccionable y sin redimensionar ni mover filas o columnas
        private void BloquearGrillas(Control padre)
        {
            foreach (Control c in padre.Controls)
            {
                DataGridView dgv = c as DataGridView;
                if (dgv != null)
                {
                    dgv.MultiSelect = false;
                    dgv.AllowUserToResizeRows = false;
                    dgv.AllowUserToResizeColumns = false;
                    dgv.AllowUserToOrderColumns = false;
                }
                if (c.HasChildren) BloquearGrillas(c);
            }
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
            tamanoDeseado = Size.Empty;                //el inicio vuelve al tamaño estándar
            AjustarContenido();
            MostrarPanelesInicio(true);
            lblTitulo.Text = TITULO_INICIO;
            Resaltar(null);
            CargarGraficos();
        }

        // Oculta el header propio del formulario (el panel que se llame "pnlEncabezado")
        private int OcultarEncabezadoPropio(Form pantalla)
        {
            Control encabezado = pantalla.Controls.Find("pnlEncabezado", true).FirstOrDefault();
            if (encabezado == null) return 0;
            encabezado.Visible = false;
            return (encabezado.Dock == DockStyle.Top) ? encabezado.Height : 0;
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
            return dashboard.StockActivo()
                .Select(p => ItemStock(p.Descripcion, p.Stock, p.StockMinimo, p.StockMaximo))
                .ToList();
        }

        private List<ItemGrafico> ObtenerPedidosPorCliente()
        {
            return dashboard.PedidosPorCliente()
                .Select(kv => new ItemGrafico { Nombre = kv.Key, Valor = kv.Value })
                .ToList();
        }

        private List<ItemGrafico> ObtenerProductosVendidos()
        {
            return dashboard.ProductosVendidos()
                .Select(kv => new ItemGrafico { Nombre = kv.Key, Valor = kv.Value })
                .ToList();
        }
        #endregion

        #region Pantalla completa con F11
        protected override bool ProcessCmdKey(ref Message msg, Keys tecla)
        {
            if (tecla == Keys.F11 || (tecla == Keys.Escape && FormBorderStyle == FormBorderStyle.None))
            {
                bool completa = (FormBorderStyle == FormBorderStyle.None);
                WindowState = FormWindowState.Normal;                  
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

            BitacoraLogica.Registrar(usuarioActual.Nombre, "Cierre de Sesión", "Seguridad", "Cierre de sesión manual por el usuario.");

            CerrarPantalla();
            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.FormClosed += (s, args) => Application.Exit();
            login.Show();
            this.FormClosed -= FormMenu_FormClosed_Bitacora;
            this.Close();
        }

        // Captura el cierre abrupto desde la "X" del menú, registra en bitácora y apaga el sistema
        private void FormMenu_FormClosed_Bitacora(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Registra de forma automática la salida directa por la X del programa
                BitacoraLogica.Registrar(usuarioActual.Nombre, "Salida del Sistema", "Seguridad", "Cierre directo desde la ventana (X)");
            }
            catch
            {
                // Guarda de seguridad por si la base de datos ya se encuentra cerrada
            }
            finally
            {
                // Apaga por completo el proceso de fondo de manera segura
                Application.Exit();
            }
        }

        #endregion

        #region Evento enlazado desde el Designer (dejar vacío)
        private void FormMenu_Load(object sender, EventArgs e) { }
        #endregion

        #region Arreglo de Lag
        // Sobrescribe los parámetros de creación del formulario principal.
        // Activa el doble búfer total en la ventana para eliminar el lag de los controles.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Fuerza el dibujado completo en memoria antes de mostrarlo.
                return cp;
            }
        }
        #endregion

    }
}