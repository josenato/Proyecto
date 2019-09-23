using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventario.CapaDatos;

namespace SistemaInventario
{
    public partial class Marcas : MetroFramework.Forms.MetroForm
    {
       

        string conexionString = "Server=bwuqcvalsdelocgxtp9a-mysql.services.clever-cloud.com; Database=bwuqcvalsdelocgxtp9a; Uid=uy0okgaxam4x58av; Pwd=hvdeODwGw6OQ0qgdpxjH;";
        int MarcasID = 0;
        public Marcas()
        {
            InitializeComponent();
            
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
