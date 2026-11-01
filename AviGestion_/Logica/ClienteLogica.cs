using AviGestion_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AviGestion_.Logica
{
    public class ClienteLogica
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        public List<Cliente> ObtenerClientes()
        {
            return clienteDatos.ListarTodos();
        }

        public List<string> ValidarFormatosLogicos(string telefono, string dniCuil, string correo, string responsable, string direccion)
        {
            List<string> errores = new List<string>();

            // --- Validación de Responsable ---
            if (string.IsNullOrWhiteSpace(responsable) || !responsable.Trim().Contains(" "))
                errores.Add("- Debe ingresar nombre y apellido separados por un espacio.");

            // --- Validación de Teléfono ---
            string telLimpio = (telefono ?? "").Replace("-", "").Replace(" ", "");
            if (telLimpio.Length < 10)
                errores.Add("- El número de teléfono es demasiado corto.");

            // --- Validación de Correo ---
            string correoSeguro = correo ?? "";
            if (!correoSeguro.Contains("@") || !correoSeguro.Contains("."))
                errores.Add("- El correo electrónico debe contener @ y .com");

            // --- Validación de DNI/CUIL ---
            string dniLimpio = (dniCuil ?? "").Replace("-", "").Replace(" ", "");
            if (dniLimpio.Length != 8 && dniLimpio.Length != 11)
                errores.Add("- El DNI debe tener 8 dígitos o el CUIL 11 dígitos.");

            // --- Validación de Dirección (Calle y Número) ---
            if (string.IsNullOrWhiteSpace(direccion))
            {
                errores.Add("- La dirección es obligatoria.");
            }
            else
            {
                // Remueve espacios de más al inicio y al final
                string dirLimpia = direccion.Trim();

                // Expresión regular: Busca texto (calle) seguido de al menos un número (altura)
                // Soporta nombres de calles con espacios, puntos, números (Ej: "Calle 14 452" o "Av. San Martín 1500")
                bool tieneFormatoValido = Regex.IsMatch(dirLimpia, @"^.+?\s+\d+.*$");

                if (!tieneFormatoValido)
                {
                    errores.Add("- La dirección debe contener el nombre de la calle seguido de su número (Ej: Rivadavia 123).");
                }
            }


            return errores; // Devuelve la lista de errores encontrados
        }
        public void GuardarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Empresa))
                throw new ArgumentException("El nombre de la empresa/negocio es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new ArgumentException("El nombre del responsable es obligatorio.");

            // Si el ID es -1 procesa el alta, sino modifica
            if (cliente.Id_Cliente == -1)
            {
                clienteDatos.Insertar(cliente);
            }
            else
            {
                clienteDatos.Modificar(cliente);
            }
        }

    }
}
