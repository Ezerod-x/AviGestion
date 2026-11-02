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

        
        private static readonly Color[] Paleta =
        {
            Color.FromArgb(46, 92, 45),   
            Color.FromArgb(214, 137, 16), 
            Color.FromArgb(180, 30, 30),  
            Color.FromArgb(52, 120, 180), 
            Color.FromArgb(129, 163, 74), 
            Color.FromArgb(142, 99, 166), 
            Color.FromArgb(120, 120, 120) 
        };

        public FormAlertas(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarChart();
            ConfigurarPlaceholderBuscar();
            new ToolTip().SetToolTip(dgvAlertas, "Doble clic en una fila para ver el detalle del producto");
            this.Load += FormAlertas_Load;
        }


        
        private const string PH_BUSCAR = "Buscar alerta por producto o código...";
        private bool inicializando = true;    

       
        private string TextoBusqueda
        {
            get { return txtBuscar.Text == PH_BUSCAR ? "" : txtBuscar.Text; }
        }

        private void PonerPlaceholder()
        {
            txtBuscar.Text = PH_BUSCAR;
            txtBuscar.ForeColor = System.Drawing.Color.Gray;
        }

        private void ConfigurarPlaceholderBuscar()
        {
            PonerPlaceholder();

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == PH_BUSCAR)
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = System.Drawing.Color.Black;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    PonerPlaceholder();
            };
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            
            try { new StockLogica().SincronizarAlertas(); } catch { }

           
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Activa";
            cmbVistaGrafico.SelectedIndex = 0;
            chkFiltrarFecha_CheckedChanged(null, EventArgs.Empty);   

            inicializando = false;
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

       
        private DateTime? FechaDesde { get { return chkFiltrarFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null; } }
        private DateTime? FechaHasta { get { return chkFiltrarFecha.Checked ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null; } }

        private bool RangoFechasInvalido()
        {
            return chkFiltrarFecha.Checked && dtpDesde.Value.Date > dtpHasta.Value.Date;
        }

        private void CargarGrilla()
        {
            List<AlertaVista> lista;
            if (RangoFechasInvalido())
            {
                lista = new List<AlertaVista>();
            }
            else
            {
                lista = logica.Buscar(TextoBusqueda, cmbTipoAlerta.Text, cmbEstadoAlerta.Text, FechaDesde, FechaHasta);
            }

            dgvAlertas.AutoGenerateColumns = false;
            dgvAlertas.DataSource = null;
            dgvAlertas.DataSource = lista;

            if (dgvAlertas.Columns.Count > 0)
            {
                dgvAlertas.Columns["colFechaGeneracion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvAlertas.Columns["colFechaResolucion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

           
            lblSinResultados.Visible = lista.Count == 0;
            if (RangoFechasInvalido())
                lblSinResultados.Text = "La fecha \"Desde\" no puede ser posterior a la fecha \"Hasta\".";
            else if (lista.Count == 0)
                lblSinResultados.Text = (cmbEstadoAlerta.Text == "Activa" && string.IsNullOrWhiteSpace(TextoBusqueda) && cmbTipoAlerta.Text == "Todas" && !chkFiltrarFecha.Checked)
                    ? "No hay alertas activas pendientes en este momento."
                    : "No existen alertas con los criterios aplicados.";
            else
                lblSinResultados.Text = "";
        }

       
        private void AplicarFiltros()
        {
            CargarGrilla();
            if (pnlGraficos.Visible) CargarGrafico();
        }

        private void Filtro_Changed(object sender, EventArgs e)
        {
            if (inicializando) return;
            AplicarFiltros();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
            if (inicializando) return;
            AplicarFiltros();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            inicializando = true;          
            PonerPlaceholder();
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Todas";
            chkFiltrarFecha.Checked = false;
            inicializando = false;

            AplicarFiltros();
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

        
        private void dgvAlertas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

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
            else
                CargarGrilla();
        }

        private void cmbVistaGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicializando) return;
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            chartAlertas.Series.Clear();
            var area = chartAlertas.ChartAreas["area1"];
            var leyenda = chartAlertas.Legends["leyenda1"];

            int criterio = cmbVistaGrafico.SelectedIndex < 0 ? 0 : cmbVistaGrafico.SelectedIndex;
            string titulo;
            bool esTorta = criterio != 3;

            switch (criterio)
            {
                case 0: titulo = "Alertas por tipo"; break;
                case 1: titulo = "Alertas por producto"; break;
                case 2: titulo = "Alertas por categoría"; break;
                default: titulo = "Alertas por período (mes)"; break;
            }

            
            List<ConteoAgrupado> datos = RangoFechasInvalido()
                ? new List<ConteoAgrupado>()
                : logica.Estadisticas(criterio, TextoBusqueda, cmbTipoAlerta.Text, cmbEstadoAlerta.Text, FechaDesde, FechaHasta);

            int total = 0;
            foreach (var d in datos) total += d.Cantidad;
            chartAlertas.Titles["titulo"].Text = total == 0
                ? titulo + "  ·  Sin alertas con los filtros aplicados"
                : $"{titulo}  ·  Total: {total}";

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

        private void chartAlertas_Click(object sender, EventArgs e)
        {

        }
    }
}