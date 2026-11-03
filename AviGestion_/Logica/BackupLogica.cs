using System;
using System.IO;
using System.Threading;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class BackupLogica
    {
        private DatosBackup datos = new DatosBackup();

        
        // DÍAS QUE SE CONSERVAN LOS BACKUPS AUTOMÁTICOS
       
        public const int DIAS_RETENCION_BACKUPS = 30;

        
        private static int ocupado = 0;
        private static Timer temporizadorAutomatico;

        
        public string GenerarBackup(string carpetaDestino, string usuarioActual, string rolActual)
        {
            
            ValidarAdministrador(rolActual);

            if (string.IsNullOrWhiteSpace(carpetaDestino) || !Directory.Exists(carpetaDestino))
                throw new Exception("Seleccioná una carpeta de destino válida.");

            string nombreArchivo = $"AviGestion_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

            try
            {
                datos.GenerarBackupCompleto(rutaCompleta);
            }
            catch (Exception ex)
            {
                BitacoraLogica.Registrar(usuarioActual, "Backup", "Backup", $"Error al generar backup: {ex.Message}");
                throw new Exception("Ocurrió un error al generar el backup: " + ex.Message);
            }

            BitacoraLogica.Registrar(usuarioActual, "Backup", "Backup", $"Backup generado en: {rutaCompleta}");
            return rutaCompleta;
        }

        //  RESTAURAR
        // Reemplaza TODA la base de datos actual por el contenido del backup elegido.
        public void RestaurarBackup(string rutaArchivo, string usuarioActual, string rolActual)
        {
            ValidarAdministrador(rolActual);

            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new Exception("Seleccioná el archivo de backup (.bak) que querés restaurar.");
            if (!File.Exists(rutaArchivo))
                throw new Exception("No se encontró el archivo seleccionado.\n" +
                    "Si la base de datos está en otro equipo (servidor), el archivo tiene que estar en ese equipo.");

            if (Interlocked.Exchange(ref ocupado, 1) == 1)
                throw new Exception("Hay otro backup o restauración en curso. Esperá unos segundos e intentá de nuevo.");

            try
            {
                // 1) El archivo tiene que ser un backup válido de AviGestion.
                datos.ValidarArchivoBackup(rutaArchivo);

                // 2) Copia de seguridad previa de lo que hay hoy, por si hay que volver atrás.
                string copiaPrevia = null;
                try
                {
                    copiaPrevia = Path.Combine(datos.CarpetaBackupPorDefecto(),
                        $"AviGestion_AntesDeRestaurar_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                    datos.GenerarBackupCompleto(copiaPrevia, "Copia previa a restauracion AviGestion");
                }
                catch { copiaPrevia = null; }   // si la base actual está dañada o no existe, se sigue igual

                // 3) Restauración.
                try
                {
                    datos.RestaurarBackup(rutaArchivo);
                }
                catch (Exception ex)
                {
                    BitacoraLogica.Registrar(usuarioActual, "Backup", "Backup", $"Error al restaurar backup: {ex.Message}");
                    throw new Exception("Ocurrió un error al restaurar el backup: " + ex.Message);
                }

                // Se registra DESPUÉS de restaurar: la bitácora de la base restaurada es la del backup.
                BitacoraLogica.Registrar(usuarioActual, "Backup", "Backup",
                    $"Base restaurada desde: {rutaArchivo}" +
                    (copiaPrevia != null ? $" | Copia previa guardada en: {copiaPrevia}" : ""));
            }
            finally
            {
                Interlocked.Exchange(ref ocupado, 0);
            }
        }

        // BACKUP AUTOMÁTICO DIARIO
        // Se llama una sola vez al iniciar la aplicación (Program.cs). Revisa cada hora si ya
        // se hizo el backup del día y, si no, lo genera en la carpeta de backups del SQL Server.
        public static void IniciarBackupAutomatico()
        {
            if (temporizadorAutomatico != null) return;
            temporizadorAutomatico = new Timer(_ => EjecutarBackupAutomaticoSiCorresponde(),
                null, TimeSpan.FromSeconds(20), TimeSpan.FromHours(1));
        }

        public static void EjecutarBackupAutomaticoSiCorresponde()
        {
            if (Interlocked.Exchange(ref ocupado, 1) == 1) return;   
            try
            {
                var datos = new DatosBackup();
                if (datos.ExisteBackupAutomaticoHoy()) return;

                string ruta = Path.Combine(datos.CarpetaBackupPorDefecto(),
                    $"AviGestion_Auto_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

                datos.GenerarBackupCompleto(ruta, DatosBackup.NOMBRE_BACKUP_AUTOMATICO);
                BitacoraLogica.Registrar("Sistema", "Backup", "Backup", $"Backup automático diario generado en: {ruta}");

                BorrarBackupsViejos(datos.CarpetaBackupPorDefecto());
            }
            catch (Exception ex)
            {
                BitacoraLogica.Registrar("Sistema", "Backup", "Backup", $"Error en backup automático diario: {ex.Message}");
            }
            finally
            {
                Interlocked.Exchange(ref ocupado, 0);
            }
        }

        // Borra los backups automáticos que superan DIAS_RETENCION_BACKUPS días.
        // Solo toca archivos creados por el sistema (nombres AviGestion_Auto_*.bak y
        // AviGestion_AntesDeRestaurar_*.bak) dentro de la carpeta de backups automáticos.
        private static void BorrarBackupsViejos(string carpeta)
        {
            if (DIAS_RETENCION_BACKUPS <= 0) return;
            if (string.IsNullOrWhiteSpace(carpeta) || !Directory.Exists(carpeta)) return;

            DateTime limite = DateTime.Now.AddDays(-DIAS_RETENCION_BACKUPS);
            int borrados = 0;

            foreach (string patron in new[] { "AviGestion_Auto_*.bak", "AviGestion_AntesDeRestaurar_*.bak" })
            {
                foreach (string archivo in Directory.GetFiles(carpeta, patron))
                {
                    try
                    {
                        if (File.GetLastWriteTime(archivo) < limite)
                        {
                            File.Delete(archivo);
                            borrados++;
                        }
                    }
                    catch
                    {
                        
                    }
                }
            }

            if (borrados > 0)
                BitacoraLogica.Registrar("Sistema", "Backup", "Backup",
                    $"Se borraron {borrados} backup(s) automático(s) con más de {DIAS_RETENCION_BACKUPS} días.");
        }

        // Cantidad de días que se conservan los backups automáticos (para mostrarlo en pantalla).
        public int DiasRetencion { get { return DIAS_RETENCION_BACKUPS; } }

        // Datos para mostrar en la pantalla de Backup.
        public string CarpetaBackupsAutomaticos() { return datos.CarpetaBackupPorDefecto(); }
        public DateTime? UltimoBackupAutomatico() { return datos.UltimoBackupAutomatico(); }

        private void ValidarAdministrador(string rolActual)
        {
            if (rolActual != "Administrador")
                throw new Exception("No cuenta con los permisos necesarios para realizar esta operación.");
        }
    }
}