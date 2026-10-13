using AviGestion;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormAsignarPedidos : Form
    {
        private readonly Usuario usuarioActual;
        private readonly AsignacionLogica logica = new AsignacionLogica();
        private DataTable vehiculos;

        private static readonly Color Verde = Color.FromArgb(46, 125, 50);

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

        // ---------------------------------------------------------------
        // Carga de las 3 columnas
        // ---------------------------------------------------------------
        private void CargarTablero()
        {
            try
            {
                vehiculos = logica.Vehiculos();

                DataTable espera = logica.PedidosEnEspera();
                DataTable enCamino = logica.PedidosEnCamino();
                DataTable entregados = logica.PedidosEntregados();

                LlenarColumna(flpEspera, espera, true);
                LlenarColumna(flpEnCamino, enCamino, false);
                LlenarColumna(flpEntregados, entregados, false);

                lblEspera.Text = "Pedidos en espera (" + espera.Rows.Count + ")";
                lblEnCamino.Text = "En camino (" + enCamino.Rows.Count + ")";
                lblEntregados.Text = "Entregados (" + entregados.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los pedidos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarColumna(FlowLayoutPanel flp, DataTable pedidos, bool conSelector)
        {
            flp.SuspendLayout();

            while (flp.Controls.Count > 0)
            {
                Control c = flp.Controls[0];
                flp.Controls.RemoveAt(0);
                c.Dispose();
            }

            if (pedidos.Rows.Count == 0)
            {
                flp.Controls.Add(new Label
                {
                    Text = "No hay pedidos",
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(4, 8, 0, 0)
                });
            }

            foreach (DataRow fila in pedidos.Rows)
                flp.Controls.Add(CrearTarjeta(fila, conSelector, AnchoTarjeta(flp)));

            flp.ResumeLayout(true);
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

        // ---------------------------------------------------------------
        // Tarjeta de un pedido
        // ---------------------------------------------------------------
        private Panel CrearTarjeta(DataRow fila, bool conSelector, int ancho)
        {
            int idPedido = Convert.ToInt32(fila["Id_Pedido"]);
            int cajas = Convert.ToInt32(fila["Cajas"]);
            string cliente = Convert.ToString(fila["Cliente"]).Trim();

            object f = fila["Fecha"];
            string fecha = f is DateTime ? ((DateTime)f).ToString("dd/MM/yyyy") : Convert.ToString(f);

            var card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Width = ancho,
                Height = conSelector ? 112 : 92,
                Margin = new Padding(0, 0, 0, 8)
            };

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
                Text = fecha + "   ·   " + cajas + (cajas == 1 ? " caja" : " cajas"),
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

        // Desplegable con los camiones donde entra el pedido
        private ComboBox CrearSelectorCamion(int idPedido, int cajas, int ancho)
        {
            var cmb = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(ancho - 24, 21),
                Location = new Point(10, 78),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            DataRow[] aptos = vehiculos.Select("Libres >= " + cajas, "Patente");

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
                "Asignó el pedido #" + idPedido + " al vehículo " + camion.Patente, "Pedidos");

            // Se recarga después del evento para no destruir el combo mientras se usa
            BeginInvoke((Action)CargarTablero);
        }
    }
}