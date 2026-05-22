using MySqlConnector;
using PVD_DISFRACES_ALEJANDRIA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{
    /// <summary>
    /// Clase DAO para manejar las operaciones de ventas
    /// </summary>
    internal class VentaDAO
    {
        private readonly Conexion conexion;

        public VentaDAO()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Inserta una venta con sus detalles en una transacción.
        /// Devuelve idVenta si fue exitosa, o 0 si falla.
        /// </summary>
        public int RegistrarVentaConDetalle(int idUsuario, List<DetalleVenta> detalles)
        {
            if (detalles == null || detalles.Count == 0) return 0;

            int nuevoIdVenta = 0;
            var conn = conexion.Abrir();
            using var trans = conn.BeginTransaction();

            try
            {
                // 1) Calcular total
                decimal total = 0m;
                foreach (var d in detalles) total += d.PrecioUnitario * d.Cantidad;

                // 2) Insertar venta
                using (var cmdVenta = new MySqlCommand("spRegistrarVenta", conn, trans))
                {
                    cmdVenta.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdVenta.Parameters.AddWithValue("pFecha", DateTime.Now);
                    cmdVenta.Parameters.AddWithValue("pIdUsuario", idUsuario);
                    cmdVenta.Parameters.AddWithValue("pTotal", total);

                    using var reader = cmdVenta.ExecuteReader();
                    if (reader.Read())
                        nuevoIdVenta = Convert.ToInt32(reader["idVenta"]);
                    reader.Close();
                }

                if (nuevoIdVenta <= 0)
                    throw new Exception("No se pudo obtener el id de la venta.");

                // 3) Insertar detalles y actualizar stock
                foreach (var d in detalles)
                {
                    using (var cmdDet = new MySqlCommand("spRegistrarDetalle", conn, trans))
                    {
                        cmdDet.CommandType = System.Data.CommandType.StoredProcedure;
                        cmdDet.Parameters.AddWithValue("pIdVenta", nuevoIdVenta);
                        cmdDet.Parameters.AddWithValue("pIdProducto", d.IdProducto);
                        cmdDet.Parameters.AddWithValue("pCantidad", d.Cantidad);
                        cmdDet.Parameters.AddWithValue("pPrecioUnitario", d.PrecioUnitario);
                        cmdDet.ExecuteNonQuery();
                    }

                    using (var cmdStock = new MySqlCommand("spActualizarStock", conn, trans))
                    {
                        cmdStock.CommandType = System.Data.CommandType.StoredProcedure;
                        cmdStock.Parameters.AddWithValue("pIdProducto", d.IdProducto);
                        cmdStock.Parameters.AddWithValue("pCantidadVendida", d.Cantidad);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                trans.Commit();
                return nuevoIdVenta;
            }
            catch (Exception)
            {
                try { trans.Rollback(); } catch { }
                throw;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Busca un producto por su código de barras.
        /// Devuelve null si no existe.
        /// </summary>
        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            Producto? p = null;
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand(
                    "SELECT * FROM productos WHERE codigo = @codigo LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    p = new Producto
                    {
                        IdProducto = reader.GetInt32("idProducto"),
                        Codigo = reader.GetString("codigo"),
                        Nombre = reader.GetString("nombre"),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion"))
                                        ? "" : reader.GetString("descripcion"),
                        Precio = reader.GetDecimal("precio"),
                        Stock = reader.GetInt32("stock")
                    };
                }
            }
            finally
            {
                conexion.Cerrar();
            }
            return p;
        }
    }

}
