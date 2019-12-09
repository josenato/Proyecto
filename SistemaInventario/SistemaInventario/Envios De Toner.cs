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
    public partial class Envios_de_Toner : MaterialSkin.Controls.MaterialForm
    {
        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=localhost; Database=sistemas2019; Uid=root; Pwd=;";
        int TonerEnviosID = 0;

        public Envios_de_Toner()
        {
            InitializeComponent();
        }

        private void Envios_de_Toner_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            ListarTonerEnvios();
            CargarTonner();
            CargarColor();
            CargarUbicacion();
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

        private void CargarUbicacion()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Ubicacion.DataSource = ObjTonn.ListarUbicaciones();
            cbx_Ubicacion.DisplayMember = "Ubicacion";
            cbx_Ubicacion.ValueMember = "idUbicacion";
        }

        private void ListarTonerEnvios()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarTonerEnvios();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarTonerEnvios(Convert.ToInt32(TonerEnviosID), Convert.ToInt32(cbx_Ubicacion.SelectedValue), Convert.ToInt32(cbx_Marcas.SelectedValue),  Convert.ToInt32(cbx_Tonner.SelectedValue), Convert.ToInt32(nud_Envios.Value), Convert.ToInt32(cbxColor.SelectedValue), Dtp_Fecha.Value);
            MessageBox.Show("Se agrego correctamente");
            ListarTonerEnvios();
            clear();
        }


        void clear()
        {
            cbxColor.Text = nud_Envios.Text = cbx_Marcas.Text = cbx_Marcas.Text = cbx_Tonner.Text = "";
            TonerEnviosID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
            ListarTonerEnvios();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("TonnerEnviosDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idTonnerC", TonerEnviosID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                clear();
                ListarTonerEnvios();
            }
        }

        private void Btn_CC_Click(object sender, EventArgs e)
        {
            Cantidad_y_Color fm = new Cantidad_y_Color();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void Btn_Toner_Click(object sender, EventArgs e)
        {
            Tonner fm = new Tonner();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void Btn_Ubi_Click(object sender, EventArgs e)
        {
            Ubicacion fm = new Ubicacion();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void Btn_Marcas_Click(object sender, EventArgs e)
        {
            Marcas fm = new Marcas();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
