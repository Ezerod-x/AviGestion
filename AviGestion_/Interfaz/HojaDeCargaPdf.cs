using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using PdfDocument = iTextSharp.text.Document;
using PdfFont = iTextSharp.text.Font;

namespace AviGestion_.Interfaz
{
    // Arma el PDF "Hoja de carga" con todos los pedidos que lleva un camión
    public static class HojaDeCargaPdf
    {
        private static readonly BaseColor Verde = new BaseColor(46, 125, 50);
        private static readonly BaseColor VerdeClaro = new BaseColor(232, 245, 233);
        private static readonly BaseColor Gris = new BaseColor(110, 110, 110);
        private static readonly BaseColor Borde = new BaseColor(200, 200, 200);

        // vehiculo: fila de Vehiculos (Patente, Marca, Modelo, CapacidadMax, Estado)
        // detalle: filas de DetalleCarga (una por producto de cada pedido)
        public static void Generar(string ruta, DataRow vehiculo, DataTable detalle, string usuario)
        {
            var fTitulo = new PdfFont(PdfFont.FontFamily.HELVETICA, 18f, PdfFont.BOLD, Verde);
            var fSubtitulo = new PdfFont(PdfFont.FontFamily.HELVETICA, 13f, PdfFont.BOLD);
            var fSeccion = new PdfFont(PdfFont.FontFamily.HELVETICA, 11f, PdfFont.BOLD, Verde);
            var fNormal = new PdfFont(PdfFont.FontFamily.HELVETICA, 9.5f);
            var fBold = new PdfFont(PdfFont.FontFamily.HELVETICA, 9.5f, PdfFont.BOLD);
            var fChico = new PdfFont(PdfFont.FontFamily.HELVETICA, 8f, PdfFont.NORMAL, Gris);
            var fEncabezado = new PdfFont(PdfFont.FontFamily.HELVETICA, 9.5f, PdfFont.BOLD, BaseColor.WHITE);

            // Agrupar las filas por pedido y sumar cajas por producto
            var pedidos = new List<int>();
            var filasPorPedido = new Dictionary<int, List<DataRow>>();
            var productos = new List<string>();
            var cajasPorProducto = new Dictionary<string, int>();
            int totalCajas = 0;

            foreach (DataRow r in detalle.Rows)
            {
                int id = Convert.ToInt32(r["Id_Pedido"]);
                if (!filasPorPedido.ContainsKey(id))
                {
                    filasPorPedido[id] = new List<DataRow>();
                    pedidos.Add(id);
                }
                filasPorPedido[id].Add(r);

                string producto = Texto(r["Producto"]);
                int cantidad = Convert.ToInt32(r["Cantidad"]);
                if (!cajasPorProducto.ContainsKey(producto))
                {
                    cajasPorProducto[producto] = 0;
                    productos.Add(producto);
                }
                cajasPorProducto[producto] += cantidad;
                totalCajas += cantidad;
            }

            string patente = Texto(vehiculo["Patente"]);
            int capacidad = Convert.ToInt32(vehiculo["CapacidadMax"]);

            using (var fs = new FileStream(ruta, FileMode.Create))
            {
                var doc = new PdfDocument(PageSize.A4, 36f, 36f, 36f, 36f);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Encabezado
                doc.Add(new Paragraph("AviGestión - Avícola Don José", fTitulo));
                doc.Add(new Paragraph("Hoja de carga", fSubtitulo) { SpacingAfter = 10f });

                // Datos del camión
                var info = new PdfPTable(new float[] { 1f, 2.4f, 1.1f, 1.6f }) { WidthPercentage = 100, SpacingAfter = 14f };
                AgregarDato(info, "Camión:", patente + " - " + Texto(vehiculo["Marca"]) + " " + Texto(vehiculo["Modelo"]), fBold, fNormal);
                AgregarDato(info, "Emitida:", DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fBold, fNormal);
                AgregarDato(info, "Carga:", totalCajas + " de " + capacidad + " cajas", fBold, fNormal);
                AgregarDato(info, "Estado:", Texto(vehiculo["Estado"]), fBold, fNormal);
                AgregarDato(info, "Pedidos:", pedidos.Count.ToString(), fBold, fNormal);
                AgregarDato(info, "Generada por:", usuario, fBold, fNormal);
                doc.Add(info);

                // Tabla de pedidos
                doc.Add(new Paragraph("Pedidos a entregar", fSeccion) { SpacingAfter = 6f });

                var tabla = new PdfPTable(new float[] { 0.9f, 2.2f, 2.5f, 3f, 0.8f }) { WidthPercentage = 100, HeaderRows = 1 };
                foreach (string titulo in new[] { "Pedido", "Cliente", "Dirección / Teléfono", "Productos", "Cajas" })
                    tabla.AddCell(Celda(new Phrase(titulo, fEncabezado), Verde, Element.ALIGN_LEFT));

                foreach (int id in pedidos)
                {
                    List<DataRow> filas = filasPorPedido[id];
                    DataRow primera = filas[0];

                    var pPedido = new Phrase();
                    pPedido.Add(new Chunk("#" + id, fBold));
                    pPedido.Add(new Chunk("\n" + Fecha(primera["Fecha"]), fChico));
                    tabla.AddCell(Celda(pPedido));

                    var pCliente = new Phrase();
                    pCliente.Add(new Chunk(Texto(primera["Cliente"]), fNormal));
                    string empresa = Texto(primera["Empresa"]);
                    if (empresa != "") pCliente.Add(new Chunk("\n" + empresa, fChico));
                    tabla.AddCell(Celda(pCliente));

                    var pDireccion = new Phrase();
                    pDireccion.Add(new Chunk(Texto(primera["Direccion"]) == "" ? "Sin dirección" : Texto(primera["Direccion"]), fNormal));
                    string telefono = Texto(primera["Telefono"]);
                    if (telefono != "") pDireccion.Add(new Chunk("\nTel: " + telefono, fChico));
                    tabla.AddCell(Celda(pDireccion));

                    var lineas = new List<string>();
                    int cajasPedido = 0;
                    foreach (DataRow f in filas)
                    {
                        int cant = Convert.ToInt32(f["Cantidad"]);
                        cajasPedido += cant;
                        lineas.Add(Texto(f["Producto"]) + " x " + cant);
                    }
                    tabla.AddCell(Celda(new Phrase(string.Join("\n", lineas), fNormal)));
                    tabla.AddCell(Celda(new Phrase(cajasPedido.ToString(), fBold), null, Element.ALIGN_RIGHT));
                }

                var celdaTotal = Celda(new Phrase("Total", fBold), VerdeClaro, Element.ALIGN_RIGHT);
                celdaTotal.Colspan = 4;
                tabla.AddCell(celdaTotal);
                tabla.AddCell(Celda(new Phrase(totalCajas.ToString(), fBold), VerdeClaro, Element.ALIGN_RIGHT));
                tabla.SpacingAfter = 16f;
                doc.Add(tabla);

                // Resumen por producto (para armar la carga)
                doc.Add(new Paragraph("Resumen de carga por producto", fSeccion) { SpacingAfter = 6f });

                var resumen = new PdfPTable(new float[] { 4f, 1f })
                {
                    WidthPercentage = 60,
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    HeaderRows = 1
                };
                resumen.AddCell(Celda(new Phrase("Producto", fEncabezado), Verde));
                resumen.AddCell(Celda(new Phrase("Cajas", fEncabezado), Verde, Element.ALIGN_RIGHT));
                foreach (string producto in productos)
                {
                    resumen.AddCell(Celda(new Phrase(producto, fNormal)));
                    resumen.AddCell(Celda(new Phrase(cajasPorProducto[producto].ToString(), fNormal), null, Element.ALIGN_RIGHT));
                }
                resumen.AddCell(Celda(new Phrase("Total", fBold), VerdeClaro, Element.ALIGN_RIGHT));
                resumen.AddCell(Celda(new Phrase(totalCajas.ToString(), fBold), VerdeClaro, Element.ALIGN_RIGHT));
                resumen.SpacingAfter = 50f;
                doc.Add(resumen);

                // Firmas
                var firmas = new PdfPTable(new float[] { 1f, 0.4f, 1f }) { WidthPercentage = 100, KeepTogether = true };
                firmas.AddCell(CeldaFirma("Firma responsable de depósito", fChico));
                firmas.AddCell(new PdfPCell(new Phrase("")) { Border = Rectangle.NO_BORDER });
                firmas.AddCell(CeldaFirma("Firma del chofer", fChico));
                doc.Add(firmas);

                doc.Close();
            }
        }

