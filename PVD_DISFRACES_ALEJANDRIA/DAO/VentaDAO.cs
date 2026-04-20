using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{

    internal class VentaDAO
    {

        public void MostrarProductosDisponibles(DataGridView tabla)
        {

            using (MySqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    String sql = "select * From productos where cantidad > 0 and descontinuado = false;";
                    // Baseamos los datos
                    tabla.DataSource = null;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        // llenamos la tabla
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tabla.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar la tabla de productos, error: \n" + ex.Message);
                }
            }

        }

        public void seleccionarProducto(DataGridView tabla, TextBox id_producto, TextBox nombre, TextBox precio,
            TextBox talla, CheckBox descontinuado, TextBox id_categoria, TextBox categoria)
        {
            int fila = tabla.CurrentRow.Index;

            try
            {

                if (fila >= 0)
                {

                    id_producto.Text = tabla.Rows[fila].Cells[0].Value.ToString();
                    nombre.Text = tabla.Rows[fila].Cells[1].Value.ToString();
                    precio.Text = tabla.Rows[fila].Cells[3].Value.ToString();
                    talla.Text = tabla.Rows[fila].Cells[4].Value.ToString();
                    id_categoria.Text = tabla.Rows[fila].Cells[5].Value.ToString();
                    categoria.Text = tabla.Rows[fila].Cells[6].Value.ToString();
                    descontinuado.Checked = (bool)tabla.Rows[fila].Cells[7].Value;

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Ocurrió un error al seleccionar el producto, Error: \n" + ex.Message);
            }
        }

        public void pasarProductosAlCarrito ( DataGridView tabla, TextBox idProducto,TextBox nombreProducto, 
            TextBox precioPieza, NumericUpDown cantidad)
        {

            try
            {

                DataTable modelo = (DataTable)tabla.DataSource;

                if (modelo == null)
                {
                    modelo = new DataTable();

                    modelo.Columns.Add("id_producto", typeof(string));
                    modelo.Columns.Add("nombre_producto", typeof(string));
                    modelo.Columns.Add("precio_unidad", typeof(double));
                    modelo.Columns.Add("cantidad", typeof(int));
                    modelo.Columns.Add("SubTotal", typeof(double));

                    tabla.DataSource = modelo;
                }

                string idProductoText = idProducto.Text;

                foreach (DataRow row in modelo.Rows)
                {

                    string idExistente = row["id_producto"].ToString();

                    if (idExistente.Equals(idProductoText))
                    {

                        MessageBox.Show("El producto ya está en el carrito 😀");
                        return;

                    }

                }

                double precioPiezaDouble = double.Parse(precioPieza.Text);
                int cantidadInt = int.Parse(cantidad.Text);

                double subTotal = precioPiezaDouble * cantidadInt;

                modelo.Rows.Add(idProductoText, nombreProducto.Text, precioPiezaDouble, cantidadInt, subTotal);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar productos registrados, error: \n" + ex.Message);
            }

        }
    }
}
