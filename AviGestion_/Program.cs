using AviGestion_.Interfaz;
using AviGestion_.Logica;
using AviGestion_.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MigracionContrasenas.Ejecutar();   // pasa a SHA256 las contraseñas que estén en texto plano
            BackupLogica.IniciarBackupAutomatico();   // backup diario automático mientras la aplicación esté abierta
            Application.Run(new Form1());
        }
    }
}