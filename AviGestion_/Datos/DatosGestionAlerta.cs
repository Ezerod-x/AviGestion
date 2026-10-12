using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class AlertaVista
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public string TipoAlerta { get; set; }
        public string Estado { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime? FechaResolucion { get; set; }
    }

    public class ProductoAlertaResumen
    {
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public string Estado { get; set; }
        public int CantidadAlertasHistoricas { get; set; }
    }

    public class ConteoAgrupado
    {
        public string Etiqueta { get; set; }
        public int Cantidad { get; set; }
    }

    public class DatosAlerta
    {
        public List<AlertaVista> Listar(string filtroTexto, string tipoAlerta, string estado,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            var lista = new List<AlertaVista>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT a.Id, a.ProductoId, p.Codigo, p.Descripcion, p.Categoria,
                                      a.TipoAlerta, a.Estado, a.FechaGeneracion, a.FechaResolucion
                               FROM Alertas a
                               INNER JOIN Productos p ON p.Id = a.ProductoId
                               WHERE (p.Codigo LIKE @filtro OR p.Descripcion LIKE @filtro)
                                 AND (@tipo = 'Todas' OR a.TipoAlerta = @tipo)
                                 AND (@estado = 'Todas' OR a.Estado = @estado)
                                 AND (@fechaDesde IS NULL OR a.FechaGeneracion >= @fechaDesde)
                                 AND (@fechaHasta IS NULL OR a.FechaGeneracion <= @fechaHasta)
                               ORDER BY a.FechaGeneracion DESC";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + (filtroTexto ?? "") + "%");
                    cmd.Parameters.AddWithValue("@tipo", string.IsNullOrEmpty(tipoAlerta) ? "Todas" : tipoAlerta);
                    cmd.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(estado) ? "Todas" : estado);
                    cmd.Parameters.AddWithValue("@fechaDesde", (object)fechaDesde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaHasta", (object)fechaHasta ?? DBNull.Value);
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new AlertaVista
                            {
                                Id = (int)reader["Id"],
                                ProductoId = (int)reader["ProductoId"],
                                Codigo = reader["Codigo"].ToString(),
                                Producto = reader["Descripcion"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                TipoAlerta = reader["TipoAlerta"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                FechaGeneracion = (DateTime)reader["FechaGeneracion"],
                                FechaResolucion = reader["FechaResolucion"] == DBNull.Value
                                    ? (DateTime?)null
                                    : (DateTime)reader["FechaResolucion"]
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public ProductoAlertaResumen ObtenerResumenProducto(int productoId)
        {
            ProductoAlertaResumen resumen = null;
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT p.Id, p.Codigo, p.Descripcion, p.Categoria, p.Stock,
                                      p.StockMinimo, p.StockMaximo, p.Estado,
                                      (SELECT COUNT(*) FROM Alertas WHERE ProductoId = p.Id) AS CantidadAlertas
                               FROM Productos p WHERE p.Id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", productoId);
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resumen = new ProductoAlertaResumen
                            {
                                ProductoId = (int)reader["Id"],
                                Codigo = reader["Codigo"].ToString(),
                                Producto = reader["Descripcion"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Stock = (int)reader["Stock"],
                                StockMinimo = (int)reader["StockMinimo"],
                                StockMaximo = (int)reader["StockMaximo"],
                                Estado = reader["Estado"].ToString(),
                                CantidadAlertasHistoricas = (int)reader["CantidadAlertas"]
                            };
                        }
                    }
                }
            }
            return resumen;
        }

        public List<ConteoAgrupado> ConteoPorTipo()
        {
            return EjecutarConteo(@"SELECT TipoAlerta AS Etiqueta, COUNT(*) AS Cantidad
                                     FROM Alertas GROUP BY TipoAlerta ORDER BY Cantidad DESC");
        }

        public List<ConteoAgrupado> ConteoPorProducto()
        {
            return EjecutarConteo(@"SELECT p.Descripcion AS Etiqueta, COUNT(*) AS Cantidad
                                     FROM Alertas a INNER JOIN Productos p ON p.Id = a.ProductoId
                                     GROUP BY p.Descripcion ORDER BY Cantidad DESC");
        }

        public List<ConteoAgrupado> ConteoPorCategoria()
        {
            return EjecutarConteo(@"SELECT p.Categoria AS Etiqueta, COUNT(*) AS Cantidad
                                     FROM Alertas a INNER JOIN Productos p ON p.Id = a.ProductoId
                                     GROUP BY p.Categoria ORDER BY Cantidad DESC");
        }

        public List<ConteoAgrupado> ConteoPorMes()
        {
            return EjecutarConteo(@"SELECT FORMAT(a.FechaGeneracion, 'yyyy-MM') AS Etiqueta, COUNT(*) AS Cantidad
                                     FROM Alertas a
                                     GROUP BY FORMAT(a.FechaGeneracion, 'yyyy-MM')
                                     ORDER BY Etiqueta ASC");
        }

        private List<ConteoAgrupado> EjecutarConteo(string sql)
        {
            var lista = new List<ConteoAgrupado>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ConteoAgrupado
                            {
                                Etiqueta = reader["Etiqueta"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}