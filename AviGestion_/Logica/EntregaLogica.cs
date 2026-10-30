using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Drawing;


namespace AviGestion_.Logica
{
    public class EntregaLogica
    {
        private AsignacionLogica asignacion = new AsignacionLogica();   // se reutilizan sus consultas de lectura
        private EntregaDatos datos = new EntregaDatos();

        private const long TamanoMaximoBytes = 2 * 1024 * 1024;         // 2 MB

        // Camiones en reparto, con la cantidad de pedidos y de cajones que llevan.
        // Se arma a partir de los pedidos "En camino" (igual que el tablero de Asignar pedidos),
        // así coincide con lo que se ve en esa pantalla.
        public DataTable ListarCamionesEnCamino()
        {
            DataTable vehiculos = asignacion.Vehiculos();
            DataTable pedidos = asignacion.PedidosEnCamino();

            DataTable resultado = new DataTable();
            resultado.Columns.Add("Id", typeof(int));
            resultado.Columns.Add("Patente", typeof(string));
            resultado.Columns.Add("Vehiculo", typeof(string));
            resultado.Columns.Add("Capacidad", typeof(string));
            resultado.Columns.Add("Pedidos", typeof(int));
            resultado.Columns.Add("Cajones", typeof(int));
            resultado.Columns.Add("Estado", typeof(string));

            // Camiones distintos que tienen pedidos en camino
            List<int> ids = new List<int>();
            foreach (DataRow p in pedidos.Rows)
            {
                if (p["Id_Vehiculo"] == DBNull.Value) continue;
                int id = Convert.ToInt32(p["Id_Vehiculo"]);
                if (!ids.Contains(id)) ids.Add(id);
            }

            foreach (int id in ids)
            {
                DataRow[] suyos = pedidos.Select("Id_Vehiculo = " + id, "Id_Pedido");
                DataRow primero = suyos[0];

                int cajones = 0;
                foreach (DataRow p in suyos)
                    cajones += Convert.ToInt32(p["Cajas"]);

                DataRow[] veh = vehiculos.Select("Id = " + id);
                string capacidad = veh.Length > 0 ? Convert.ToInt32(veh[0]["CapacidadMax"]) + " cajones" : "-";

                resultado.Rows.Add(id,
                                   Convert.ToString(primero["Patente"]),
                                   Convert.ToString(primero["Marca"]) + " " + Convert.ToString(primero["Modelo"]),
                                   capacidad,
                                   suyos.Length,
                                   cajones,
                                   AsignacionLogica.VehiculoEnCamino);
            }

            resultado.DefaultView.Sort = "Patente";
            return resultado.DefaultView.ToTable();
        }

        // Pedidos que lleva un camión, todos tildados como entregados al empezar
        public DataTable ListarPedidosDelCamion(int idVehiculo)
        {
            DataTable pedidos = asignacion.PedidosEnCamino();

            DataTable resultado = new DataTable();
            resultado.Columns.Add("Entregado", typeof(bool));
            resultado.Columns.Add("Id_Pedido", typeof(int));
            resultado.Columns.Add("Cliente", typeof(string));
            resultado.Columns.Add("Cajas", typeof(int));
            resultado.Columns.Add("Estado", typeof(string));

            foreach (DataRow p in pedidos.Select("Id_Vehiculo = " + idVehiculo, "Id_Pedido"))
            {
                resultado.Rows.Add(true,
                                   Convert.ToInt32(p["Id_Pedido"]),
                                   Convert.ToString(p["Cliente"]).Trim(),
                                   Convert.ToInt32(p["Cajas"]),
                                   "Entregado");
            }
            return resultado;
        }

        public DataTable ListarResponsables()
        {
            return datos.ObtenerResponsables();
        }

        // PNG o JPG, hasta 2 MB y que realmente sea una imagen
        public void ValidarImagen(string ruta)
        {
            string extension = Path.GetExtension(ruta).ToLower();
            if (extension != ".png" && extension != ".jpg" && extension != ".jpeg")
                throw new ArgumentException("El comprobante debe ser una imagen PNG o JPG.");

            if (new FileInfo(ruta).Length > TamanoMaximoBytes)
                throw new ArgumentException("La imagen supera el tamaño máximo de 2 MB.");

            try
            {
                using (Image prueba = Image.FromFile(ruta)) { }
            }
            catch (Exception)
            {
                throw new ArgumentException("El archivo elegido no es una imagen válida.");
            }
        }

        public void RegistrarEntrega(int idVehiculo, int idResponsable, List<int> entregados,
                                     List<int> noEntregados, string rutaComprobante)
        {
            if (idVehiculo <= 0)
                throw new ArgumentException("Seleccioná un camión.");
            if (idResponsable <= 0)
                throw new ArgumentException("Elegí el responsable de la entrega.");
            if (entregados.Count + noEntregados.Count == 0)
                throw new ArgumentException("El camión no tiene pedidos para registrar.");

            byte[] imagen = null;
            string nombre = null;
            string tipo = null;

            // La imagen solo es obligatoria si se entregó al menos un pedido
            if (entregados.Count > 0)
            {
                if (string.IsNullOrEmpty(rutaComprobante))
                    throw new ArgumentException("Adjuntá la imagen del comprobante de entrega.");

                ValidarImagen(rutaComprobante);
                imagen = File.ReadAllBytes(rutaComprobante);
                nombre = Path.GetFileName(rutaComprobante);
                tipo = Path.GetExtension(rutaComprobante).TrimStart('.').ToLower();
            }

            int resultado = datos.RegistrarEntrega(idVehiculo, idResponsable,
                                                   string.Join(",", entregados),
                                                   string.Join(",", noEntregados),
                                                   nombre, tipo, imagen);

            if (resultado == 1)
                throw new ArgumentException("No se encontró el camión seleccionado. Se actualiza el listado.");
            if (resultado == 2)
                throw new ArgumentException("Los pedidos del camión cambiaron mientras tanto. Se actualiza el listado.");
            if (resultado == 3)
                throw new ArgumentException("El responsable elegido no está registrado en el sistema.");
            if (resultado == 4)
                throw new ArgumentException("Falta la imagen del comprobante de entrega.");
        }

        #region Historial
        public DataTable ListarHistorial(DateTime desde, DateTime hasta)
        {
            if (desde.Date > hasta.Date)
                throw new ArgumentException("La fecha \"Desde\" no puede ser posterior a la fecha \"Hasta\".");

            return datos.ObtenerHistorial(desde, hasta);
        }

        public DataTable ListarDetalleEntrega(int idEntrega)
        {
            if (idEntrega <= 0)
                throw new ArgumentException("Seleccioná una entrega.");

            return datos.ObtenerDetalleEntrega(idEntrega);
        }

        public byte[] ObtenerComprobante(int idEntrega, out string nombreArchivo)
        {
            byte[] imagen = datos.ObtenerComprobante(idEntrega, out nombreArchivo);

            if (imagen == null || imagen.Length == 0)
                throw new ArgumentException("Esta entrega no tiene comprobante adjunto (no se entregó ningún pedido).");

            return imagen;
        }
        #endregion
    }
}
