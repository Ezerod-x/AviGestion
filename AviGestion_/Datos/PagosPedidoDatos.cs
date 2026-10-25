using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class PagosPedidoDatos//nuevo
    {
        public List<PagoPedido> ObtenerPedidosParaPagos()
        {
            List<PagoPedido> lista = new List<PagoPedido>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerPedidosParaPagos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PagoPedido ped = new PagoPedido
                            {
                                NºPedido = Convert.ToInt32(reader["Id_Pedido"]),
                                Cliente = reader["Cliente"].ToString(),
                                Fecha = reader["Fecha"].ToString(),
                                Estado = reader["Estado"].ToString(),      // estado de pago: Sin pagos / Parcial
                                Productos = reader["Productos"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalPedido"]),
                                SaldoPendiente = Convert.ToDecimal(reader["Saldo"]),
                                MetodoPago = reader["UltimoMetodo"].ToString()   // método del último cobro ('-' si no hay)
                            };
                            lista.Add(ped);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Falla en Stored Procedure de lectura de pagos: " + ex.Message);
                }
            }
            return lista;
        }

        // Devuelve el código del SP: 0 = OK | 1 = pedido no disponible | 2 = monto inválido o mayor al saldo
        public int RegistrarPagoTransaccional(int idPedido, decimal importeAbonar, string metodoPago)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarPagoPedido", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                cmd.Parameters.AddWithValue("@Monto", importeAbonar);
                cmd.Parameters.AddWithValue("@MetodoPago", metodoPago);

                SqlParameter pResultado = new SqlParameter("@Resultado", SqlDbType.Int);
                pResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pResultado);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return Convert.ToInt32(pResultado.Value);
                }
                catch (Exception ex)
                {
                    throw new Exception("Falla en Stored Procedure de registro de pagos: " + ex.Message);
                }
            }
        }
    }
}
