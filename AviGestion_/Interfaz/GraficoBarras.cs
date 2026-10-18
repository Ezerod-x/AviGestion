using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    //Un renglón del gráfico: nombre y valor (y límites, si es de stock).
    public class ItemGrafico
    {
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int Minimo { get; set; }      // solo para el gráfico de stock
        public int Maximo { get; set; }      // solo para el gráfico de stock
        public string Texto { get; set; }    // texto a la derecha de la barra; si es null, se muestra Valor
    }

    //Panel que dibuja barras horizontales. No usa el control Chart.
    public class GraficoBarras : Panel
    {
        public List<ItemGrafico> Datos { get; set; } = new List<ItemGrafico>();
        public bool MostrarLimites { get; set; }                       // true = stock: rojo en el mínimo, naranja en el máximo
        public int Columnas { get; set; } = 1;                         // para paneles anchos y bajos
        public Color ColorBarra { get; set; } = Color.FromArgb(46, 125, 50);
        public string TextoVacio { get; set; } = "Sin datos para mostrar.";

        private static readonly Color Rojo = Color.FromArgb(192, 57, 43);
        private static readonly Color Naranja = Color.FromArgb(230, 126, 34);
        private static readonly Color Texto = Color.FromArgb(40, 40, 40);

        public GraficoBarras()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (Datos == null || Datos.Count == 0)
            {
                TextRenderer.DrawText(g, TextoVacio, Font, ClientRectangle, Color.Gray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                return;
            }

            const int ALTO_MIN_FILA = 18;
            int cols = Math.Max(1, Columnas);
            int capacidad = Math.Max(1, ClientSize.Height / ALTO_MIN_FILA) * cols;     // lo que entra en el panel
            List<ItemGrafico> datos = Datos.Take(capacidad).ToList();

            int filas = (int)Math.Ceiling(datos.Count / (double)cols);
            int altoFila = Math.Min(30, ClientSize.Height / filas);
            int anchoCelda = ClientSize.Width / cols;
            float maxGeneral = Math.Max(1, datos.Max(d => d.Valor));

            using (var fuente = new Font("Segoe UI", 8.5F))
            using (var pista = new SolidBrush(Color.FromArgb(232, 232, 232)))
            {
                for (int i = 0; i < datos.Count; i++)
                {
                    ItemGrafico d = datos[i];
                    int x0 = (i % cols) * anchoCelda + 6;
                    int y0 = (i / cols) * altoFila;
                    int anchoNombre = Math.Min(170, (int)(anchoCelda * 0.36));
                    int anchoValor = 58;
                    int xBarra = x0 + anchoNombre + 6;
                    int anchoBarra = anchoCelda - 12 - anchoNombre - 6 - anchoValor;
                    if (anchoBarra < 20) continue;
                    int altoBarra = 12;
                    int yBarra = y0 + (altoFila - altoBarra) / 2;

                    // nombre (con "..." si no entra)
                    TextRenderer.DrawText(g, d.Nombre, fuente, new Rectangle(x0, y0, anchoNombre, altoFila), Texto,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    // fondo de la barra
                    g.FillRectangle(pista, xBarra, yBarra, anchoBarra, altoBarra);

                    // barra: proporcional al máximo del producto (stock) o al mayor valor de la lista
                    float tope = (MostrarLimites && d.Maximo > 0) ? d.Maximo : maxGeneral;
                    int largo = (int)(anchoBarra * Math.Min(1f, d.Valor / tope));
                    Color color = ColorBarra;
                    if (MostrarLimites)
                    {
                        if (d.Valor <= d.Minimo) color = Rojo;
                        else if (d.Maximo > 0 && d.Valor >= d.Maximo) color = Naranja;
                    }
                    if (largo > 0)
                        using (var pincel = new SolidBrush(color))
                            g.FillRectangle(pincel, xBarra, yBarra, largo, altoBarra);

                    // marca del stock mínimo
                    if (MostrarLimites && d.Maximo > 0)
                    {
                        int xm = xBarra + (int)(anchoBarra * (d.Minimo / (float)d.Maximo));
                        g.DrawLine(Pens.Black, xm, yBarra - 2, xm, yBarra + altoBarra + 2);
                    }

                    // valor a la derecha
                    TextRenderer.DrawText(g, d.Texto ?? d.Valor.ToString(), fuente,
                        new Rectangle(xBarra + anchoBarra + 4, y0, anchoValor, altoFila), Texto,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                }
            }
        }

    }
}