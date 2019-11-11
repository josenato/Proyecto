using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaInventario.CapaDatos;

namespace SistemaInventario
{
    public partial class Impresoras : MaterialSkin.Controls.MaterialForm  
    {

        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=bwuqcvalsdelocgxtp9a-mysql.services.clever-cloud.com; Database=bwuqcvalsdelocgxtp9a; Uid=uy0okgaxam4x58av; Pwd=hvdeODwGw6OQ0qgdpxjH;";
        int ImpresoraID = 0;

        public Impresoras()
        {
            InitializeComponent();
        }

        private void Impresoras_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            ListarImpresora();
            CargarUbicacion();
        }

        private void CargarMarcas()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Marcas.DataSource = ObjTonn.ListarMarcas();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
        }

        private void CargarUbicacion()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Ubicacion.DataSource = ObjTonn.ListarUbicaciones();
            cbx_Ubicacion.DisplayMember = "Ubicacion";
            cbx_Ubicacion.ValueMember = "idUbicacion";
        }

        private void ListarImpresora()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarImpresora();
        }
    }
}
