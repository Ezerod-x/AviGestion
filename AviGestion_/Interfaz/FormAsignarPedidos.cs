using AviGestion;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormAsignarPedidos : Form
    {
        private readonly Usuario usuarioActual;
        private readonly AsignacionLogica logica = new AsignacionLogica();
        private DataTable vehiculos;

        private static readonly Color Verde = Color.FromArgb(46, 125, 50);
        private static readonly Color Rojo = Color.FromArgb(139, 0, 0);

        // Item del desplegable de camiones
        private class ItemCamion
        {
            public int Id;
            public string Patente;
            public string Texto;
            public override string ToString() { return Texto; }
        }

        public FormAsignarPedidos(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            // Mantener las tarjetas del ancho de cada columna al redimensionar
            flpEspera.Resize += (s, e) => AjustarAnchos(flpEspera);
            flpCamiones.Resize += (s, e) => AjustarAnchos(flpCamiones);
            flpEnCamino.Resize += (s, e) => AjustarAnchos(flpEnCamino);
            flpEntregados.Resize += (s, e) => AjustarAnchos(flpEntregados);
        }

        private void FormAsignarPedidos_Load(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // FormMenu se vuelve a mostrar con FormClosed
        }

        // Camiones que están en el depósito (pueden recibir pedidos)
        private static string FiltroDeposito()
        {
            return "Estado = '" + AsignacionLogica.VehiculoDisponible + "' OR Estado = '" + AsignacionLogica.VehiculoCargando + "'";
        }

        // ---------------------------------------------------------------
        // Carga de las 4 columnas
        // ---------------------------------------------------------------
        private void CargarTablero()
        {
            try
            {
                vehiculos = logica.Vehiculos();

                DataTable espera = logica.PedidosEnEspera();
                DataTable enCamion = logica.PedidosEnCamion();
                DataTable enCamino = logica.PedidosEnCamino();
                DataTable entregados = logica.PedidosEntregados();

                DataRow[] enDeposito = vehiculos.Select(FiltroDeposito(), "Patente");

                LlenarPedidos(flpEspera, espera, true);
                LlenarCamionesDeposito(enDeposito, enCamion);
                LlenarCamionesEnCamino(enCamino);
                LlenarPedidos(flpEntregados, entregados, false);

                lblEspera.Text = "En preparación (" + espera.Rows.Count + ")";
                lblCamiones.Text = "Camiones en depósito (" + enDeposito.Length + ")";
                lblEnCamino.Text = "En camino (" + enCamino.Rows.Count + ")";
                lblEntregados.Text = "Entregados (" + entregados.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los pedidos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarColumna(FlowLayoutPanel flp)
        {
            while (flp.Controls.Count > 0)
            {
                Control c = flp.Controls[0];
                flp.Controls.RemoveAt(0);
                c.Dispose();
            }
        }

        private void AgregarMensajeVacio(FlowLayoutPanel flp, string texto)
        {
            flp.Controls.Add(new Label
            {
                Text = texto,
                ForeColor = Color.Gray,
                AutoSize = true,
                Margin = new Padding(4, 8, 0, 0)
            });
        }

        private void LlenarPedidos(FlowLayoutPanel flp, DataTable pedidos, bool conSelector)
        {
            flp.SuspendLayout();
            LimpiarColumna(flp);

            if (pedidos.Rows.Count == 0)
                AgregarMensajeVacio(flp, "No hay pedidos");

            foreach (DataRow fila in pedidos.Rows)
                flp.Controls.Add(CrearTarjeta(fila, conSelector, AnchoTarjeta(flp)));

            flp.ResumeLayout(true);
        }

        private void LlenarCamionesDeposito(DataRow[] camiones, DataTable enCamion)
        {
            flpCamiones.SuspendLayout();
            LimpiarColumna(flpCamiones);

            if (camiones.Length == 0)
                AgregarMensajeVacio(flpCamiones, "No hay camiones en el depósito");

            foreach (DataRow v in camiones)
            {
                DataRow[] pedidos = enCamion.Select("Id_Vehiculo = " + Convert.ToInt32(v["Id"]), "Id_Pedido");
                flpCamiones.Controls.Add(CrearTarjetaCamionDeposito(v, pedidos, AnchoTarjeta(flpCamiones)));
            }

            flpCamiones.ResumeLayout(true);
        }

        // Agrupa los pedidos "En camino" por camión: una tarjeta por camión
        private void LlenarCamionesEnCamino(DataTable enCamino)
        {
            flpEnCamino.SuspendLayout();
            LimpiarColumna(flpEnCamino);

            if (enCamino.Rows.Count == 0)
                AgregarMensajeVacio(flpEnCamino, "No hay camiones en camino");

            var camiones = new List<int>();
            foreach (DataRow p in enCamino.Rows)
            {
                int id = p["Id_Vehiculo"] == DBNull.Value ? -1 : Convert.ToInt32(p["Id_Vehiculo"]);
                if (!camiones.Contains(id)) camiones.Add(id);
            }

            foreach (int id in camiones)
            {
                DataRow[] pedidos = id == -1
                    ? enCamino.Select("Id_Vehiculo IS NULL", "Id_Pedido")
                    : enCamino.Select("Id_Vehiculo = " + id, "Id_Pedido");
                flpEnCamino.Controls.Add(CrearTarjetaCamionEnCamino(pedidos, AnchoTarjeta(flpEnCamino)));
            }

            flpEnCamino.ResumeLayout(true);
        }

        private int AnchoTarjeta(FlowLayoutPanel flp)
        {
            return Math.Max(150, flp.ClientSize.Width - flp.Padding.Horizontal);
        }

        private void AjustarAnchos(FlowLayoutPanel flp)
        {
            int ancho = AnchoTarjeta(flp);
            foreach (Control c in flp.Controls)
            {
                if (c is Panel) c.Width = ancho;
            }
        }

        private Panel NuevaTarjeta(int ancho, int alto)
        {
            return new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Width = ancho,
                Height = alto,
                Margin = new Padding(0, 0, 0, 8)
            };
        }

        private static string TextoCajas(int cajas)
        {
            return cajas + (cajas == 1 ? " caja" : " cajas");
        }

        // ---------------------------------------------------------------
        // Tarjeta de un pedido (columnas En preparación y Entregados)
        // ---------------------------------------------------------------
        private Panel CrearTarjeta(DataRow fila, bool conSelector, int ancho)
        {
            int idPedido = Convert.ToInt32(fila["Id_Pedido"]);
            int cajas = Convert.ToInt32(fila["Cajas"]);
            string cliente = Convert.ToString(fila["Cliente"]).Trim();

            object f = fila["Fecha"];
            string fecha = f is DateTime ? ((DateTime)f).ToString("dd/MM/yyyy") : Convert.ToString(f);

            var card = NuevaTarjeta(ancho, conSelector ? 112 : 92);

            card.Controls.Add(new Label
            {
                Text = "Pedido #" + idPedido,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Verde,
                AutoSize = true,
                Location = new Point(10, 8)
            });

            card.Controls.Add(new Label
            {
                Text = cliente,
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(ancho - 24, 18),
                Location = new Point(10, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            });

            card.Controls.Add(new Label
            {
                Text = fecha + "   ·   " + TextoCajas(cajas),
                ForeColor = Color.DimGray,
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(ancho - 24, 18),
                Location = new Point(10, 52),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            });

            if (conSelector)
            {
                card.Controls.Add(CrearSelectorCamion(idPedido, cajas, ancho));
            }
            else
            {
                string camion = fila["Patente"] == DBNull.Value
                    ? "Sin camión"
                    : Convert.ToString(fila["Patente"]) + " - " + Convert.ToString(fila["Marca"]) + " " + Convert.ToString(fila["Modelo"]);

                card.Controls.Add(new Label
                {
                    Text = "Camión: " + camion,
                    AutoSize = false,
                    AutoEllipsis = true,
                    Size = new Size(ancho - 24, 18),
                    Location = new Point(10, 68),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                });
            }

            return card;
        }

        // Desplegable con los camiones del depósito donde entra el pedido
        private ComboBox CrearSelectorCamion(int idPedido, int cajas, int ancho)
        {
            var cmb = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(ancho - 24, 21),
                Location = new Point(10, 78),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            DataRow[] aptos = vehiculos.Select("(" + FiltroDeposito() + ") AND Libres >= " + cajas, "Patente");

            if (aptos.Length == 0)
            {
                cmb.Items.Add("Ningún camión disponible");
                cmb.SelectedIndex = 0;
                cmb.Enabled = false;
                return cmb;
            }

            cmb.Items.Add(new ItemCamion { Id = 0, Texto = "Elegir camión..." });
            foreach (DataRow v in aptos)
            {
                string patente = Convert.ToString(v["Patente"]);
                cmb.Items.Add(new ItemCamion
                {
                    Id = Convert.ToInt32(v["Id"]),
                    Patente = patente,
                    Texto = patente + " - " + Convert.ToString(v["Marca"]) + " " + Convert.ToString(v["Modelo"])
                            + " (" + Convert.ToInt32(v["Libres"]) + " libres)"
                });
            }
            cmb.SelectedIndex = 0;

            // Solo se dispara cuando el usuario elige (no al cargar)
            cmb.SelectionChangeCommitted += (s, e) =>
            {
                var item = cmb.SelectedItem as ItemCamion;
                if (item == null || item.Id == 0) return;
                AsignarPedido(idPedido, item);
            };

            return cmb;
        }

        // ---------------------------------------------------------------
        // Tarjetas de camión
        // ---------------------------------------------------------------

        // Patente + etiqueta de estado + marca/modelo. Devuelve el "y" siguiente.
        private int AgregarEncabezadoCamion(Panel card, string patente, string estado, string subtitulo, int ancho)
        {
            var fuentePatente = new Font("Segoe UI", 10F, FontStyle.Bold);
            var fuenteChip = new Font("Segoe UI", 8F, FontStyle.Bold);

            card.Controls.Add(new Label
            {
                Text = patente,
                Font = fuentePatente,
                ForeColor = Verde,
                AutoSize = true,
                Location = new Point(10, 8)
            });

            Color fondo, texto;
            if (estado == AsignacionLogica.VehiculoCargando)
            { fondo = Color.FromArgb(255, 243, 205); texto = Color.FromArgb(138, 106, 0); }
            else if (estado == AsignacionLogica.VehiculoEnCamino)
            { fondo = Color.FromArgb(227, 242, 253); texto = Color.FromArgb(21, 101, 192); }
            else
            { fondo = Color.FromArgb(232, 245, 233); texto = Verde; }

            int x = 10 + TextRenderer.MeasureText(patente, fuentePatente).Width + 2;
            card.Controls.Add(new Label
            {
                Text = estado,
                Font = fuenteChip,
                BackColor = fondo,
                ForeColor = texto,
                AutoSize = false,
                Size = new Size(TextRenderer.MeasureText(estado, fuenteChip).Width + 12, 18),
                Location = new Point(x, 10),
                TextAlign = ContentAlignment.MiddleCenter
            });

            card.Controls.Add(new Label
            {
                Text = subtitulo,
                ForeColor = Color.DimGray,
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(ancho - 24, 18),
                Location = new Point(10, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            });

            return 54;
        }

        // Una fila "#10 Cliente · 15 cajas" (con link Quitar si corresponde)
        private void AgregarFilaPedido(Panel card, ref int y, DataRow p, int ancho, string patente, bool conQuitar)
        {
            int idPedido = Convert.ToInt32(p["Id_Pedido"]);
            string texto = "#" + idPedido + "  " + Convert.ToString(p["Cliente"]).Trim()
                           + " · " + TextoCajas(Convert.ToInt32(p["Cajas"]));

            card.Controls.Add(new Label
            {
                Text = texto,
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(ancho - 24 - (conQuitar ? 50 : 0), 18),
                Location = new Point(10, y),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            });

            if (conQuitar)
            {
                var lnk = new LinkLabel
                {
                    Text = "Quitar",
                    LinkColor = Rojo,
                    ActiveLinkColor = Rojo,
                    AutoSize = false,
                    Size = new Size(45, 18),
                    Location = new Point(ancho - 12 - 45, y),
                    TextAlign = ContentAlignment.TopRight,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };
                lnk.LinkClicked += (s, e) => QuitarPedido(idPedido, patente);
                card.Controls.Add(lnk);
            }

            y += 22;
        }

        // Camión en el depósito: carga, pedidos cargados y botón "Camión salió"
        private Panel CrearTarjetaCamionDeposito(DataRow v, DataRow[] pedidos, int ancho)
        {
            int idVehiculo = Convert.ToInt32(v["Id"]);
            string patente = Convert.ToString(v["Patente"]);
            int max = Convert.ToInt32(v["CapacidadMax"]);
            int actual = Convert.ToInt32(v["CapacidadActual"]);
            int libres = Convert.ToInt32(v["Libres"]);

            int cajasCargadas = 0;
            foreach (DataRow p in pedidos) cajasCargadas += Convert.ToInt32(p["Cajas"]);

            var card = NuevaTarjeta(ancho, 100);

            int y = AgregarEncabezadoCamion(card, patente, Convert.ToString(v["Estado"]),
                Convert.ToString(v["Marca"]) + " " + Convert.ToString(v["Modelo"]), ancho);

            int maxBarra = Math.Max(1, max);
            card.Controls.Add(new ProgressBar
            {
                Minimum = 0,
                Maximum = maxBarra,
                Value = Math.Min(Math.Max(actual, 0), maxBarra),
                Style = ProgressBarStyle.Continuous,
                Size = new Size(ancho - 24, 10),
                Location = new Point(10, y),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            });
            y += 14;

            card.Controls.Add(new Label
            {
                Text = actual + " de " + max + " cajas",
                ForeColor = Color.DimGray,
                AutoSize = true,
                Location = new Point(10, y)
            });
            card.Controls.Add(new Label
            {
                Text = libres + " libres",
                ForeColor = Color.DimGray,
                AutoSize = false,
                Size = new Size(100, 16),
                Location = new Point(ancho - 12 - 100, y),
                TextAlign = ContentAlignment.TopRight,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            });
            y += 24;

            if (pedidos.Length == 0)
            {
                card.Controls.Add(new Label
                {
                    Text = "Sin pedidos cargados",
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(10, y)
                });
                y += 22;
            }
            else
            {
                foreach (DataRow p in pedidos)
                    AgregarFilaPedido(card, ref y, p, ancho, patente, true);
            }

            y += 4;
            bool tienePedidos = pedidos.Length > 0;
            int cantidadPedidos = pedidos.Length;

            // Dos botones lado a lado: "Hoja de carga (PDF)" y "Camión salió"
            var botones = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                Size = new Size(ancho - 24, 30),
                Location = new Point(10, y),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            botones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var btnHoja = CrearBotonTarjeta("Hoja de carga (PDF)", tienePedidos, false);
            btnHoja.Margin = new Padding(0, 0, 3, 0);
            btnHoja.Click += (s, e) => GenerarHojaCarga(idVehiculo, AsignacionLogica.EstadoEnCamion);

            var btnSalio = CrearBotonTarjeta("Camión salió", tienePedidos, true);
            btnSalio.Margin = new Padding(3, 0, 0, 0);
            btnSalio.Click += (s, e) => DespacharCamion(idVehiculo, patente, cantidadPedidos, cajasCargadas);

            botones.Controls.Add(btnHoja, 0, 0);
            botones.Controls.Add(btnSalio, 1, 0);
            card.Controls.Add(botones);
            y += 30 + 10;

            card.Height = y;
            return card;
        }

        // Camión en camino: sus pedidos, sin acciones
        private Panel CrearTarjetaCamionEnCamino(DataRow[] pedidos, int ancho)
        {
            DataRow primero = pedidos[0];
            bool sinCamion = primero["Patente"] == DBNull.Value;
            string patente = sinCamion ? "Sin camión" : Convert.ToString(primero["Patente"]);

            int cajas = 0;
            foreach (DataRow p in pedidos) cajas += Convert.ToInt32(p["Cajas"]);

            string subtitulo = (sinCamion ? "" : Convert.ToString(primero["Marca"]) + " " + Convert.ToString(primero["Modelo"]) + " · ")
                               + TextoCajas(cajas);

            var card = NuevaTarjeta(ancho, 100);
            int y = AgregarEncabezadoCamion(card, patente, AsignacionLogica.VehiculoEnCamino, subtitulo, ancho);

            foreach (DataRow p in pedidos)
                AgregarFilaPedido(card, ref y, p, ancho, patente, false);

            // Volver a generar la hoja de carga de un camión que ya salió
            if (!sinCamion)
            {
                int idVehiculo = Convert.ToInt32(primero["Id_Vehiculo"]);
                var lnkHoja = new LinkLabel
                {
                    Text = "Hoja de carga (PDF)",
                    LinkColor = Verde,
                    ActiveLinkColor = Verde,
                    AutoSize = true,
                    Location = new Point(10, y + 2)
                };
                lnkHoja.LinkClicked += (s, e) => GenerarHojaCarga(idVehiculo, AsignacionLogica.EstadoEnCamino);
                card.Controls.Add(lnkHoja);
                y += 24;
            }

            card.Height = y + 8;
            return card;
        }

        // Botón de las tarjetas de camión (principal = verde lleno, secundario = borde verde)
        private Button CrearBotonTarjeta(string texto, bool habilitado, bool principal)
        {
            Color fondo = !habilitado ? Color.Gainsboro : (principal ? Verde : Color.White);
            Color letra = !habilitado ? Color.Gray : (principal ? Color.White : Verde);

            var btn = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Enabled = habilitado,
                BackColor = fondo,
                ForeColor = letra,
                Cursor = habilitado ? Cursors.Hand : Cursors.Default,
                Dock = DockStyle.Fill,
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderColor = habilitado ? Verde : Color.Gainsboro;
            return btn;
        }

        // ---------------------------------------------------------------
        // Acciones
        // ---------------------------------------------------------------
        private void AsignarPedido(int idPedido, ItemCamion camion)
        {
            try
            {
                logica.Asignar(idPedido, camion.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo asignar el pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BeginInvoke((Action)CargarTablero);
                return;
            }

            BitacoraLogica.Registrar(usuarioActual.Nombre,
                "Cargó el pedido #" + idPedido + " en el vehículo " + camion.Patente, "Pedidos");

            // Se recarga después del evento para no destruir el combo mientras se usa
            BeginInvoke((Action)CargarTablero);
        }

        private void QuitarPedido(int idPedido, string patente)
        {
            try
            {
                logica.Quitar(idPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo quitar el pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BeginInvoke((Action)CargarTablero);
                return;
            }

            BitacoraLogica.Registrar(usuarioActual.Nombre,
                "Quitó el pedido #" + idPedido + " del vehículo " + patente, "Pedidos");

            BeginInvoke((Action)CargarTablero);
        }

        private void DespacharCamion(int idVehiculo, string patente, int cantidadPedidos, int cajas)
        {
            var confirmacion = MessageBox.Show(
                "¿Confirmás que el camión " + patente + " salió con " + cantidadPedidos
                + (cantidadPedidos == 1 ? " pedido" : " pedidos") + " (" + TextoCajas(cajas) + ")?\n\n"
                + "El camión y sus pedidos van a quedar \"En camino\".",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                logica.Despachar(idVehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar la salida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BeginInvoke((Action)CargarTablero);
                return;
            }

            BitacoraLogica.Registrar(usuarioActual.Nombre,
                "Registró la salida del vehículo " + patente + " con " + cantidadPedidos + " pedido(s)", "Pedidos");

            BeginInvoke((Action)CargarTablero);
        }

        // Genera el PDF con todos los pedidos del camión, lo guarda en el escritorio y lo abre
        private void GenerarHojaCarga(int idVehiculo, string estadoPedidos)
        {
            DataRow[] encontrado = vehiculos.Select("Id = " + idVehiculo);
            if (encontrado.Length == 0)
            {
                MessageBox.Show("No se encontró el camión.", "Hoja de carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow vehiculo = encontrado[0];
            string patente = Convert.ToString(vehiculo["Patente"]).Trim();

            try
            {
                DataTable detalle = logica.DetalleCarga(idVehiculo, estadoPedidos);
                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show("El camión " + patente + " no tiene pedidos cargados.", "Hoja de carga",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ruta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                    "HojaDeCarga_" + patente + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf");

                HojaDeCargaPdf.Generar(ruta, vehiculo, detalle, usuarioActual.Nombre);

                BitacoraLogica.Registrar(usuarioActual.Nombre,
                    "Generó la hoja de carga del vehículo " + patente, "Pedidos");

                Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
            }
            catch (IOException)
            {
                MessageBox.Show("No se pudo guardar el PDF. Si tenés abierta una hoja de carga con el mismo nombre, cerrala y probá de nuevo.",
                    "Hoja de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                    "Hoja de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}