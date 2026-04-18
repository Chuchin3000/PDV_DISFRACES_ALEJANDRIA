using PVD_DISFRACES_ALEJANDRIA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{
    internal class EmpleadoDAO
    {
        // Para el login — busca el empleado por su nombre de usuario
        public Empleado ObtenerPorUsuario(string nombreUsuario) { }

        // Para el CRUD del admin
        public List<Empleado> ObtenerTodos() { }
        public bool Insertar(Empleado empleado) { }
        public bool Actualizar(Empleado empleado) { }
        public bool Eliminar(uint idEmpleado) { }
    }
}
