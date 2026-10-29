using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class Categoria
    {
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantProductos { get; set; }
    }

    public class CategoriaDatos
    {
        #region Obtener Categorias
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_ObtenerCategorias", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new Categoria
                        {
                            Id_Categoria = (int)dr["Id_Categoria"],
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            CantProductos = (int)dr["CantProductos"]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Buscar Categorias
        public List<Categoria> BuscarCategorias(string busqueda)
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_BuscarCategorias", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", busqueda);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new Categoria
                        {
                            Id_Categoria = (int)dr["Id_Categoria"],
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            CantProductos = (int)dr["CantProductos"]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar categorías: " + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Insertar Categoria
        public void InsertarCategoria(string nombre, string descripcion)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_InsertarCategoria", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Modificar Categoria
        public void ModificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    using (SqlTransaction tx = con.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("SP_ModificarCategoria", con, tx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                            cmd.ExecuteNonQuery();

                            // Los productos de la categoría muestran el nombre nuevo
                            SqlCommand prod = new SqlCommand(
                                "UPDATE Productos SET Categoria = @Nombre WHERE Id_Categoria = @Id_Categoria", con, tx);
                            prod.Parameters.AddWithValue("@Nombre", nombre);
                            prod.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                            prod.ExecuteNonQuery();

                            tx.Commit();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar categoría: " + ex.Message);
            }
        }
        #endregion

        #region Eliminar Categoria
        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}