using System;
using System.Collections.Generic;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class AlertaLogica
    {
        private DatosAlerta datos = new DatosAlerta();

        public List<AlertaVista> Buscar(string filtroTexto, string tipoAlerta, string estado,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            return datos.Listar(filtroTexto, tipoAlerta, estado, fechaDesde, fechaHasta);
        }

        public ProductoAlertaResumen ObtenerResumenProducto(int productoId)
        {
            return datos.ObtenerResumenProducto(productoId);
        }

       
        public List<ConteoAgrupado> Estadisticas(int criterio, string filtroTexto, string tipoAlerta, string estado,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            return datos.Contar(criterio, filtroTexto, tipoAlerta, estado, fechaDesde, fechaHasta);
        }
    }
}