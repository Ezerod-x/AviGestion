using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Usuario> ObtenerTodos()
        {
            return usuarioDatos.ObtenerTodos();
        }

        // Recibe la contraseña en texto plano y la guarda encriptada.
        public void Insertar(Usuario usuario)
        {
            usuario.Contrasena = Encriptador.EncriptarSHA256((usuario.Contrasena ?? "").Trim());
            usuarioDatos.Insertar(usuario);
        }

        // No modifica la contraseña: eso se hace con CambiarContrasena o con el recupero.
        public void Actualizar(Usuario usuario)
        {
            usuarioDatos.Actualizar(usuario);
        }

        public void Eliminar(int idUsuario)
        {
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