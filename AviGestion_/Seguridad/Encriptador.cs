using System.Security.Cryptography;
using System.Text;

namespace AviGestion_.Seguridad
{
    // Encriptado de contraseñas: se guarda el hash SHA256 (nunca la contraseña en texto plano).
    public static class Encriptador
    {
        // Convierte cualquier texto en un hash SHA256 en hexadecimal (minúsculas, 64 caracteres).
        
        public static string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto ?? string.Empty));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}