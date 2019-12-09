using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click_1(object sender, EventArgs e)
        {
            Impresoras fm = new Impresoras();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            Envios_de_Toner fm = new Envios_de_Toner();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
