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
    public partial class SolicitudTonner : MaterialSkin.Controls.MaterialForm
    {

        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=localhost; Database=sistemas2019; Uid=root; Pwd=;";
        int TonerSSID = 0;

        public SolicitudTonner()
        {
            InitializeComponent();
        }

        private void SolicitudTonner_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarColor();
            CargarTonner();
            ListarTonerSS();
        }

        private void CargarMarcas()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Marcas.DataSource = ObjTonn.ListarMarcas();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
        }

        private void CargarColor()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbxColor.DataSource = ObjTonn.ListarColor();
            cbxColor.DisplayMember = "Color";
            cbxColor.ValueMember = "idColor_Cantidad";
        }


        private void CargarTonner()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Tonner.DataSource = ObjTonn.ListarTonerCbx();
            cbx_Tonner.DisplayMember = "Modelo";
            cbx_Tonner.ValueMember = "idTonner";
        }

        void clear()
        {
            cbxColor.Text = nudSoli.Text = cbx_Marcas.Text = cbx_Marcas.Text = cbx_Tonner.Text = "";
            TonerSSID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }

        private void ListarTonerSS()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarTonerSolicitud();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("TonnerSolicitudDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idTonnerSS", TonerSSID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
               
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarTonerSS(Convert.ToInt32(TonerSSID), Convert.ToInt32(cbx_Marcas.SelectedValue), Dtp_Fecha.Value,  Convert.ToInt32(cbxColor.SelectedValue), Convert.ToInt32(cbx_Tonner.SelectedValue), Convert.ToInt32(nudSoli.Value));
            MessageBox.Show("Se agrego correctamente");
            ListarTonerSS();
            clear();
        }
    }
}
