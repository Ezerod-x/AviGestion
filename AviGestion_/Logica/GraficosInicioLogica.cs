using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Globalization;

namespace AviGestion_.Logica
{
    //Datos que muestra el menú principal en sus graficos
    public class GraficosInicioLogica
    {
        private const string ESTADO_ACTIVO = "Activo";          // producto activo
        private const string ESTADO_PENDIENTE = "Pendiente";    // pedido registrado, todavía sin facturar ni despachar
        private const string ESTADO_CANCELADO = "Cancelado";
        private const int DIAS_VENTAS = 30;                     // ventana de los gráficos de ventas (0 = sin límite)

        private readonly ABM_Producto productos = new ABM_Producto();
        private readonly PedidoDatos pedidos = new PedidoDatos();
        private readonly FacturacionDatos facturacion = new FacturacionDatos();

        #region Gráfico de stock
        // Productos activos con su stock real en depósito. El stock de la base ya descuenta los pedidos
        // registrados; mientras un pedido siga Pendiente la mercadería no salió, así que se le suma lo reservado.
        // Los productos en alerta (mínimo o máximo) van primero.
        public List<Producto> StockActivo()
        {
            List<Producto> lista = productos.ListarProductos().Where(p => Es(p.Estado, ESTADO_ACTIVO)).ToList();

            Dictionary<string, int> reservado =
                CantidadesPorProducto(TodosLosPedidos().Where(p => Es(p.Estado, ESTADO_PENDIENTE)));

            foreach (Producto p in lista)
            {
                int extra;
                if (reservado.TryGetValue((p.Descripcion ?? "").Trim(), out extra)) p.Stock += extra;   // solo para mostrar: no se guarda
            }

            return lista
                .OrderBy(p => (p.Stock <= p.StockMinimo || p.Stock >= p.StockMaximo) ? 0 : 1)
                .ThenBy(p => p.Stock - p.StockMinimo)
                .ToList();
        }
        #endregion

        #region Gráficos de ventas (solo pedidos facturados o despachados)
        //Cantidad de pedidos facturados por cliente, de mayor a menor.
        public List<KeyValuePair<string, int>> PedidosPorCliente()
        {
            return TodosLosPedidos()
                .Where(p => EstaFacturado(p) && EsReciente(p))
                .GroupBy(p => p.Cliente)
                .Select(g => new KeyValuePair<string, int>(g.Key, g.Count()))
                .OrderByDescending(kv => kv.Value)
                .ToList();
        }

        //Cajones vendidos por producto en pedidos facturados, de mayor a menor.
        public List<KeyValuePair<string, int>> ProductosVendidos()
        {
            return CantidadesPorProducto(TodosLosPedidos().Where(p => EstaFacturado(p) && EsReciente(p)))
                .Select(kv => new KeyValuePair<string, int>(kv.Key, kv.Value))
                .OrderByDescending(kv => kv.Value)
                .ToList();
        }
        #endregion

        #region Auxiliares
        private List<PedidoItem> TodosLosPedidos() { return pedidos.ObtenerPedidos(); }

        private static bool Es(string estado, string valor)
        {
            return string.Equals((estado ?? "").Trim(), valor, StringComparison.OrdinalIgnoreCase);
        }

        // Facturado o despachado = cualquier estado que no sea Pendiente ni Cancelado
        private static bool EstaFacturado(PedidoItem p)
        {
            return !Es(p.Estado, ESTADO_PENDIENTE) && !Es(p.Estado, ESTADO_CANCELADO);
        }

        private static bool EsReciente(PedidoItem p)
        {
            if (DIAS_VENTAS <= 0) return true;
            DateTime fecha;
            if (!DateTime.TryParse(p.Fecha, new CultureInfo("es-AR"), DateTimeStyles.None, out fecha)) return true;   // fecha ilegible: se incluye
            return fecha.Date >= DateTime.Today.AddDays(-DIAS_VENTAS);
        }

        //Suma las cantidades de cada producto en el detalle de los pedidos indicados
        private Dictionary<string, int> CantidadesPorProducto(IEnumerable<PedidoItem> lista)
        {
            Dictionary<string, int> total = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (PedidoItem ped in lista)
            {
                DataTable det = facturacion.ObtenerDetallesDelPedido(ped.Id);
                string colProducto = ColumnaProducto(det);
                if (colProducto == null || !det.Columns.Contains("Cantidad")) continue;

                foreach (DataRow r in det.Rows)
                {
                    string nombre = Convert.ToString(r[colProducto]).Trim();
                    int cantidad = Convert.ToInt32(r["Cantidad"]);
                    int actual;
                    total.TryGetValue(nombre, out actual);
                    total[nombre] = actual + cantidad;
                }
            }
            return total;
        }

        // Busca la columna con el nombre del producto en el detalle del pedido
        private static string ColumnaProducto(DataTable tabla)
        {
            foreach (string nombre in new[] { "Producto", "Descripcion", "Nombre", "Articulo" })
                if (tabla.Columns.Contains(nombre)) return nombre;
            foreach (DataColumn c in tabla.Columns)
                if (c.DataType == typeof(string)) return c.ColumnName;
            return null;
        }
        #endregion
    }
}
