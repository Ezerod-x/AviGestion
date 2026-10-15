using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}