        private static void AgregarDato(PdfPTable tabla, string etiqueta, string valor, PdfFont fEtiqueta, PdfFont fValor)
        {
            tabla.AddCell(new PdfPCell(new Phrase(etiqueta, fEtiqueta)) { Border = Rectangle.NO_BORDER, PaddingBottom = 4f });
            tabla.AddCell(new PdfPCell(new Phrase(valor, fValor)) { Border = Rectangle.NO_BORDER, PaddingBottom = 4f });
        }

        private static PdfPCell Celda(Phrase contenido, BaseColor fondo = null, int alineacion = Element.ALIGN_LEFT)
        {
            var celda = new PdfPCell(contenido)
            {
                Padding = 5f,
                BorderColor = Borde,
                HorizontalAlignment = alineacion,
                VerticalAlignment = Element.ALIGN_MIDDLE
            };
            if (fondo != null) celda.BackgroundColor = fondo;
            return celda;
        }

        private static PdfPCell CeldaFirma(string texto, PdfFont fuente)
        {
            return new PdfPCell(new Phrase(texto, fuente))
            {
                Border = Rectangle.TOP_BORDER,
                BorderColor = BaseColor.BLACK,
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingTop = 4f
            };
        }

        private static string Texto(object valor)
        {
            return valor == null || valor == DBNull.Value ? "" : Convert.ToString(valor).Trim();
        }

        private static string Fecha(object valor)
        {
            if (valor is DateTime) return ((DateTime)valor).ToString("dd/MM/yyyy");
            DateTime f;
            if (DateTime.TryParse(Texto(valor), out f)) return f.ToString("dd/MM/yyyy");
            return Texto(valor);
        }
    }
}
