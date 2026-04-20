using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{
    internal class Conexion
    {
        private static readonly string cadena =
            "Server=localhost;Database=alejandria;User=root;Password=chuchin;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
