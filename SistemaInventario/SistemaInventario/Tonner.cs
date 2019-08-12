using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Tonner : MaterialSkin.Controls.MaterialForm
    {
        string conexionString = "Server=sql3.freesqldatabase.com;Database=sql3301281;Uid=sql3301281;Pwd=HdXuswUhwU;";
        int TonnerID = 0;
        public Tonner()
        {
            InitializeComponent();
        }

        private void Tonner_Load(object sender, EventArgs e)
        {

        }
    }
}
