using System;
using System.Collections.Generic;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class ResultadoCargaStock
    {
        public int NuevoStock { get; set; }
        public string EstadoStock { get; set; }
        public string Mensaje { get; set; }
    }

    public class StockLogica
    {
        private DatosStock datos = new DatosStock();

        public List<Producto> ListarProductos()
        {
            return datos.ListarProductosConStock();
        }

        public List<Producto> BuscarProductos(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return datos.ListarProductosConStock();
            return datos.BuscarProductosConStock(filtro);
        }

        public void ValidarCantidad(int cantidad)
        {
            if (cantidad <= 0)
                throw new Exception("La cantidad ingresada debe ser un número entero mayor a 0.");
        }

        public ResultadoCargaStock RegistrarIngreso(Producto producto, int cantidadIngresada, string usuarioActual = "Sistema")
        {
            ValidarCantidad(cantidadIngresada);

            int nuevoStock = producto.Stock + cantidadIngresada;
            datos.ActualizarStockProducto(producto.Id, nuevoStock);

            
            producto.Stock = nuevoStock;
            string estado = producto.EstadoStock;

            ActualizarAlertas(producto.Id, estado);

            BitacoraLogica.Registrar(usuarioActual, "Modificación", "Stock",
                $"Ingreso de {cantidadIngresada} u. a {producto.Descripcion} ({producto.Codigo}). Nuevo stock: {nuevoStock}.");

            return new ResultadoCargaStock
            {
                NuevoStock = nuevoStock,
                EstadoStock = estado,
                Mensaje = "La carga de stock fue registrada correctamente."
            };
        }

        
        public void SincronizarAlertas()
        {
            foreach (var p in datos.ListarProductosConStock())
            {
                if (p.Estado != "Activo") continue;
                ActualizarAlertas(p.Id, p.EstadoStock);
            }
        }

        private void ActualizarAlertas(int idProducto, string estadoActual)
        {
            
            if (estadoActual != "Stock Mínimo")
                datos.ResolverAlertasActivas(idProducto, "Stock Mínimo");

            if (estadoActual != "Stock Máximo")
                datos.ResolverAlertasActivas(idProducto, "Stock Máximo");

            if (estadoActual == "Stock Mínimo" || estadoActual == "Stock Máximo")
            {
                var alertaExistente = datos.ObtenerAlertaActiva(idProducto, estadoActual);
                if (alertaExistente == null)
                {
                    datos.InsertarAlerta(new Alerta
                    {
                        ProductoId = idProducto,
                        TipoAlerta = estadoActual,
                        Estado = "Activa"
                    });
                }
            }
        }
    }
}