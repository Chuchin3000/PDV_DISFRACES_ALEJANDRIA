using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    internal class Producto
    {
        public uint IdProducto { get; set; }         // PK, AUTO_INCREMENT
        public string Nombre { get; set; }            // VARCHAR(50) NOT NULL
        public uint Cantidad { get; set; }            // INT UNSIGNED NOT NULL
        public double Precio { get; set; }            // DOUBLE UNSIGNED NOT NULL
        public string? Talla { get; set; }           // CHAR(10) NULL
        public string Categoria { get; set; }         // VARCHAR(20) NOT NULL  ← columna de texto (no FK directa)
        public bool Descontinuado { get; set; }       // BOOLEAN DEFAULT false
        public uint IdCategoria { get; set; }         // FK → categorias.id_categoria
    }
}
