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
    /// Formulario para el CRUD de productos.
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

        // ─────────────────────────────────────────
        // Carga inicial
        // ─────────────────────────────────────────

        private void FrmCrudProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            txtCodigo.Focus();
        }

        // ─────────────────────────────────────────
        // Helpers de UI
        // ─────────────────────────────────────────

        private void LimpiarCampos()
        {
            txtID.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCodigo.Focus();
        }

        private void ListarProductos()
        {
            try
            {
                List<Producto> lista = productoDAO.ListarTodos();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                // Encabezados amigables
                RenombrarColumna("IdProducto", "ID");
                RenombrarColumna("Codigo", "Código");
                RenombrarColumna("Nombre", "Nombre");
                RenombrarColumna("Descripcion", "Descripción");
                RenombrarColumna("Precio", "Precio");
                RenombrarColumna("Stock", "Stock");

                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MostrarError("Error al listar productos", ex);
            }
            finally
            {
                dgvProductos.Enabled = true;
            }
        }

        /// <summary>Renombra el encabezado de una columna si existe.</summary>
        private void RenombrarColumna(string nombreColumna, string encabezado)
        {
            if (dgvProductos.Columns.Contains(nombreColumna))
                dgvProductos.Columns[nombreColumna].HeaderText = encabezado;
        }

        /// <summary>Muestra un MessageBox de error estandarizado.</summary>
        private static void MostrarError(string contexto, Exception ex)
        {
            MessageBox.Show($"{contexto}:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>Muestra un MessageBox de advertencia estandarizado.</summary>
        private static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ─────────────────────────────────────────
        // Validación — delega a ValidadorProducto
        // ─────────────────────────────────────────

        private bool ValidarCampos(out decimal precio, out int stock)
        {
            precio = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código del producto es requerido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es requerido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out precio))
            {
                MessageBox.Show("El precio ingresado no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("El stock ingresado no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        // ─────────────────────────────────────────
        // Eventos de botones
        // ─────────────────────────────────────────

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProductos();
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
                    MessageBox.Show("Producto insertado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al insertar el producto", ex);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MostrarAdvertencia("Seleccione un producto de la tabla para actualizar.");
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
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al actualizar el producto", ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MostrarAdvertencia("Seleccione un producto de la tabla para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(txtID.Text);

                if (productoDAO.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar el producto", ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ─────────────────────────────────────────
        // Selección de fila en el DataGridView
        // ─────────────────────────────────────────

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
                MostrarError("Error al seleccionar el producto", ex);
            }
        }

        // ─────────────────────────────────────────
        // Eventos vacíos requeridos por el diseñador
        // ─────────────────────────────────────────

        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void txtCodigo_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
        private void txtStock_TextChanged(object sender, EventArgs e) { }
    }
}
