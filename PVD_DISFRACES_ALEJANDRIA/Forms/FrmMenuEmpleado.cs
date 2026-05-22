using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    /// <summary>
    /// Clase que representa el formulario del menú principal para empleados
    /// </summary>
    public partial class FrmMenuEmpleado : Form
    {
        // Guarda el ID del usuario que ha iniciado sesión
        private int idUsuarioEnSesion;

        // Constructor del formulario que recibe el ID del usuario en sesión
        public FrmMenuEmpleado(int idUsuario)
        {
            InitializeComponent();          // Inicializa los componentes visuales del formulario
            idUsuarioEnSesion = idUsuario;  // Asigna el ID del usuario en sesión al atributo privado
        }

        /// <summary>
        /// Botón para abrir el módulo de ventas
        /// </summary>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVentas frm = new FrmVentas(idUsuarioEnSesion);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el módulo de ventas: " + ex.Message);
            }
        }

        /// <summary>
        /// Botón para abrir el módulo de reportes
        /// </summary>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.ShowDialog();
        }

        /// <summary>
        /// Botón para cerrar sesión y volver al formulario de login
        /// </summary>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Botón para abrir el módulo de inventario
        /// </summary>
        private void btnInventarioEmpleado_Click(object sender, EventArgs e)
        {
            FrmInventarioEmpleado frm = new FrmInventarioEmpleado();
            frm.ShowDialog();
        }
    }
}
