
namespace AviGestion_.Logica
{
    public class PagoPedido
    {
        //Datos del pedido
        public int NºPedido { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public string Productos { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        //Utiles para Registrar Pago
        public decimal SaldoPendiente { get; set; }
        public string MetodoPago { get; set; }
    }
}
