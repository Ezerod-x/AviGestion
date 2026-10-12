using System;
using System.Collections.Generic;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class BitacoraLogica
    {
        private static DatosBitacora datos = new DatosBitacora();

        
        public static void Registrar(string usuario, string accion, string modulo, string detalle = "")
        {
            try
            {
                datos.Registrar(usuario, accion, modulo, detalle);
            }
            catch
            {
               
            }
        }

        public List<RegistroBitacora> Buscar(string usuario, string accion, string modulo,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            return datos.Listar(usuario, accion, modulo, fechaDesde, fechaHasta);
        }
    }
}