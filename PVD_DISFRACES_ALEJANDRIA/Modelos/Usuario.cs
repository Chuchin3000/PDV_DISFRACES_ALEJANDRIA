using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    internal class Usuario
    {
        public string Nombre { get; set; }            // VARCHAR(20) PK NOT NULL
        public string Contrasenha { get; set; }       // VARCHAR(20) NOT NULL
    }
}
