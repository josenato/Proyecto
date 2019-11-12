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
    public partial class Reportes : MaterialSkin.Controls.MaterialForm
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarUbicacion();
            ListarReportes();
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

        private void ListarReportes()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarReportes();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
