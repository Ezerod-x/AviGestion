using System.Collections.Generic;
using System.Data.SqlClient;
using AviGestion_.Logica;
using AviGestion_.Seguridad;

namespace AviGestion_.Datos
{
    public class DatosProducto
    {
        public List<Producto> Listar()
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, StockMinimo, StockMaximo, Estado, DigitoVerificador 
                               FROM Productos";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(LeerProducto(reader));
                    }
                }
            }
            return lista;
        }

        public List<Producto> Buscar(string filtro)
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, StockMinimo, StockMaximo, Estado, DigitoVerificador 
                               FROM Productos 
                               WHERE Codigo LIKE @filtro OR Descripcion LIKE @filtro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(LeerProducto(reader));
                    }
                }
            }
            return lista;
        }

        private Producto LeerProducto(SqlDataReader reader)
        {
            return new Producto
            {
                Id = (int)reader["Id"],
                Codigo = reader["Codigo"].ToString(),
                Descripcion = reader["Descripcion"].ToString(),
                Categoria = reader["Categoria"].ToString(),
                Precio = (decimal)reader["Precio"],
                Stock = (int)reader["Stock"],
                StockMinimo = (int)reader["StockMinimo"],
                StockMaximo = (int)reader["StockMaximo"],
                Estado = reader["Estado"].ToString(),
                DigitoVerificador = (int)reader["DigitoVerificador"]
            };
        }

        // NUEVO: evita productos con el mismo código (causa de las filas duplicadas).
        // idExcluir sirve para que, al modificar un producto, no se choque consigo mismo.
        public bool ExisteCodigo(string codigo, int idExcluir)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT COUNT(1) FROM Productos WHERE Codigo = @codigo AND Id <> @idExcluir";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@idExcluir", idExcluir);
                    cn.Open();
                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }

        public void Registrar(Producto p)
        {
            p.DigitoVerificador = DigitoVerificador.Calcular(p.Codigo);
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Productos (Codigo, Descripcion, Categoria, Precio, Stock, StockMinimo, StockMaximo, Estado, DigitoVerificador) 
                               VALUES (@codigo, @descripcion, @categoria, @precio, @stock, @stockMinimo, @stockMaximo, @estado, @digito)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@stockMinimo", p.StockMinimo);
                    cmd.Parameters.AddWithValue("@stockMaximo", p.StockMaximo);
                    cmd.Parameters.AddWithValue("@estado", p.Estado);
                    cmd.Parameters.AddWithValue("@digito", p.DigitoVerificador);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Producto p)
        {
            p.DigitoVerificador = DigitoVerificador.Calcular(p.Codigo);
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Productos SET Codigo=@codigo, Descripcion=@descripcion, 
                               Categoria=@categoria, Precio=@precio, Stock=@stock, 
                               StockMinimo=@stockMinimo, StockMaximo=@stockMaximo, Estado=@estado, DigitoVerificador=@digito 
                               WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@stockMinimo", p.StockMinimo);
                    cmd.Parameters.AddWithValue("@stockMaximo", p.StockMaximo);
                    cmd.Parameters.AddWithValue("@estado", p.Estado);
                    cmd.Parameters.AddWithValue("@digito", p.DigitoVerificador);
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Productos WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}