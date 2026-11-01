using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class EntregaDatos
    {
        // Usuarios registrados que pueden figurar como responsable
        public DataTable ObtenerResponsables()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Entregas_ObtenerResponsables", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            //El combo del formulario usa las columnas "Id" y "Nombre".
            // Se renombran por posición (1ª = Id, 2ª = Nombre) para que funcione aunque
            // la tabla Usuarios use otros nombres de columna.
            if (tabla.Columns.Count < 2)
                throw new Exception("SP_Entregas_ObtenerResponsables debe devolver el Id y el Nombre del usuario.");

            tabla.Columns[0].ColumnName = "Id";
            tabla.Columns[1].ColumnName = "Nombre";
            return tabla;
        }

        // Devuelve el código del SP: 0 = OK | 1 = camión ya no está en camino | 2 = pedidos cambiaron
        //                            3 = responsable no registrado | 4 = falta el comprobante
        public int RegistrarEntrega(int idVehiculo, int idResponsable, string entregados, string noEntregados,
                                    string nombreArchivo, string tipoArchivo, byte[] comprobante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Entregas_Registrar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Vehiculo", idVehiculo);
                cmd.Parameters.AddWithValue("@Id_Responsable", idResponsable);
                cmd.Parameters.AddWithValue("@Entregados", entregados);
                cmd.Parameters.AddWithValue("@NoEntregados", noEntregados);
                cmd.Parameters.AddWithValue("@ComprobanteNombre", (object)nombreArchivo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ComprobanteTipo", (object)tipoArchivo ?? DBNull.Value);
                cmd.Parameters.Add("@Comprobante", SqlDbType.VarBinary, -1).Value = (object)comprobante ?? DBNull.Value;

                SqlParameter pResultado = new SqlParameter("@Resultado", SqlDbType.Int);
                pResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pResultado);

                cn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(pResultado.Value);
            }
        }

        #region Historial
        // Entregas realizadas entre dos fechas
        public DataTable ObtenerHistorial(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Entregas_Historial", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Desde", SqlDbType.Date).Value = desde.Date;
                cmd.Parameters.Add("@Hasta", SqlDbType.Date).Value = hasta.Date;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // Pedidos de una entrega y qué pasó con cada uno
        public DataTable ObtenerDetalleEntrega(int idEntrega)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Entregas_HistorialDetalle", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Entrega", idEntrega);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // Imagen del comprobante (null si la entrega no tiene)
        public byte[] ObtenerComprobante(int idEntrega, out string nombreArchivo)
        {
            nombreArchivo = null;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Entregas_ObtenerComprobante", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Entrega", idEntrega);

                cn.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (!lector.Read()) return null;

                    nombreArchivo = lector["ComprobanteNombre"] == DBNull.Value ? null : lector["ComprobanteNombre"].ToString();
                    return lector["Comprobante"] == DBNull.Value ? null : (byte[])lector["Comprobante"];
                }
            }
        }
        #endregion
    }
}
