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
    /// Clase de acceso a datos para usuarios usando procedimientos almacenados.
    /// </summary>
    internal class DAOUsuarios
    {
        // Esta variable/atributo va a guardar un objeto de la clase Conexion, que sirve para abrir/cerrar conexiones a MySQL.
        private Conexion conexion;

        // Constructor que crea el objeto de conexión.
        public DAOUsuarios()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Método para autenticar al usuario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenaHash"></param>
        /// <returns></returns>
        public Usuario? Login(string usuario, string contrasenaHash)
        {
            Usuario? u = null; // Inicialmente es nulo, si no se encuentra el usuario, se devuelve nulo.

            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT * FROM usuarios WHERE usuario=@u AND contrasena=@c"; // Consult SQL para autenticar un usuario.

                using var cmd = new MySqlCommand(query, conn); // Comanado para ejecutar la consulta.
                cmd.Parameters.AddWithValue("@u", usuario); // Recibe nombre de usuario
                cmd.Parameters.AddWithValue("@c", contrasenaHash); // Recibe contraseña hasheada

                using var reader = cmd.ExecuteReader(); // reader para leer los resultados de la consulta.
                if (reader.Read()) // Si existe una fila: construye un nuevo objeto Usuario con los datos de la BD.
                {
                    u = new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NombreUsuario = reader.GetString("usuario"),
                        Contrasena = reader.GetString("contrasena"),
                        Rol = reader.GetString("rol")
                    };
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en Login: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return u;
        }

        /// <summary>
        /// Método que devuelve una lista de ususarios desde un procedimiennto almacenado.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new(); // Lista vacía de usuarios.

            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spListarUsuarios", conn); // Comando para ejecutar el procemiento almacenado.
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Indica que es un procedimiento almacenado.

                using var reader = cmd.ExecuteReader(); // Reader para leer los resultados.
                while (reader.Read()) // Mientras haya filas, crea un nuevo objeto Usuario y lo añade a la lista.
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NombreUsuario = reader.GetString("usuario"),
                        Rol = reader.GetString("rol"),
                        Contrasena = ""
                    });
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }

        /// <summary>
        /// Método para insertar un nuevo usuario usando un procedimiento alamacenado.
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool Insertar(Usuario u)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spInsertarUsuario", conn); // Comando para ejecutar el procemiento almacenado.
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Indica que es un procedimiento almacenado.

                cmd.Parameters.AddWithValue("@pUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@pContrasena", u.Contrasena);
                cmd.Parameters.AddWithValue("@pRol", u.Rol);

                return cmd.ExecuteNonQuery() > 0; // Devuelve true si se insertó al menos una fila.
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar usuario: " + ex.Message);
                return false; // En caso de error, devuelve false.
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Método para actualizar un usuario usando un procemiento almacenado.
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool Actualizar(Usuario u)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spActualizarUsuario", conn); // Comando para ejecutar el procedimiento almacenado. 
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Indica que es un procedimiento almacenado. 

                cmd.Parameters.AddWithValue("@pId", u.IdUsuario);
                cmd.Parameters.AddWithValue("@pUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@pContrasena", u.Contrasena);
                cmd.Parameters.AddWithValue("@pRol", u.Rol);

                return cmd.ExecuteNonQuery() > 0; // Devuelve true si se actualizó al menos una fila.
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                return false; // En caso de error, devuelve false.
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// Método para eliminar un usuario usando un procedimiento almanesado. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Eliminar(int id)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spEliminarUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pId", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }

}
