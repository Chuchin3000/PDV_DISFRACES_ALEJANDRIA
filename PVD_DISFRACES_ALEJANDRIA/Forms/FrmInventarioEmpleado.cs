using PVD_DISFRACES_ALEJANDRIA.DAO;
using PVD_DISFRACES_ALEJANDRIA.Modelos;
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
    public partial class FrmInventarioEmpleado : Form
    {
        private ProductoDAO productoDAO;

        public FrmInventarioEmpleado()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            ConfigurarGrid();
        }

        private void FrmInventarioEmpleado_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void ConfigurarGrid()
        {
            dgvInventario.ReadOnly = true;
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.RowHeadersVisible = false;
        }

        private void CargarInventario()
        {
            try
            {
                var lista = productoDAO.ListarTodos();
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = lista;

                PersonalizarColumnas();
                ColorearFilasBajoStock();
                ActualizarEstadisticas(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarColumnas()
        {
            if (dgvInventario.Columns.Contains("IdProducto"))
            {
                dgvInventario.Columns["IdProducto"].HeaderText = "ID";
                dgvInventario.Columns["IdProducto"].Width = 60;
            }

            if (dgvInventario.Columns.Contains("Codigo"))
            {
                dgvInventario.Columns["Codigo"].HeaderText = "Código";
                dgvInventario.Columns["Codigo"].Width = 120;
            }

            if (dgvInventario.Columns.Contains("Nombre"))
            {
                dgvInventario.Columns["Nombre"].HeaderText = "Nombre del Producto";
                dgvInventario.Columns["Nombre"].Width = 250;
            }

            if (dgvInventario.Columns.Contains("Descripcion"))
            {
                dgvInventario.Columns["Descripcion"].HeaderText = "Descripción";
                dgvInventario.Columns["Descripcion"].Width = 200;
            }

            if (dgvInventario.Columns.Contains("Precio"))
            {
                dgvInventario.Columns["Precio"].HeaderText = "Precio";
                dgvInventario.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvInventario.Columns["Precio"].Width = 100;
            }

            if (dgvInventario.Columns.Contains("Stock"))
            {
                dgvInventario.Columns["Stock"].HeaderText = "Stock";
                dgvInventario.Columns["Stock"].Width = 80;
            }
        }

        private void ColorearFilasBajoStock()
        {
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (row.DataBoundItem is not Producto producto) continue;

                if (producto.Stock <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.Font = new Font(dgvInventario.Font, FontStyle.Bold);
                }
                else if (producto.Stock <= 10)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (producto.Stock >= 50)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223);
                }
            }
        }

        private void ActualizarEstadisticas(List<Producto> productos)
        {
            int totalProductos = productos.Count;
            int productosBajoStock = productos.Count(p => p.Stock <= 10);
            decimal valorTotal = productos.Sum(p => p.Precio * p.Stock);

            lblTotalProductos.Text = $"Total de productos: {totalProductos}";
            lblValorTotal.Text = $"Valor total: {valorTotal:C2}";

            if (productosBajoStock > 0)
            {
                lblProductosBajoStock.Text = $"⚠️ Productos con bajo stock: {productosBajoStock}";
                lblProductosBajoStock.ForeColor = Color.FromArgb(231, 76, 60);
            }
            else
            {
                lblProductosBajoStock.Text = "✓ Stock saludable";
                lblProductosBajoStock.ForeColor = Color.FromArgb(46, 204, 113);
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
