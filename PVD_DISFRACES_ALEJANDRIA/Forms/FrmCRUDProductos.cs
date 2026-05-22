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
    /// <summary>
    /// Clase que representa el formulario para el CRUD de productos.
    /// </summary>
    public partial class FrmCRUDProductos : Form
    {
        private ProductoDAO productoDAO;

        public FrmCRUDProductos()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();

            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtID.Enabled = false;

            this.Load += FrmCrudProductos_Load;
        }

        private void FrmCrudProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            txtCodigo.Focus();
        }

        private void LimpiarCampos()
        {
            txtID.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void ListarProductos()
        {
            try
            {
                List<Producto> lista = productoDAO.ListarTodos();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                if (dgvProductos.Columns.Contains("IdProducto"))
                    dgvProductos.Columns["IdProducto"].HeaderText = "ID";

                if (dgvProductos.Columns.Contains("Codigo"))
                    dgvProductos.Columns["Codigo"].HeaderText = "Código";

                if (dgvProductos.Columns.Contains("Nombre"))
                    dgvProductos.Columns["Nombre"].HeaderText = "Nombre";

                if (dgvProductos.Columns.Contains("Descripcion"))
                    dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";

                if (dgvProductos.Columns.Contains("Precio"))
                    dgvProductos.Columns["Precio"].HeaderText = "Precio";

                if (dgvProductos.Columns.Contains("Stock"))
                    dgvProductos.Columns["Stock"].HeaderText = "Stock";

                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProductos.Enabled = true;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var p = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                txtID.Text = p.IdProducto.ToString();
                txtCodigo.Text = p.Codigo;
                txtNombre.Text = p.Nombre;
                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var p = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            try
            {
                if (productoDAO.Insertar(p))
                {
                    MessageBox.Show("Producto insertado correctamente.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insertando: " + ex.Message, "Error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Atención");
                return;
            }

            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var p = new Producto
            {
                IdProducto = int.Parse(txtID.Text),
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            try
            {
                if (productoDAO.Actualizar(p))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando: " + ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Atención");
                return;
            }

            if (MessageBox.Show("¿Eliminar este producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(txtID.Text);
                if (productoDAO.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando: " + ex.Message, "Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos(out decimal precio, out int stock)
        {
            precio = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("Nombre requerido."); return false; }

            if (!decimal.TryParse(txtPrecio.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out precio))
            { MessageBox.Show("Precio inválido."); return false; }

            if (!int.TryParse(txtStock.Text, out stock))
            { MessageBox.Show("Stock inválido."); return false; }

            return true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e) { }

        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
        private void txtStock_TextChanged(object sender, EventArgs e) { }
    }
}
