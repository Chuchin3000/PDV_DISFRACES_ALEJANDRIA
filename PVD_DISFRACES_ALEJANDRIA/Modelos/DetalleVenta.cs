using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    internal class DetalleVenta
    {
        public uint IdDetallesVenta { get; set; }     // PK, AUTO_INCREMENT
        public uint IdVenta { get; set; }             // FK → ventas.id_venta
        public uint IdProducto { get; set; }          // FK → productos.id_producto
        public double PrecioPieza { get; set; }       // DOUBLE NOT NULL
        public uint Cantidad { get; set; }            // INT UNSIGNED NOT NULL
    }
}
