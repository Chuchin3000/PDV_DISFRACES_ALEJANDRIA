using PVD_DISFRACES_ALEJANDRIA.DAO;
using PVD_DISFRACES_ALEJANDRIA.Forms;

namespace PVD_DISFRACES_ALEJANDRIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentas CVenta = new FrmVentas();
            this.Hide();
            CVenta.Show();
        }
    }
}
