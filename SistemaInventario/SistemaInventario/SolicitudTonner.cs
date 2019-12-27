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

        string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";
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

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                Dtp_Fecha.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                cbxColor.Text = gtb_datos.CurrentRow.Cells[3].Value.ToString();
                cbx_Tonner.Text = gtb_datos.CurrentRow.Cells[4].Value.ToString();
                nudSoli.Text = gtb_datos.CurrentRow.Cells[5].Value.ToString();


                TonerSSID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;

            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Envios_de_Toner fm = new Envios_de_Toner();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
