using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace AviGestion_.Logica
{
    // Los valores coinciden con @Resultado del SP_Facturacion_ConfirmarDespacho
    public enum ResultadoDespacho
    {
        Exito = 0,
        PedidoNoDisponible = 1,   // ya procesado o cancelado por otro usuario
        CompraYaRegistrada = 2
    }

    public class FacturacionLogica//nuevo
    {
        private FacturacionDatos datos = new FacturacionDatos();

        public List<PagoPedido> ListarPedidosPendientes()
        {
            return datos.ObtenerPedidosPendientes();
        }

        public DataTable ListarDetallesDelPedido(int idPedido)
        {
            return datos.ObtenerDetallesDelPedido(idPedido);
        }

        public ResultadoDespacho ConfirmarDespacho(int idPedido)
        {
            if (idPedido <= 0)
                return ResultadoDespacho.PedidoNoDisponible;

            return datos.ConfirmarDespacho(idPedido);
        }

        public DataTable ListarFacturadosPorFecha(DateTime fecha)
        {
            return datos.ObtenerFacturadosPorFecha(fecha);
        }
    }
}
