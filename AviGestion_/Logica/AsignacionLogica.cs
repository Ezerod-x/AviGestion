using AviGestion_.Datos;
using System.Data;

namespace AviGestion_.Logica
{
    public class AsignacionLogica
    {
        // Estados del pedido (tienen que coincidir con los de la base y los SP)
        public const string EstadoEspera = "En preparación";
        public const string EstadoEnCamion = "En camión";
        public const string EstadoEnCamino = "En camino";
        public const string EstadoEntregado = "Entregado";

        // Estados del vehículo
        public const string VehiculoDisponible = "Disponible";
        public const string VehiculoCargando = "Cargando";
        public const string VehiculoEnCamino = "En camino";

        private readonly DatosAsignacion datos = new DatosAsignacion();

        public DataTable PedidosEnEspera() { return datos.PedidosPorEstado(EstadoEspera); }
        public DataTable PedidosEnCamion() { return datos.PedidosPorEstado(EstadoEnCamion); }
        public DataTable PedidosEnCamino() { return datos.PedidosPorEstado(EstadoEnCamino); }
        public DataTable PedidosEntregados() { return datos.PedidosPorEstado(EstadoEntregado); }

        public DataTable Vehiculos() { return datos.Vehiculos(); }

        // Carga el pedido en el camión (pedido "En camión", camión "Cargando")
        public void Asignar(int idPedido, int idVehiculo)
        {
            datos.Asignar(idPedido, idVehiculo);
        }

        // Saca el pedido del camión (vuelve a "En preparación")
        public void Quitar(int idPedido)
        {
            datos.Quitar(idPedido);
        }

        // El camión salió: camión y pedidos pasan a "En camino"
        public void Despachar(int idVehiculo)
        {
            datos.Despachar(idVehiculo);
        }
    }
}