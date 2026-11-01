using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviGestion_.Logica
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        // Por seguridad, nunca se muestra en una grilla aunque genere sus columnas sola
        [Browsable(false)]
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public string Mail { get; set; }
    }
}