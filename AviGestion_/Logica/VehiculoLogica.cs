using System;
using System.Collections.Generic;
using AviGestion_.Datos;
using AviGestion_.Interfaz;

namespace AviGestion_.Logica
{
    /// <summary>
    /// Excepción para errores de validación / reglas de negocio.
    /// Su mensaje se puede mostrar directo al usuario.
    /// </summary>
    public class ReglaNegocioException : Exception
    {
        public ReglaNegocioException(string mensaje) : base(mensaje) { }
    }

    public class VehiculoLogica
    {
        private const string Activo = "Activo";
        private const string Inactivo = "Inactivo";
        
        private readonly VehiculoDAL _dal = new VehiculoDAL();

        public List<Vehiculo> ObtenerVehiculos()
        {
            return _dal.ObtenerTodos();
        }

        public int Registrar(Vehiculo vehiculo)
        {
            Normalizar(vehiculo);
            vehiculo.CapacidadActual = 0; // un vehículo nuevo arranca sin carga
            Validar(vehiculo);

            if (_dal.ExistePatente(vehiculo.Patente))
                throw new ReglaNegocioException("Ya existe un vehículo con la patente " + vehiculo.Patente + ".");

            return _dal.Agregar(vehiculo);
        }

        public void Modificar(Vehiculo vehiculo)
        {
            if (vehiculo.Id <= 0)
                throw new ReglaNegocioException("No hay un vehículo seleccionado para modificar.");

            Normalizar(vehiculo);
            Validar(vehiculo);

            if (_dal.ExistePatente(vehiculo.Patente, vehiculo.Id))
                throw new ReglaNegocioException("Ya existe otro vehículo con la patente " + vehiculo.Patente + ".");

            if (!_dal.Actualizar(vehiculo))
                throw new ReglaNegocioException("El vehículo ya no existe en la base de datos.");
        }

        public void DarDeBaja(int id)
        {
            CambiarEstado(id, Inactivo);
        }

        public void Reactivar(int id)
        {
            CambiarEstado(id, Activo);
        }

        private void CambiarEstado(int id, string estado)
        {
            if (!_dal.CambiarEstado(id, estado))
                throw new ReglaNegocioException("No se encontró el vehículo en la base de datos.");
        }

        private static void Normalizar(Vehiculo v)
        {
            v.Marca = (v.Marca ?? string.Empty).Trim();
            v.Modelo = (v.Modelo ?? string.Empty).Trim();
            v.Patente = (v.Patente ?? string.Empty).Trim().ToUpper();
            v.Estado = string.IsNullOrWhiteSpace(v.Estado) ? Activo : v.Estado.Trim();
        }

        private static void Validar(Vehiculo v)
        {
            if (v.Marca.Length == 0)
                throw new ReglaNegocioException("Seleccioná una marca.");
            if (v.Marca.Length > 50)
                throw new ReglaNegocioException("La marca no puede superar los 50 caracteres.");

            if (v.Modelo.Length == 0)
                throw new ReglaNegocioException("Ingresá el modelo.");
            if (v.Modelo.Length > 50)
                throw new ReglaNegocioException("El modelo no puede superar los 50 caracteres.");

            if (v.Patente.Length == 0)
                throw new ReglaNegocioException("Ingresá la patente.");
            if (v.Patente.Length > 20)
                throw new ReglaNegocioException("La patente no puede superar los 20 caracteres.");

            if (v.CapacidadMax <= 0)
                throw new ReglaNegocioException("Ingresá una capacidad máxima mayor a 0.");
            if (v.CapacidadMax < v.CapacidadActual)
                throw new ReglaNegocioException(
                    "La capacidad máxima no puede ser menor a la capacidad actual (" + v.CapacidadActual + " Kg).");

            // Agregamos Disponible a las opciones válidas
            if (v.Estado != Activo && v.Estado != Inactivo && v.Estado != "Disponible")
                throw new ReglaNegocioException("El estado debe ser Activo, Inactivo o Disponible.");
        }
    }
}