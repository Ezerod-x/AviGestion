using System.Data;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class DatosAsignacion
    {
        // Pedidos de un estado, con cliente, total de cajas y camión (si tiene)
        public DataTable PedidosPorEstado(string estado)
        {
            string sql = @"
                SELECT pc.Id_Pedido,
                       CONCAT(c.Nombre, ' ', ISNULL(c.Apellido, '')) AS Cliente,
                       pc.Fecha,
                       ISNULL((SELECT SUM(d.Cantidad)
                               FROM DetallePedidoCompra d
                               WHERE d.Id_Pedido = pc.Id_Pedido), 0) AS Cajas,
                       pc.Id_Vehiculo,
                       v.Patente, v.Marca, v.Modelo
                FROM PedidosCompra pc
                INNER JOIN Cliente c ON pc.Id_Cliente = c.Id_Cliente
                LEFT JOIN Vehiculos v ON pc.Id_Vehiculo = v.Id
                WHERE pc.Estado = @Estado
                ORDER BY pc.Id_Pedido DESC";

            var tabla = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@Estado", estado);
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // Vehículos con su estado y las cajas que todavía les entran (Libres)
        public DataTable Vehiculos()
        {
            string sql = @"
                SELECT Id, Marca, Modelo, Patente, CapacidadMax, CapacidadActual,
                       (CapacidadMax - CapacidadActual) AS Libres,
                       Estado
                FROM Vehiculos
                ORDER BY Patente";

            var tabla = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        // Valida capacidad, suma las cajas al camión y pasa el pedido a "En camión"
        public void Asignar(int idPedido, int idVehiculo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("SP_AsignarPedidoAVehiculo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
                cmd.Parameters.AddWithValue("@Id_Vehiculo", idVehiculo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Saca el pedido del camión y lo devuelve a "En preparación"
        public void Quitar(int idPedido)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("SP_QuitarPedidoDeVehiculo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Camión salió: el camión y sus pedidos pasan a "En camino"
        public void Despachar(int idVehiculo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("SP_DespacharVehiculo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Vehiculo", idVehiculo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}