using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

using AviGestion_.Datos;
using AviGestion_.Seguridad;

namespace AviGestion_.Logica
{
    public class UsuarioLogica
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        #region Login
        public Usuario ValidarLogin(string nombre, string contrasena)
        {
            Usuario usuario = usuarioDatos.ObtenerUsuarioPorNombre(nombre);

            if (usuario == null)
            {
                return null; // no existe el usuario
            }

            // En la base se guarda el hash, así que se compara contra el hash de lo ingresado
            if (usuario.Contrasena != Encriptador.EncriptarSHA256((contrasena ?? "").Trim()))
            {
                return null; // contraseña incorrecta
            }

            return usuario; // login correcto
        }
        #endregion

        #region ABM de usuarios

        // Recibe la contraseña en texto plano y la guarda encriptada.
        public void Insertar(Usuario usuario)
        {
            ValidarMailDelUsuario(usuario);
            usuario.Contrasena = Encriptador.EncriptarSHA256((usuario.Contrasena ?? "").Trim());
            usuarioDatos.Insertar(usuario);
        }

        // No modifica la contraseña: eso se hace con CambiarContrasena o con el recupero.
        public void Actualizar(Usuario usuario)
        {
            ValidarMailDelUsuario(usuario);
            usuarioDatos.Actualizar(usuario);
        }

        // El correo es obligatorio, tiene que ser válido y no puede repetirse:
        // con él se recupera la contraseña, así que debe identificar a un único usuario.
        private void ValidarMailDelUsuario(Usuario usuario)
        {
            usuario.Mail = (usuario.Mail ?? "").Trim();

            string error = ValidarMail(usuario.Mail);
            if (error != null)
                throw new Exception(error);

            Usuario existente = usuarioDatos.ObtenerUsuarioPorMail(usuario.Mail);
            if (existente != null && existente.IdUsuario != usuario.IdUsuario)
                throw new Exception("Ya existe un usuario con ese correo electrónico.");
        }

        // Devuelve null si el correo es válido, o el mensaje del problema
        public static string ValidarMail(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
                return "El correo electrónico es obligatorio.";

            if (!Regex.IsMatch(mail.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "El correo electrónico no es válido. Ejemplo: nombre@dominio.com";

            return null;
        }

        public void Eliminar(int idUsuario)
        {
            usuarioDatos.Eliminar(idUsuario);
        }

        // Búsqueda por nombre, apellido o rol (texto vacío = todos los usuarios)
        public List<Usuario> BuscarUsuarios(string busqueda)
        {
            return usuarioDatos.BuscarUsuarios((busqueda ?? "").Trim());
        }

        // Un usuario no puede eliminarse a sí mismo: se quedaría sin acceso al sistema
        public void Eliminar(int idUsuario, int idUsuarioActual)
        {
            if (idUsuario == idUsuarioActual)
                throw new Exception("No podés eliminar tu propio usuario.");

            usuarioDatos.Eliminar(idUsuario);
        }
        #endregion

        #region Requisitos de contraseña
        // Mínimo 8 caracteres, al menos una letra y un número.|| Devuelve null si cumple, o el mensaje de lo que falta.

        public static string ValidarRequisitos(string contrasena)
        {
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 8)
                return "La contraseña debe tener al menos 8 caracteres.";

            if (!contrasena.Any(char.IsLetter) || !contrasena.Any(char.IsDigit))
                return "La contraseña debe contener al menos una letra y un número.";

            return null;
        }
        #endregion

        #region Cambio de contraseña (usuario con sesión iniciada)
        // Si devuelve false, "mensaje" dice el motivo.

        public bool CambiarContrasena(int idUsuario, string actual, string nueva, out string mensaje)
        {
            mensaje = string.Empty;

            Usuario usuario = usuarioDatos.ObtenerUsuarioPorId(idUsuario);
            if (usuario == null)
            {
                mensaje = "No se encontró el usuario.";
                return false;
            }

            string hashActual = Encriptador.EncriptarSHA256((actual ?? "").Trim());

            // La actual tiene que ser correcta
            if (usuario.Contrasena != hashActual)
            {
                mensaje = "La contraseña actual es incorrecta.";
                return false;
            }

            // La nueva tiene que cumplir los requisitos
            string errorRequisitos = ValidarRequisitos((nueva ?? "").Trim());
            if (errorRequisitos != null)
            {
                mensaje = errorRequisitos;
                return false;
            }

            // No puede ser igual a la anterior
            string hashNueva = Encriptador.EncriptarSHA256((nueva ?? "").Trim());
            if (hashNueva == hashActual)
            {
                mensaje = "La nueva contraseña no puede ser igual a la actual.";
                return false;
            }

            // Se guarda encriptada
            if (!usuarioDatos.ActualizarContrasena(idUsuario, hashNueva))
            {
                mensaje = "No se pudo actualizar la contraseña.";
                return false;
            }
            return true;
        }
        #endregion

        #region Recupero de contraseña (olvidé mi contraseña)
        //Paso 1:busca el usuario que tiene ese mail (null si no existe).

        public Usuario ObtenerUsuarioPorMail(string mail)
        {
            return usuarioDatos.ObtenerUsuarioPorMail(mail);
        }

        //Paso 3:DESPUÉS de verificar el código enviado por mail: valida los requisitos y guarda la contraseña nueva encriptada.
        public bool RestablecerContrasena(int idUsuario, string nueva, out string mensaje)
        {
            mensaje = string.Empty;

            string errorRequisitos = ValidarRequisitos((nueva ?? "").Trim());
            if (errorRequisitos != null)
            {
                mensaje = errorRequisitos;
                return false;
            }

            if (!usuarioDatos.ActualizarContrasena(idUsuario, Encriptador.EncriptarSHA256(nueva.Trim())))
            {
                mensaje = "No se pudo actualizar la contraseña.";
                return false;
            }
            return true;
        }
        #endregion
    }
}