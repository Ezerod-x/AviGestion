using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class ClienteDatos
    {
        public List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string query = "SELECT Id_Cliente, Nombre, Apellido, Direccion, Empresa, Telefono, CorreoElectronico, DniCuil FROM Cliente";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente nuevoCliente = new Cliente();

                            nuevoCliente.Id_Cliente = Convert.ToInt32(reader["Id_Cliente"]);
                            nuevoCliente.Nombre = reader["Nombre"].ToString();
                            nuevoCliente.Empresa = reader["Empresa"].ToString();
                            nuevoCliente.Direccion = reader["Direccion"].ToString();
                            nuevoCliente.Telefono = reader["Telefono"].ToString();
                            nuevoCliente.CorreoElectronico = reader["CorreoElectronico"].ToString();
                            nuevoCliente.DniCuil = reader["DniCuil"].ToString();
                            nuevoCliente.Apellido = reader["Apellido"].ToString();

                            lista.Add(nuevoCliente);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los clientes: " + ex.Message);
                }
            }

            return lista;
        }

        public void Insertar(Cliente cliente)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                string query = @"INSERT INTO Cliente 
                (Nombre, Apellido, Direccion, Empresa, Telefono, CorreoElectronico, DniCuil) 
                VALUES (@Nombre, @Apellido, @Direccion, @Empresa, @Telefono, @CorreoElectronico, @DniCuil)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Empresa", cliente.Empresa ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DniCuil", cliente.DniCuil ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
        public void Modificar(Cliente cliente)
        {
            string query = @"UPDATE Cliente 
                     SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, 
                         Empresa = @Empresa, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico, DniCuil = @DniCuil 
                     WHERE Id_Cliente = @Id_Cliente";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Empresa", cliente.Empresa ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DniCuil", cliente.DniCuil ?? (object)DBNull.Value);

                try { con.Open(); cmd.ExecuteNonQuery(); }
                catch (Exception ex) { throw new Exception("Error al modificar: " + ex.Message); }
            }
        }
    }
}
