using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AviGestion_.Logica
{
    public class PagoPedidoLogica //nuevo
    {
        private PagosPedidoDatos _pagosDatos = new PagosPedidoDatos();

        // Lista única de métodos de pago: la usa el formulario para llenar el combo
        // y la validación de abajo. Tiene que coincidir con el CHECK de la tabla Pago.
        public static readonly string[] MetodosPago =
        {
            "Efectivo", "Transferencia", "Tarjeta de débito", "Tarjeta de crédito", "Cheque"
        };

        public List<PagoPedido> ObtenerPedidosParaPagos()
        {
            return _pagosDatos.ObtenerPedidosParaPagos();
        }

        public void RegistrarPago(int idPedido, decimal importeAbonar, string metodoPago)
        {
            if (string.IsNullOrWhiteSpace(metodoPago) || !MetodosPago.Contains(metodoPago))
                throw new ArgumentException("Seleccioná un método de pago válido.");

            int resultado = _pagosDatos.RegistrarPagoTransaccional(idPedido, importeAbonar, metodoPago);

            if (resultado == 1)
                throw new ArgumentException("El pedido ya no está disponible para cobro (cancelado o sin compra registrada).");
            if (resultado == 2)
                throw new ArgumentException("El monto supera el saldo pendiente actual. Se actualizó el listado.");
            if (resultado == 3)
                throw new ArgumentException("El método de pago no es válido.");
        }
    }
}
