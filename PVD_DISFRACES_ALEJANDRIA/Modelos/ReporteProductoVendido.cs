using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    /// <summary>
    /// Modelo para el reporte de productos vendidos
    /// </summary>
    internal class ReporteProductoVendido
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Costo { get; set; }
        public int UnidadesVendidas { get; set; }

        public string CostoFormateado => Costo.ToString("C2");
        public decimal TotalVendido => Costo * UnidadesVendidas;
        public string TotalVendidoFormateado => TotalVendido.ToString("C2");
    }
}
