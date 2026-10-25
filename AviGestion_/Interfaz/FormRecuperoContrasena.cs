using AviGestion_.Logica;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    // Recuperación de contraseña en 3 pasos:
    //   1) el usuario ingresa su correo y recibe un código por mail
    //   2) ingresa el código (3 intentos como máximo)
    //   3) elige su contraseña nueva
    // La contraseña NO se toca hasta que el código se verificó.
    public partial class FormRecuperoContrasena : Form
    {
        #region Constantes y estado
        private const int LARGO_CODIGO = 6;
        private const int MINUTOS_VIGENCIA = 10;
        private const int MAX_INTENTOS = 3;
        private const int MINUTOS_BLOQUEO = 5;
        private const int SEGUNDOS_ENTRE_ENVIOS = 30;

        // Las credenciales del correo NO están en el código: se leen de variables de entorno
        private const string VAR_CORREO_USUARIO = "AVIGESTION_SMTP_USUARIO";
        private const string VAR_CORREO_CLAVE = "AVIGESTION_SMTP_CLAVE";

        private UsuarioLogica usuarioLogica = new UsuarioLogica();

        // Estado de la recuperación en curso (esta mientras el formulario está abierto)
        private Usuario usuarioRecuperacion;
        private string emailRecuperacion;
        private string codigoGenerado;
        private DateTime codigoVence;
        private int intentosCodigo;
        private bool codigoVerificado;

        // Límites guardados en memoria: cerrar y volver a abrir el formulario no los saltea
        private static readonly Dictionary<string, DateTime> bloqueadosHasta = new Dictionary<string, DateTime>();
        private static readonly Dictionary<string, DateTime> ultimoEnvio = new Dictionary<string, DateTime>();
        #endregion

        public FormRecuperoContrasena()
        {
            InitializeComponent();
            MostrarPaso(1);
        }

        #region Pasos
        private void MostrarPaso(int paso)
        {
            pnlPaso1.Visible = (paso == 1);
            pnlPaso2.Visible = (paso == 2);
            pnlPaso3.Visible = (paso == 3);

            if (paso == 1)
            {
                lblSubtitulo.Text = "Paso 1 de 3 · Verificá tu correo electrónico.";
                AcceptButton = btnEnviarCodigo;
                txtMail.Focus();
            }
            else if (paso == 2)
            {
                lblSubtitulo.Text = "Paso 2 de 3 · Ingresá el código que te enviamos.";
                AcceptButton = btnVerificar;
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
            else
            {
                lblSubtitulo.Text = "Paso 3 de 3 · Elegí tu nueva contraseña.";
                AcceptButton = btnGuardar;
                txtNueva.Focus();
            }
        }

        // Paso 1: validar el correo y enviar el código
        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();

            if (email == "" || !email.Contains("@"))
            {
                MessageBox.Show("Ingresá un correo electrónico válido.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return;
            }

            // Si se pasó con códigos incorrectos, tiene que esperar
            DateTime hasta;
            if (bloqueadosHasta.TryGetValue(email.ToLower(), out hasta) && hasta > DateTime.Now)
            {
                int minutos = (int)Math.Ceiling((hasta - DateTime.Now).TotalMinutes);
                MessageBox.Show("Superaste el máximo de intentos. Probá de nuevo en " + minutos + " minuto(s).",
                                "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u;
            try
            {
                u = usuarioLogica.ObtenerUsuarioPorMail(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar el usuario.\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (u == null)
            {
                MessageBox.Show("No se encontró ningún usuario con ese correo.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuarioRecuperacion = u;
            emailRecuperacion = email;
            if (!EnviarCodigoNuevo()) return;

            lblInstruccion2.Text = "Te enviamos un código de " + LARGO_CODIGO + " dígitos a " + email +
                                   ". Vence en " + MINUTOS_VIGENCIA + " minutos.";
            MostrarPaso(2);
        }

        // Paso 2: comprobar el código
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string ingresado = txtCodigo.Text.Trim();

            if (ingresado.Length != LARGO_CODIGO)
            {
                MessageBox.Show("Ingresá los " + LARGO_CODIGO + " dígitos del código.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (codigoGenerado == null || DateTime.Now > codigoVence)
            {
                MessageBox.Show("El código venció. Pedí uno nuevo con \"Reenviar código\".", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ingresado != codigoGenerado)
            {
                intentosCodigo++;

                if (intentosCodigo >= MAX_INTENTOS)
                {
                    bloqueadosHasta[emailRecuperacion.ToLower()] = DateTime.Now.AddMinutes(MINUTOS_BLOQUEO);
                    codigoGenerado = null;
                    MessageBox.Show("Ingresaste el código incorrecto " + MAX_INTENTOS + " veces. " +
                                    "Por seguridad, la recuperación queda bloqueada " + MINUTOS_BLOQUEO + " minutos.",
                                    "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                MessageBox.Show("Código incorrecto. Te quedan " + (MAX_INTENTOS - intentosCodigo) + " intento(s).",
                                "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            codigoVerificado = true;
            MostrarPaso(3);
        }

        // Paso 3: guardar la contraseña nueva
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //sin código verificado no se cambia nada
            if (!codigoVerificado || usuarioRecuperacion == null) return;

            string nueva = txtNueva.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (nueva == "" || confirmar == "")
            {
                MessageBox.Show("Por favor, completá los dos campos.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("La contraseña y su repetición no coinciden.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmar.Clear();
                txtConfirmar.Focus();
                return;
            }

            string mensaje;
            bool guardada;
            try
            {
                guardada = usuarioLogica.RestablecerContrasena(usuarioRecuperacion.IdUsuario, nueva, out mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la contraseña.\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!guardada)
            {
                MessageBox.Show(mensaje, "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNueva.Focus();
                return;
            }

            codigoGenerado = null;
            codigoVerificado = false;
            MessageBox.Show("Tu contraseña se actualizó. Ya podés iniciar sesión con la nueva.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion

        #region Botones secundarios
        private void btnReenviar_Click(object sender, EventArgs e)
        {
            if (EnviarCodigoNuevo())
            {
                txtCodigo.Clear();
                txtCodigo.Focus();
                MessageBox.Show("Te enviamos un código nuevo. El anterior ya no sirve.", "Recuperar contraseña",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCambiarMail_Click(object sender, EventArgs e)
        {
            codigoGenerado = null;
            codigoVerificado = false;
            MostrarPaso(1);
        }

        private void lnkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // El código solo admite dígitos
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        #endregion

        #region Código y correo
        // Genera un código nuevo y lo envía por mail. Devuelve true si se envió.
        private bool EnviarCodigoNuevo()
        {
            string clave = emailRecuperacion.ToLower();

            // Evita el envio de correos en gran cantidad, al apretar "Reenviar código" muchas veces
            DateTime ultimo;
            if (ultimoEnvio.TryGetValue(clave, out ultimo))
            {
                double faltan = SEGUNDOS_ENTRE_ENVIOS - (DateTime.Now - ultimo).TotalSeconds;
                if (faltan > 0)
                {
                    MessageBox.Show("Esperá " + Math.Ceiling(faltan) + " segundos antes de pedir otro código.",
                                    "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (!CorreoConfigurado())
            {
                MessageBox.Show("El envío de correos no está configurado en esta computadora.\n" +
                                "Cargá las variables de entorno " + VAR_CORREO_USUARIO + " y " + VAR_CORREO_CLAVE + ".",
                                "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string codigo = GenerarCodigo();

            try
            {
                EnviarCorreo(emailRecuperacion, codigo);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo enviar el correo. Revisá tu conexión a internet e intentá de nuevo.",
                                "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Recién ahora se guarda el código: si el correo falló, no cambió nada
            codigoGenerado = codigo;
            codigoVence = DateTime.Now.AddMinutes(MINUTOS_VIGENCIA);
            intentosCodigo = 0;
            codigoVerificado = false;
            ultimoEnvio[clave] = DateTime.Now;
            return true;
        }

        // Código numérico generado con un generador criptográfico
        private static string GenerarCodigo()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[4];
                rng.GetBytes(bytes);
                uint numero = BitConverter.ToUInt32(bytes, 0) % 1000000;
                return numero.ToString("D" + LARGO_CODIGO);
            }
        }

        private static string LeerConfiguracion(string nombre)
        {
            string valor = Environment.GetEnvironmentVariable(nombre);
            if (string.IsNullOrWhiteSpace(valor))
                valor = Environment.GetEnvironmentVariable(nombre, EnvironmentVariableTarget.User);
            return valor;
        }

        private static bool CorreoConfigurado()
        {
            return !string.IsNullOrWhiteSpace(LeerConfiguracion(VAR_CORREO_USUARIO)) &&
                   !string.IsNullOrWhiteSpace(LeerConfiguracion(VAR_CORREO_CLAVE));
        }

        private static void EnviarCorreo(string destinatario, string codigo)
        {
            string usuarioSmtp = LeerConfiguracion(VAR_CORREO_USUARIO).Trim();
            string claveSmtp = LeerConfiguracion(VAR_CORREO_CLAVE).Trim();

            MimeMessage mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("AviGestión", usuarioSmtp));
            mensaje.To.Add(new MailboxAddress("", destinatario));
            mensaje.Subject = "Recuperación de contraseña - AviGestión";
            mensaje.Body = new TextPart("plain")
            {
                Text = "Hola,\r\n\r\n" +
                       "Tu código de verificación es: " + codigo + "\r\n\r\n" +
                       "Vence en " + MINUTOS_VIGENCIA + " minutos. Si no lo pediste vos, ignorá este mensaje: " +
                       "tu contraseña no se modificó.\r\n\r\n" +
                       "AviGestión"
            };

            using (MailKit.Net.Smtp.SmtpClient cliente = new MailKit.Net.Smtp.SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                cliente.Authenticate(usuarioSmtp, claveSmtp);
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
        #endregion
    }
}