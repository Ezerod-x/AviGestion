using System;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class DatosBackup
    {
        public void GenerarBackupCompleto(string rutaArchivo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = $@"BACKUP DATABASE [Avigestion] TO DISK = @ruta WITH INIT, FORMAT, NAME = 'Backup Full AviGestion'";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.CommandTimeout = 300; // backups pueden tardar
                    cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}