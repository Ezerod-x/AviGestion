using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class RegistroBitacora
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Modulo { get; set; }
        public string Detalle { get; set; }
    }

    public class DatosBitacora
    {
        public void Registrar(string usuario, string accion, string modulo, string detalle)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Bitacora (Fecha, Usuario, Accion, Modulo, Detalle)
                               VALUES (GETDATE(), @usuario, @accion, @modulo, @detalle)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario ?? "Desconocido");
                    cmd.Parameters.AddWithValue("@accion", accion ?? "");
                    cmd.Parameters.AddWithValue("@modulo", modulo ?? "");
                    cmd.Parameters.AddWithValue("@detalle", (object)detalle ?? DBNull.Value);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<RegistroBitacora> Listar(string filtroUsuario, string filtroAccion, string filtroModulo,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            var lista = new List<RegistroBitacora>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Fecha, Usuario, Accion, Modulo, Detalle
                               FROM Bitacora
                               WHERE (@usuario = '' OR Usuario LIKE @usuarioLike)
                                 AND (@accion = 'Todas' OR Accion = @accion)
                                 AND (@modulo = 'Todos' OR Modulo = @modulo)
                                 AND (@fechaDesde IS NULL OR Fecha >= @fechaDesde)
                                 AND (@fechaHasta IS NULL OR Fecha <= @fechaHasta)
                               ORDER BY Fecha DESC";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    string usuario = filtroUsuario ?? "";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@usuarioLike", "%" + usuario + "%");
                    cmd.Parameters.AddWithValue("@accion", string.IsNullOrEmpty(filtroAccion) ? "Todas" : filtroAccion);
                    cmd.Parameters.AddWithValue("@modulo", string.IsNullOrEmpty(filtroModulo) ? "Todos" : filtroModulo);
                    cmd.Parameters.AddWithValue("@fechaDesde", (object)fechaDesde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaHasta", (object)fechaHasta ?? DBNull.Value);
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new RegistroBitacora
                            {
                                Id = (int)reader["Id"],
                                Fecha = (DateTime)reader["Fecha"],
                                Usuario = reader["Usuario"].ToString(),
                                Accion = reader["Accion"].ToString(),
                                Modulo = reader["Modulo"].ToString(),
                                Detalle = reader["Detalle"] == DBNull.Value ? "" : reader["Detalle"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}