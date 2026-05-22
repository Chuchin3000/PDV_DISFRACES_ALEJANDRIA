using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    /// <summary>
    /// Modelo para el reporte detaallado de ventas
    /// </summary>
    internal class ReporteVenta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string UsuarioQueVendio { get; set; } = string.Empty;
        public int IdProducto { get; set; }
        public string Producto { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }

}
