using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class UsuarioDatos
    {
        public Usuario ObtenerUsuarioPorNombre(string nombre)
        {
            Usuario usuario = null;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT idUsuario, Nombre, Apellido, Contrasena, Rol, Mail FROM Usuarios WHERE Nombre = @Nombre";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    usuario = new Usuario
                    {
                        IdUsuario = (int)lector["idUsuario"],
                        Nombre = lector["Nombre"].ToString(),
                        Apellido = lector["Apellido"].ToString(),
                        Contrasena = lector["Contrasena"].ToString(),
                        Rol = lector["Rol"].ToString(),
                        Mail = lector["Mail"] == DBNull.Value ? "" : lector["Mail"].ToString()
                    };
                }
            }

            return usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT idUsuario, Nombre, Apellido, Contrasena, Rol, Mail FROM Usuarios";

                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        IdUsuario = (int)lector["idUsuario"],
                        Nombre = lector["Nombre"].ToString(),
                        Apellido = lector["Apellido"].ToString(),
                        Contrasena = lector["Contrasena"].ToString(),
                        Rol = lector["Rol"].ToString(),
                        Mail = lector["Mail"] == DBNull.Value ? "" : lector["Mail"].ToString()
                    });
                }
            }

            return usuarios;
        }

        public void Insertar(Usuario usuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, Contrasena, Rol, Mail) " +
                                "VALUES (@Nombre, @Apellido, @Contrasena, @Rol, @Mail)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                comando.Parameters.AddWithValue("@Rol", usuario.Rol);
                comando.Parameters.AddWithValue("@Mail", usuario.Mail);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(Usuario usuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, " +
                                "Contrasena = @Contrasena, Rol = @Rol WHERE idUsuario = @IdUsuario";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                comando.Parameters.AddWithValue("@Rol", usuario.Rol);
                comando.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Usuarios WHERE idUsuario = @IdUsuario";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public Usuario ObtenerUsuarioPorMail(string mail)
        {
            Usuario usuario = null;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT idUsuario, Nombre, Apellido, Contrasena, Rol, Mail " +
                                "FROM Usuarios WHERE Mail = @Mail";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Mail", mail);

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    usuario = new Usuario
                    {
                        IdUsuario = (int)lector["idUsuario"],
                        Nombre = lector["Nombre"].ToString(),
                        Apellido = lector["Apellido"].ToString(),
                        Contrasena = lector["Contrasena"].ToString(),
                        Rol = lector["Rol"].ToString(),
                        Mail = lector["Mail"] == DBNull.Value ? "" : lector["Mail"].ToString()
                    };
                }
            }

            return usuario;
        }

        public void ActualizarContrasena(int idUsuario, string nuevaContrasena)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET Contrasena = @Contrasena WHERE idUsuario = @IdUsuario";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Contrasena", nuevaContrasena);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

    }

}
