using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace AviGestion_.Datos
{
    public class DatosBackup
    {
        public const string NOMBRE_BACKUP_MANUAL = "Backup Full AviGestion";
        public const string NOMBRE_BACKUP_AUTOMATICO = "Backup Automatico AviGestion";

        
        public void GenerarBackupCompleto(string rutaArchivo)
        {
            GenerarBackupCompleto(rutaArchivo, NOMBRE_BACKUP_MANUAL);
        }

        public void GenerarBackupCompleto(string rutaArchivo, string nombreBackup)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"BACKUP DATABASE [Avigestion] TO DISK = @ruta WITH INIT, FORMAT, NAME = @nombre";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.CommandTimeout = 300; 
                    cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                    cmd.Parameters.AddWithValue("@nombre", nombreBackup);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public string CarpetaBackupPorDefecto()
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexionMaster())
                {
                    string sql = @"DECLARE @d NVARCHAR(4000);
                                   EXEC master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE',
                                        N'Software\Microsoft\MSSQLServer\MSSQLServer', N'BackupDirectory', @d OUTPUT;
                                   SELECT @d;";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cn.Open();
                        object r = cmd.ExecuteScalar();
                        if (r != null && r != DBNull.Value && !string.IsNullOrWhiteSpace(r.ToString()))
                            return r.ToString();
                    }
                }
            }
            catch { }

            
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "AviGestion", "Backups");
            Directory.CreateDirectory(carpeta);
            return carpeta;
        }

        
        public bool ExisteBackupAutomaticoHoy()
        {
            using (SqlConnection cn = Conexion.ObtenerConexionMaster())
            {
                string sql = @"SELECT COUNT(*) FROM msdb.dbo.backupset
                               WHERE database_name = 'Avigestion' AND type = 'D' AND name = @nombre
                                 AND backup_start_date >= CAST(GETDATE() AS date)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", NOMBRE_BACKUP_AUTOMATICO);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public DateTime? UltimoBackupAutomatico()
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexionMaster())
                {
                    string sql = @"SELECT MAX(backup_finish_date) FROM msdb.dbo.backupset
                                   WHERE database_name = 'Avigestion' AND type = 'D' AND name = @nombre";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", NOMBRE_BACKUP_AUTOMATICO);
                        cn.Open();
                        object r = cmd.ExecuteScalar();
                        return (r == null || r == DBNull.Value) ? (DateTime?)null : (DateTime)r;
                    }
                }
            }
            catch { return null; }
        }

        // RESTAURAR
        // Verifica que el archivo sea un backup válido de SQL Server y que sea de la base Avigestion.
        public void ValidarArchivoBackup(string rutaArchivo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexionMaster())
            {
                cn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("RESTORE VERIFYONLY FROM DISK = @ruta", cn))
                    {
                        cmd.CommandTimeout = 300;
                        cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("El archivo seleccionado no es un backup válido o está dañado. (" + ex.Message + ")");
                }

                string baseOrigen = null;
                using (SqlCommand cmd = new SqlCommand("RESTORE HEADERONLY FROM DISK = @ruta", cn))
                {
                    cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read()) baseOrigen = r["DatabaseName"].ToString();
                    }
                }

                if (!string.Equals(baseOrigen, "Avigestion", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("El archivo seleccionado no corresponde a una copia de la base AviGestion.");
            }
        }

        // Reemplaza la base Avigestion por el contenido del backup.
        public void RestaurarBackup(string rutaArchivo)
        {
            SqlConnection.ClearAllPools();   // cierra las conexiones abiertas de la aplicación

            using (SqlConnection cn = Conexion.ObtenerConexionMaster())
            {
                cn.Open();

                bool existe;
                using (SqlCommand cmd = new SqlCommand("SELECT CASE WHEN DB_ID('Avigestion') IS NULL THEN 0 ELSE 1 END", cn))
                    existe = Convert.ToInt32(cmd.ExecuteScalar()) == 1;

                try
                {
                    if (existe)
                        Ejecutar(cn, "ALTER DATABASE [Avigestion] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");

                    using (SqlCommand cmd = new SqlCommand(
                        "RESTORE DATABASE [Avigestion] FROM DISK = @ruta WITH REPLACE, RECOVERY", cn))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    
                    try { Ejecutar(cn, "ALTER DATABASE [Avigestion] SET MULTI_USER WITH ROLLBACK IMMEDIATE"); } catch { }
                }
            }

            SqlConnection.ClearAllPools();
        }

        private void Ejecutar(SqlConnection cn, string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.CommandTimeout = 120;
                cmd.ExecuteNonQuery();
            }
        }
    }
}