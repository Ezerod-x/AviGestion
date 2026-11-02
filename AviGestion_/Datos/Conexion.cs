using System;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class Conexion
    {
        private static string cadenaConexion =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=Avigestion;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        // Conexión a la base "master" del mismo servidor para restaurar backup
        
        public static SqlConnection ObtenerConexionMaster()
        {
            var b = new SqlConnectionStringBuilder(cadenaConexion);
            b.InitialCatalog = "master";
            return new SqlConnection(b.ConnectionString);
        }
    }
}