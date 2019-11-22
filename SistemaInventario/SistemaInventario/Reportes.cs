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
        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=bwuqcvalsdelocgxtp9a-mysql.services.clever-cloud.com; Database=bwuqcvalsdelocgxtp9a; Uid=uy0okgaxam4x58av; Pwd=hvdeODwGw6OQ0qgdpxjH;";
        int ReporteID = 0;

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
            objTonner.InsertarReporte(Convert.ToInt32(ReporteID),  Convert.ToInt32(cbx_Ubicacion.SelectedValue), dtp_Inicio.Value, dtp_Final.Value, txt_observaciones.Text,  Convert.ToInt32(cbx_Marcas.SelectedValue));
            MessageBox.Show("Se agrego correctamente");
            ListarReportes();
            clear();
        }

        void clear()
        {
            txt_observaciones.Text = cbx_Marcas.Text = cbx_Ubicacion.Text = dtp_Final.Text = "";

            ReporteID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                cbx_Ubicacion.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                dtp_Inicio.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                dtp_Final.Text = gtb_datos.CurrentRow.Cells[3].Value.ToString();
                txt_observaciones.Text = gtb_datos.CurrentRow.Cells[4].Value.ToString();
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[5].Value.ToString();
                ReporteID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;
            }
        }
    }
}
