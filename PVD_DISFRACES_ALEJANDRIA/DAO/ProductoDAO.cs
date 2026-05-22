using MySqlConnector;
using PVD_DISFRACES_ALEJANDRIA.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVD_DISFRACES_ALEJANDRIA.DAO
{
    /// <summary>
    /// Clase que gestiona consultas SQL de Productos
    /// </summary>
    internal class ProductoDAO
    {
        private Conexion conexion;

        public ProductoDAO()
        {
            conexion = new Conexion();
        }

        public bool Insertar(Producto p)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spInsertarProducto", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("pCodigo", p.Codigo ?? string.Empty);
                cmd.Parameters.AddWithValue("pNombre", p.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("pDescripcion", p.Descripcion ?? string.Empty);
                cmd.Parameters.AddWithValue("pPrecio", p.Precio);
                cmd.Parameters.AddWithValue("pStock", p.Stock);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool Actualizar(Producto p)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spActualizarProducto", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("pIdProducto", p.IdProducto);
                cmd.Parameters.AddWithValue("pCodigo", p.Codigo ?? string.Empty);
                cmd.Parameters.AddWithValue("pNombre", p.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("pDescripcion", p.Descripcion ?? string.Empty);
                cmd.Parameters.AddWithValue("pPrecio", p.Precio);
                cmd.Parameters.AddWithValue("pStock", p.Stock);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spEliminarProducto", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("pIdProducto", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public List<Producto> ListarTodos()
        {
            var lista = new List<Producto>();
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spListarProductos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = reader.GetInt32("idProducto"),
                        Codigo = reader["codigo"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        Precio = reader.GetDecimal("precio"),
                        Stock = reader.GetInt32("stock")
                    });
                }
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }
    }

}
