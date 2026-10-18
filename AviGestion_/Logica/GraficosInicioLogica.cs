using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviGestion_.Logica
{
    //Datos que muestra el menú principal en sus graficos
    public class GraficosInicioLogica
    {
        private const string ESTADO_ACTIVO = "Activo";          // texto del estado de un producto activo
        private const string ESTADO_CANCELADO = "Cancelado";    // texto del estado de un pedido cancelado

        private readonly ABM_Producto productos = new ABM_Producto();
        private readonly PedidoDatos pedidos = new PedidoDatos();

        //Productos activos, con los que están en alerta (mínimo o máximo) primero.
        public List<Producto> StockActivo()
        {
            return productos.ListarProductos()
                .Where(p => string.Equals(p.Estado, ESTADO_ACTIVO, StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => (p.Stock <= p.StockMinimo || p.Stock >= p.StockMaximo) ? 0 : 1)
                .ThenBy(p => p.Stock - p.StockMinimo)
                .ToList();
        }

        //Cantidad de pedidos por cliente, sin contar los cancelados, de mayor a menor.
        public List<KeyValuePair<string, int>> PedidosPorCliente()
        {
            return pedidos.ObtenerPedidos()
                .Where(p => !string.Equals(p.Estado, ESTADO_CANCELADO, StringComparison.OrdinalIgnoreCase))
                .GroupBy(p => p.Cliente)
                .Select(g => new KeyValuePair<string, int>(g.Key, g.Count()))
                .OrderByDescending(kv => kv.Value)
                .ToList();
        }
    }
}
