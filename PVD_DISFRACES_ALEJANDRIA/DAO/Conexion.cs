using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{
    internal class Conexion
    {
        // Una sola cadena de conexión, en un solo lugar
        private readonly string cadena =
            "Server=localhost;" +
            "Port=3306;" +           // puerto explícito (MySQL usa 3306 por defecto)
            "Database=PVD_DISFRACES_ALEJANDRIA;" +
            "Uid=root;" +
            "Pwd=Tacodeguayaba16;" +
            "SslMode=None;" +        // evita error de SSL en conexiones locales
            "AllowPublicKeyRetrieval=true;"; // necesario con MySQL 8+

        private MySqlConnection conn;

        /// <summary>
        /// Constructor: crea el objeto de conexión (aún no la abre).
        /// </summary>
        public Conexion()
        {
            conn = new MySqlConnection(cadena);
        }

        /// <summary>
        /// Abre la conexión y la devuelve lista para usarse.
        /// </summary>
        public MySqlConnection Abrir()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (MySqlException ex)   // captura específica para MySQL
            {
                // Muestra el número de error MySQL para facilitar diagnóstico
                MessageBox.Show(
                    $"Error MySQL [{ex.Number}]: {ex.Message}",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw; // relanza para que el DAO que llamó también lo maneje
            }

            return conn;
        }

        /// <summary>
        /// Cierra la conexión si está abierta.
        /// </summary>
        public void Cerrar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error al cerrar conexión [{ex.Number}]: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}