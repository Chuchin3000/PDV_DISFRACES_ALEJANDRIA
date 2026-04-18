using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    public enum EstadoVenta
    {
        Pagado,
        Pendiente,
        Abono
    }
    internal class Venta
    {
        public uint IdVenta { get; set; }             // PK, AUTO_INCREMENT
        public DateTime Fecha { get; set; }           // DATETIME DEFAULT CURRENT_TIMESTAMP
        public DateTime FechaEntrega { get; set; }    // DATETIME DEFAULT CURRENT_TIMESTAMP
        public EstadoVenta Estado { get; set; }       // ENUM NOT NULL
        public double Total { get; set; }             // DOUBLE UNSIGNED NOT NULL
        public double? PagoRealizado { get; set; }   // DOUBLE UNSIGNED NULL
        public string Empleado { get; set; }          // VARCHAR(20) NOT NULL
    }
}
