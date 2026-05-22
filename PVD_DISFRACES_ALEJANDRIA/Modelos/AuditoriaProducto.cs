using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    /// <summary>
    /// Modelo para la auditoria de productos
    /// </summary>
    internal class AuditoriaProducto
    {
        public int IdAuditoria { get; set; }
        public DateTime FechaHora { get; set; }
        public string Accion { get; set; }  // INSERT, UPDATE, DELETE
        public int? IdProducto { get; set; }
        public string Usuario { get; set; }
        public string ValoresAnteriores { get; set; }
        public string ValoresNuevos { get; set; }
    }

}
