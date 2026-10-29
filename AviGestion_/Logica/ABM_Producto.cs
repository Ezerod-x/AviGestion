using AviGestion_.Datos;
using AviGestion_.Seguridad;
using System;
using System.Collections.Generic;

namespace AviGestion_.Logica
{
    public class ABM_Producto
    {
        private DatosProducto datos = new DatosProducto();
        private CategoriaLogica categorias = new CategoriaLogica();

        // Categorías cargadas en el módulo de Categorías (para el combo de Productos)
        public List<Categoria> ObtenerCategorias()
        {
            return categorias.ObtenerCategorias();
        }

        // Completa el vínculo producto-categoría en los productos viejos
        public void VincularCategorias()
        {
            datos.VincularCategorias();
        }

        public List<Producto> ListarProductos()
        {
            return datos.Listar();
        }

        public List<Producto> BuscarProductos(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return datos.Listar();
            return datos.Buscar(filtro);
        }

        public void GuardarProducto(Producto p, string usuarioActual = "Sistema")
        {
            if (string.IsNullOrWhiteSpace(p.Codigo))
                throw new Exception("El código es obligatorio.");
            if (string.IsNullOrWhiteSpace(p.Descripcion))
                throw new Exception("La descripción es obligatoria.");
            if (p.Id_Categoria <= 0 || string.IsNullOrWhiteSpace(p.Categoria))
                throw new Exception("La categoría es obligatoria.");
            if (string.IsNullOrWhiteSpace(p.Estado))
                throw new Exception("El estado es obligatorio.");
            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");
            if (p.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");
            if (p.StockMinimo < 0 || p.StockMaximo < 0)
                throw new Exception("El stock mínimo y máximo no pueden ser negativos.");
            if (p.StockMinimo >= p.StockMaximo)
                throw new Exception("El stock mínimo debe ser menor al stock máximo.");

            // NUEVO: evita registrar dos veces el mismo código de producto.
            if (datos.ExisteCodigo(p.Codigo, p.Id))
                throw new Exception($"Ya existe un producto registrado con el código '{p.Codigo}'.");

            bool esAlta = p.Id == 0;

            // Antes de modificar, verifica que el producto no haya sido alterado
            // por fuera del sistema (dígito verificador).
            if (!esAlta)
            {
                var existente = datos.Listar().Find(x => x.Id == p.Id);
                ValidarIntegridad(existente, usuarioActual, "modificar");
            }

            if (esAlta)
                datos.Registrar(p);
            else
                datos.Modificar(p);

            BitacoraLogica.Registrar(usuarioActual, esAlta ? "Alta" : "Modificación", "Productos",
                $"Código: {p.Codigo} - {p.Descripcion}");

            // El stock mínimo/máximo o el stock pudieron cambiar: se actualizan las alertas.
            new StockLogica().SincronizarAlertas();
        }

        public void EliminarProducto(int id, string usuarioActual = "Sistema")
        {
            var producto = datos.Listar().Find(x => x.Id == id);
            ValidarIntegridad(producto, usuarioActual, "eliminar");

            datos.Eliminar(id);

            BitacoraLogica.Registrar(usuarioActual, "Baja", "Productos",
                producto != null ? $"Código: {producto.Codigo} - {producto.Descripcion}" : $"Id={id}");
        }

        private void ValidarIntegridad(Producto producto, string usuarioActual, string operacion)
        {
            if (producto == null) return;

            if (!DigitoVerificador.Validar(producto.Codigo, producto.DigitoVerificador))
            {
                BitacoraLogica.Registrar(usuarioActual, "Bloqueo por Integridad", "Productos",
                    $"Dígito verificador inválido al intentar {operacion} el producto Id={producto.Id} ({producto.Codigo}).");

                throw new Exception("Se detectó una inconsistencia en los datos del producto (el dígito verificador no coincide). " +
                    "El sistema bloqueó esta operación. Consulte con el administrador.");
            }
        }
    }
}