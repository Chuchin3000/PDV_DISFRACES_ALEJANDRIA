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
    /// CLASE DE ACCESO A DATOS PARA EMPLEADOS USANDO PROCEDIMIENTOS ALMACENADOS
    /// </summary>
    internal class EmpleadoDAO
    {
        /// <summary>
        /// Método para insertar un nuevo empleado mediante un procedimiento almacenado
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public bool Insertar(Empleado empleado)
        {
            Conexion conexion = new Conexion(); // Crea una nueva instancia de la clase Conexion

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spInsertarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Método para actualizar los datos de un empleado existente usando un procedimiento almacenado
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public bool Actualizar(Empleado empleado)
        {
            Conexion conexion = new Conexion(); // Crea una instancia de la clase Conexion

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spActualizarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pId", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Método para eliminar un empleado de la BD usando un procedimineto almacenado
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public bool Eliminar(int idEmpleado)
        {
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spEliminarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pId", idEmpleado);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Método que devuelve una lista de empleados dede un procedimineto almacenado
        /// </summary>
        /// <returns></returns>
        public List<Empleado> ListarTodos()
        {
            List<Empleado> empleados = new List<Empleado>(); // Lista vacía de empleados
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spListarEmpleados", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader()) // reader para leer los resultados de la consulta
                    {
                        while (reader.Read()) // Mientras haya filas, crea un nuevo objeto Empleado y lo añade a la lista.
                        {
                            empleados.Add(new Empleado
                            {
                                IdEmpleado = reader.GetInt32("idEmpleado"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.IsDBNull(reader.GetOrdinal("apellido"))
                                            ? "" : reader.GetString("apellido"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono"))
                                            ? "" : reader.GetString("telefono"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion"))
                                            ? "" : reader.GetString("direccion")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al listar empleados: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleados;
        }

        /// <summary>
        /// Método para obtener un empleado mediante su id
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public Empleado ObtenerPorId(int idEmpleado)
        {
            Empleado empleado = null; // Todavía NO apunta a ningún objeto, está vacía
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                string query = "SELECT * FROM empleados WHERE idEmpleado = @id"; // Comando de consulta que busca un empleado por su id

                using (var cmd = new MySqlCommand(query, conn)) // Ejecuta la consulta SQL
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado); // Reemplaza @id con el ID recibido en el método.

                    using (var reader = cmd.ExecuteReader()) // // Reader para leer los resultados.
                    {
                        if (reader.Read()) // // Si existe una fila: construye un nuevo objeto Empleado con los datos de la BD.
                        {
                            empleado = new Empleado
                            {
                                IdEmpleado = reader.GetInt32("idEmpleado"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.IsDBNull(reader.GetOrdinal("apellido"))
                                            ? "" : reader.GetString("apellido"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono"))
                                            ? "" : reader.GetString("telefono"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion"))
                                            ? "" : reader.GetString("direccion")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener empleado por ID: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleado;
        }
    }

}
