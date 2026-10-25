using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class FacturacionDatos 
    {
        // Grilla superior: pedidos pendientes de facturar (últimos 30 días)
        public List<PagoPedido> ObtenerPedidosPendientes()
        {
            List<PagoPedido> lista = new List<PagoPedido>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Facturacion_ObtenerPendientes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PagoPedido p = new PagoPedido();
                        p.NºPedido = Convert.ToInt32(reader["Id_Pedido"]);
                        p.Cliente = reader["Cliente"].ToString();
                        p.Fecha = Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy");
                        p.Estado = reader["Estado"].ToString();
                        p.Productos = reader["Productos"].ToString();
                        p.Total = Convert.ToDecimal(reader["Total"]);
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        // Panel inferior: artículos del pedido
        public DataTable ObtenerDetallesDelPedido(int idPedido)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Facturacion_ObtenerDetalle", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla); // abre y cierra la conexión solo
                }
            }
            return tabla;
        }

        // Confirmar despacho: toda la transacción vive en el SP
        public ResultadoDespacho ConfirmarDespacho(int idPedido)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Facturacion_ConfirmarDespacho", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);

                SqlParameter pResultado = new SqlParameter("@Resultado", SqlDbType.Int);
                pResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pResultado);

                cn.Open();
                cmd.ExecuteNonQuery();

                return (ResultadoDespacho)Convert.ToInt32(pResultado.Value);
            }
        }

        // Mini historial: pedidos facturados en un día (por defecto, hoy)
        public DataTable ObtenerFacturadosPorFecha(DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Facturacion_ObtenerFacturadosPorFecha", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha.Date;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
