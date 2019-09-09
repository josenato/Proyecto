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
using SistemaInventario.CapaDatos;


namespace SistemaInventario
{
    public partial class Tonner : MaterialSkin.Controls.MaterialForm
    {
         ClsTonner objTonner = new ClsTonner();
        string conexionString = "Server=sql3.freesqldatabase.com;Database=sql3301281;Uid=sql3301281;Pwd=HdXuswUhwU;";
        int TonnerID = 0;
        public Tonner()
        {
            InitializeComponent();
        }
       

        private void Tonner_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            ListarTonner();
        }

        private void CargarMarcas()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Marcas.DataSource = ObjTonn.ListarMarcas();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
        }

        
       
        void clear()
        {
            txt_Modelo.Text = cbx_Marcas.Text = "";
            TonnerID = 0;
            btn_guardar.ButtonText = "Guardar";
            btn_borrar.Enabled = false;
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
            mysqlCon.Open();
              MySqlCommand mysqlCmd = new MySqlCommand("MarcasDelete", mysqlCon);
              mysqlCmd.CommandType = CommandType.StoredProcedure;
              mysqlCmd.Parameters.AddWithValue("_idMarcas", TonnerID);
              mysqlCmd.ExecuteNonQuery();
             MessageBox.Show("Dato Eliminado");
             clear();
                ListarTonner();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        //evento para buscar datos 
        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarTonner(Convert.ToInt32(TonnerID) ,txt_Modelo.Text, Convert.ToInt32(cbx_Marcas.SelectedValue));
            MessageBox.Show("Se agrego correctamente");
            ListarTonner();
        }

        private void ListarTonner()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarTonner();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if(gtb_datos.CurrentRow.Index != -1)
            {
                txt_Modelo.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                TonnerID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_guardar.Text = "Actualizar";


            }
        }
    }
}
