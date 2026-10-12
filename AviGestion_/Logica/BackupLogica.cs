using System;
using System.IO;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class BackupLogica
    {
        private DatosBackup datos = new DatosBackup();

        public string GenerarBackup(string carpetaDestino, string usuarioActual, string rolActual)
        {
            // CU-06, flujo alternativo 2.1: solo administrador.
            if (rolActual != "Administrador")
                throw new Exception("No cuenta con los permisos necesarios para realizar esta operación.");

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
    }
}