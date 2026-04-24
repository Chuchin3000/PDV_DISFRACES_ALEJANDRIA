using PVD_DISFRACES_ALEJANDRIA.DAO;
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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            VentaDAO CVenta = new VentaDAO();
            CVenta.MostrarProductosDisponibles(gridProductos);

        }

        private void FrmVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DAO.VentaDAO seleccionar = new DAO.VentaDAO();
            seleccionar.seleccionarProducto(gridProductos, txtIdProducto, txtProducto, txtPrecioPieza, txtTalla,
                txtIdCategoria, txtCategoria);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DAO.VentaDAO carrito = new DAO.VentaDAO();
            carrito.pasarProductosAlCarrito(gridCarrito, txtIdProducto, txtProducto, txtPrecioPieza, numericCantidad, txtDescuento);
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            VentaDAO mostraritems = new VentaDAO();
            if ( comboBoxEstado.Text == "Abono" || comboBoxEstado.Text == "Pendiente" )
            {
                mostrarAbono(true);
            }
            else
            {
                mostrarAbono(false);
            }
        }

        private void mostrarAbono( bool visible )
        {
            labelFecha.Visible = visible;
            dateFechaEntrega.Visible = visible;
            labelAbono.Visible = visible;
            txtAbono.Visible = visible;
        }

    }
}
