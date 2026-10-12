using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AviGestion_.Datos;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormAlertas : Form
    {
        private AlertaLogica logica = new AlertaLogica();
        private Usuario usuarioActual;

        // Paleta de colores del gráfico (verde del sistema + colores de contraste)
        private static readonly Color[] Paleta =
        {
            Color.FromArgb(46, 92, 45),   // verde oscuro
            Color.FromArgb(214, 137, 16), // ámbar
            Color.FromArgb(180, 30, 30),  // rojo
            Color.FromArgb(52, 120, 180), // azul
            Color.FromArgb(129, 163, 74), // verde claro
            Color.FromArgb(142, 99, 166), // violeta
            Color.FromArgb(120, 120, 120) // gris
        };

        public FormAlertas(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarChart();
            this.Load += FormAlertas_Load;
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            // El flujo normal del CU-08 arranca mostrando las alertas ACTIVAS.
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Activa";
            cmbVistaGrafico.SelectedIndex = 0;
            CargarGrilla();
        }

        private void ConfigurarChart()
        {
            chartAlertas.Palette = ChartColorPalette.None;
            chartAlertas.PaletteCustomColors = Paleta;
            chartAlertas.BackColor = Color.White;
            chartAlertas.AntiAliasing = AntiAliasingStyles.All;
            chartAlertas.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            chartAlertas.ChartAreas.Clear();
            var area = new ChartArea("area1") { BackColor = Color.Transparent };
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Format = "0";
            chartAlertas.ChartAreas.Add(area);

            chartAlertas.Legends.Clear();
            chartAlertas.Legends.Add(new Legend("leyenda1")
            {
                Docking = Docking.Right,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.Transparent
            });

            chartAlertas.Titles.Clear();
            chartAlertas.Titles.Add(new Title("", Docking.Top,
                new Font("Segoe UI", 13, FontStyle.Bold), Color.FromArgb(46, 92, 45))
            { Name = "titulo" });
        }

        private void CargarGrilla()
        {
            DateTime? desde = chkFiltrarFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = chkFiltrarFecha.Checked ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null;

            var lista = logica.Buscar(txtBuscar.Text, cmbTipoAlerta.Text, cmbEstadoAlerta.Text, desde, hasta);

            dgvAlertas.AutoGenerateColumns = false;
            dgvAlertas.DataSource = null;
            dgvAlertas.DataSource = lista;

            if (dgvAlertas.Columns.Count > 0)
            {
                dgvAlertas.Columns["colFechaGeneracion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvAlertas.Columns["colFechaResolucion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            // Alternativas 2.1 / 6.1 del CU-08: informar cuando no hay alertas para mostrar.
            lblSinResultados.Visible = lista.Count == 0;
            lblSinResultados.Text = lista.Count == 0
                ? (cmbEstadoAlerta.Text == "Activa" && string.IsNullOrWhiteSpace(txtBuscar.Text) && cmbTipoAlerta.Text == "Todas" && !chkFiltrarFecha.Checked
                    ? "No hay alertas activas pendientes en este momento."
                    : "No existen alertas con los criterios aplicados.")
                : "";
        }

        private void Filtro_Changed(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
            CargarGrilla();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Todas";
            chkFiltrarFecha.Checked = false;
            CargarGrilla();
        }

        private void dgvAlertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlertas.Columns[e.ColumnIndex].Name != "colEstadoAlerta" || e.Value == null) return;

            if (e.Value.ToString() == "Activa")
            {
                e.CellStyle.ForeColor = Color.FromArgb(180, 30, 30);
                e.CellStyle.Font = new Font(dgvAlertas.Font, FontStyle.Bold);
            }
            else
            {
                e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50);
            }
        }

        private void dgvAlertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvAlertas.Columns[e.ColumnIndex].Name != "colSeleccionarAlerta") return;

            var alerta = (AlertaVista)dgvAlertas.Rows[e.RowIndex].DataBoundItem;
            var resumen = logica.ObtenerResumenProducto(alerta.ProductoId);
            if (resumen == null) return;

            lblVCodigo.Text = resumen.Codigo;
            lblVProducto.Text = resumen.Producto;
            lblVCategoria.Text = resumen.Categoria;
            lblVStockActual.Text = resumen.Stock.ToString();
            lblVStockMin.Text = resumen.StockMinimo.ToString();
            lblVStockMax.Text = resumen.StockMaximo.ToString();
            lblVEstado.Text = resumen.Estado;
            lblVCantAlertas.Text = resumen.CantidadAlertasHistoricas.ToString();
        }

        private void btnAlternarVista_Click(object sender, EventArgs e)
        {
            bool mostrandoGrilla = pnlGrilla.Visible;

            pnlGrilla.Visible = !mostrandoGrilla;
            pnlGraficos.Visible = mostrandoGrilla;

            btnAlternarVista.Text = mostrandoGrilla ? "📋 Ver Grilla" : "📊 Ver Gráficos";

            if (mostrandoGrilla)
                CargarGrafico();
        }

        private void cmbVistaGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            chartAlertas.Series.Clear();
            var area = chartAlertas.ChartAreas["area1"];
            var leyenda = chartAlertas.Legends["leyenda1"];

            List<ConteoAgrupado> datos;
            string titulo;
            bool esTorta = true;

            switch (cmbVistaGrafico.SelectedIndex)
            {
                case 0: datos = logica.ConteoPorTipo(); titulo = "Alertas por tipo"; break;
                case 1: datos = logica.ConteoPorProducto(); titulo = "Alertas por producto"; break;
                case 2: datos = logica.ConteoPorCategoria(); titulo = "Alertas por categoría"; break;
                default:
                    datos = logica.ConteoPorMes();
                    titulo = "Alertas por período (mes)";
                    esTorta = false;
                    break;
            }

            int total = 0;
            foreach (var d in datos) total += d.Cantidad;
            chartAlertas.Titles["titulo"].Text = $"{titulo}  ·  Total: {total}";

            var serie = new Series("Alertas")
            {
                BorderColor = Color.White,
                BorderWidth = 2,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                IsValueShownAsLabel = true
            };

            if (esTorta)
            {
                serie.ChartType = SeriesChartType.Pie;
                serie["PieLabelStyle"] = "Outside";
                serie["PieLineColor"] = "Gray";
                serie["PieStartAngle"] = "270";
                // Agrupa las porciones muy chicas en "Otros"
                serie["CollectedThreshold"] = "5";
                serie["CollectedThresholdUsePercent"] = "true";
                serie["CollectedLabel"] = "Otros";

                serie.Label = "#PERCENT{P0}";
                serie.LegendText = "#VALX  (#VAL)";

                area.Area3DStyle.Enable3D = false;
                leyenda.Enabled = true;
            }
            else
            {
                serie.ChartType = SeriesChartType.Column;
                serie.Color = Color.FromArgb(46, 92, 45);
                serie["PointWidth"] = "0.5";
                serie.Label = "#VAL";
                leyenda.Enabled = false;
                area.AxisY.Title = "Cantidad de alertas";
                area.AxisX.Title = "Mes";
                area.AxisY.Interval = 1;
            }

            foreach (var item in datos)
                serie.Points.AddXY(item.Etiqueta, item.Cantidad);

            chartAlertas.Series.Add(serie);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }

        private void chartAlertas_Click(object sender, EventArgs e)
        {

        }
    }
}