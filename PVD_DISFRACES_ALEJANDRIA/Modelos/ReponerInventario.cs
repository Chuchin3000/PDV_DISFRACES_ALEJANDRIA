using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    internal class ReponerInventario
    {
        public uint IdReponerInventario { get; set; } // PK, AUTO_INCREMENT
        public uint IdProducto { get; set; }           // FK → productos.id_producto
        public uint Cantidad { get; set; }             // INT UNSIGNED NOT NULL
        public double Monto { get; set; }              // DOUBLE NOT NULL
    }
}
