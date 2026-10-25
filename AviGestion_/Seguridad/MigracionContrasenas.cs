using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AviGestion_.Seguridad
{
    // Pasa a SHA256 las contraseñas que todavía están en texto plano en la tabla Usuarios.
    // Se ejecuta al iniciar el sistema y es seguro repetirla: solo toca las que NO miden 64 caracteres
  
    public static class MigracionContrasenas
    {
        public static void Ejecutar()
        {
            try
            {
                List<KeyValuePair<int, string>> pendientes = new List<KeyValuePair<int, string>>();

                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT idUsuario, Contrasena FROM Usuarios WHERE LEN(Contrasena) <> 64", cn))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                            pendientes.Add(new KeyValuePair<int, string>(lector.GetInt32(0), lector.GetString(1)));
                    }

                    foreach (KeyValuePair<int, string> usuario in pendientes)
                    {
                        using (SqlCommand upd = new SqlCommand(
                            "UPDATE Usuarios SET Contrasena = @Contrasena WHERE idUsuario = @IdUsuario", cn))
                        {
                            upd.Parameters.AddWithValue("@Contrasena", Encriptador.EncriptarSHA256(usuario.Value.Trim()));
                            upd.Parameters.AddWithValue("@IdUsuario", usuario.Key);
                            upd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch
            {
                // Si no hay conexión, el login mostrará su propio error: acá no se interrumpe el inicio.
            }
        }
    }
}