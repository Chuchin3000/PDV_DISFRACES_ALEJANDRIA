using PVD_DISFRACES_ALEJANDRIA.DAO;
using PVD_DISFRACES_ALEJANDRIA.Modelos;
using PVD_DISFRACES_ALEJANDRIA.Utils;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                c.Abrir();
                MessageBox.Show("Conexión exitosa.");
                c.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e) { }

        private void lblContraseña_Click(object sender, EventArgs e) { }

        private void txtUsuario_TextChanged(object sender, EventArgs e) { }

        private void txtContraseña_TextChanged(object sender, EventArgs e) { }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim(); // Sin ToLower(), respeta mayúsculas
                string contrasena = txtContraseña.Text.Trim();

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña.");
                    return;
                }

                string contrasenaHash = Seguridad.HashSHA256(contrasena);

                DAOUsuarios dao = new DAOUsuarios();
                Usuario? u = dao.Login(usuario, contrasenaHash);

                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return;
                }

                MessageBox.Show("Bienvenido, " + u.NombreUsuario);

                if (u.Rol == "admin")
                    new FrmMenuAdmin(u.IdUsuario).Show();
                else
                    new FrmMenuEmpleado(u.IdUsuario).Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Login: " + ex.Message);
            }
        }
    }
}
