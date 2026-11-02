using AviGestion_.Datos;
using AviGestion_.Interfaz;
using System;
using System.Collections.Generic;

namespace AviGestion_.Logica
{
    public class PedidoLogica
    {
        private PedidoDatos datos = new PedidoDatos();

        #region Obtener datos
        public List<ClienteItem> ObtenerClientes()
        {
            return datos.ObtenerClientes();
        }

        public List<ProductoItem> ObtenerProductos()
        {
            return datos.ObtenerProductos();
        }

        public List<PedidoItem> ObtenerPedidos()
        {
            return datos.ObtenerPedidos();
        }
        #endregion

        #region Validar y Registrar Pedido
        public int RegistrarPedido(int idCliente, DateTime fecha,
            List<(string Codigo, int Cantidad)> productos)
        {
            if (idCliente <= 0)
                throw new Exception("Debe seleccionar un cliente válido.");

            if (productos == null || productos.Count == 0)
                throw new Exception("Debe agregar al menos un producto.");

            // Armar parámetro para el SP
            string productosParam = "";
            foreach (var p in productos)
                productosParam += $"{p.Codigo}|{p.Cantidad},";
            productosParam = productosParam.TrimEnd(',');

            return datos.InsertarPedido(idCliente, fecha, productosParam);
        }
        #endregion

        #region Validar y Cancelar Pedido
        public void CancelarPedido(int idPedido, string estadoActual)
        {
            if (estadoActual == "Cancelado")
                throw new Exception("Este pedido ya está cancelado.");

            // Solo se puede cancelar mientras el pedido no salió del depósito
            // (los mismos estados que valida SP_CancelarPedido en la base)
            if (estadoActual != "Pendiente" && estadoActual != "En preparación")
                throw new Exception(
                    $"El pedido #{idPedido} está en estado \"{estadoActual}\" y no puede cancelarse.");

            datos.CancelarPedido(idPedido);
        }
        #endregion
    }
}