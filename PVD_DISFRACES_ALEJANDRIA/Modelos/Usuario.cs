using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    /// <summary>
    /// Modelo que representa un usuario en el sistema
    /// </summary>
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = "";
        public string Contrasena { get; set; } = "";
        public string Rol { get; set; } = "";
    }

}
