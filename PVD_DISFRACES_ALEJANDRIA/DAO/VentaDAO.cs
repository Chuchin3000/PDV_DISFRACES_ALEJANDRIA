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
            TextBox talla, TextBox id_categoria, TextBox categoria)
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

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Ocurrió un error al seleccionar el producto, Error: \n" + ex.Message);
            }
        }

        public void pasarProductosAlCarrito ( DataGridView tabla, TextBox idProducto,TextBox nombreProducto, 
            TextBox precioPieza, NumericUpDown cantidad, TextBox descuento)
        {

            try
            {

                DataTable modelo = (DataTable)tabla.DataSource;

                if (modelo == null)
                {
                    modelo = new DataTable();

                    modelo.Columns.Add("Id_producto", typeof(string));
                    modelo.Columns.Add("Nombre_producto", typeof(string));
                    modelo.Columns.Add("Precio_unidad", typeof(double));
                    modelo.Columns.Add("Cantidad", typeof(int));
                    modelo.Columns.Add("Descuento", typeof(int));
                    modelo.Columns.Add("SubTotal", typeof(double));

                    tabla.DataSource = modelo;
                }

                string idProductoText = idProducto.Text;

                foreach (DataRow row in modelo.Rows)
                {

                    string idExistente = row["Id_producto"].ToString();

                    if (idExistente.Equals(idProductoText))
                    {

                        MessageBox.Show("El producto ya está en el carrito 😀");
                        return;

                    }

                }

                double precioPiezaDouble = double.Parse(precioPieza.Text);
                int cantidadInt = int.Parse(cantidad.Text);
                int descuentoInt = int.Parse(descuento.Text);

                double subTotal = precioPiezaDouble * cantidadInt * ( 1 - descuentoInt / 100.0 );
                subTotal = Math.Round(subTotal, 2);

                modelo.Rows.Add(idProductoText, nombreProducto.Text, precioPiezaDouble, cantidadInt, descuentoInt, subTotal);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar productos registrados, error: \n" + ex.Message);
            }

        }

    }
}
