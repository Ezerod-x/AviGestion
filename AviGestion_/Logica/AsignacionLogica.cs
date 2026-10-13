using AviGestion_.Datos;
using System.Data;

namespace AviGestion_.Logica
{
    public class AsignacionLogica
    {
        // Estados de pedido usados por el tablero de asignación.
        // Si en tu base los pedidos nuevos no quedan como "Pendiente", cambialo acá.
        public const string EstadoEspera = "Pendiente";
        public const string EstadoEnCamino = "En camino";
        public const string EstadoEntregado = "Entregado";

        private readonly DatosAsignacion datos = new DatosAsignacion();

        public DataTable PedidosEnEspera() { return datos.PedidosPorEstado(EstadoEspera); }
        public DataTable PedidosEnCamino() { return datos.PedidosPorEstado(EstadoEnCamino); }
        public DataTable PedidosEntregados() { return datos.PedidosPorEstado(EstadoEntregado); }

        public DataTable Vehiculos() { return datos.Vehiculos(); }

        public void Asignar(int idPedido, int idVehiculo)
        {
            datos.Asignar(idPedido, idVehiculo);
        }
    }
}
