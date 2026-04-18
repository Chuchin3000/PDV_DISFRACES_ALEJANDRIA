using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    internal class Categoria
    {
        public uint IdCategoria { get; set; }       // PK, AUTO_INCREMENT
        public string Nombre { get; set; }           // VARCHAR(20) NOT NULL
        public string? Descripcion { get; set; }    // VARCHAR(50) NULL
    }
}
