using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.Modelos
{
    public enum RolEmpleado
    {
        Cajero,
        Gerente,
        Ayudante,
        Patron
    }
    internal class Empleado
    {
        public uint IdEmpleado { get; set; }          // PK, AUTO_INCREMENT
        public string NombreCompleto { get; set; }    // VARCHAR(30) NOT NULL
        public string ApellidoPa { get; set; }        // VARCHAR(20) NOT NULL
        public string ApellidoMa { get; set; }        // VARCHAR(20) NOT NULL
        public double Sueldo { get; set; }            // DOUBLE NOT NULL
        public string Celular { get; set; }           // VARCHAR(13) NOT NULL
        public string? Telefono { get; set; }        // VARCHAR(13) NULL
        public RolEmpleado Rol { get; set; }          // ENUM NOT NULL
        public string Direccion { get; set; }         // VARCHAR(100) NOT NULL
        public byte[]? Foto { get; set; }            // LONGBLOB NULL
        public string? NombreUsuario { get; set; }   // FK → usuarios.nombre (NULL)
    }
}
