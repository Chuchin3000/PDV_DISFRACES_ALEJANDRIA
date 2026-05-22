using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Utils
{
    /// <summary>
    /// Clase de seguridad para funciones criptográficas.
    /// </summary>

    internal class Seguridad
    {
        /// <summary>
        /// Método que genera un hash SHA256 a partir de un texto dado.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string HashSHA256(string texto)
        {
            if (texto == null) // Si el texto/contraseña es nulo, devuelve cadena vacía.
                return string.Empty;
            using (SHA256 sha256 = SHA256.Create()) // Crea el objeto que hace el hashing.
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto); // Convierte el texto en bytes.
                byte[] hash = sha256.ComputeHash(bytes); // Calcula el hash, devuelve un arreglo de 32 bytes.

                // Convierte el arreglo de bytes a una cadena hexadecimal legible.
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));   // formato hexadecimal
                }

                return sb.ToString(); // Devuelve el hash como cadena hexadecimal.
            }
        }

    }
}
