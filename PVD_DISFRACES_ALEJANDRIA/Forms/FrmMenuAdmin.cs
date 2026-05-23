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
    /// Clase que representa el formulario del menú principal para administradores.
    /// </summary>
    public partial class FrmMenuAdmin : Form
    {
        private int idUsuarioEnSesion;

        public FrmMenuAdmin(int idUsuario)
        {
            InitializeComponent();
            idUsuarioEnSesion = idUsuario;
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            // Lógica de carga si se necesita en el futuro
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmCRUDProductos frm = new FrmCRUDProductos();
            frm.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmCRUDEmpleados frm = new FrmCRUDEmpleados();
            frm.ShowDialog();
        }

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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            FrmAuditoriaProducto frmAuditoria = new FrmAuditoriaProducto();
            frmAuditoria.ShowDialog();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCRUDUsuarios frm = new FrmCRUDUsuarios();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
