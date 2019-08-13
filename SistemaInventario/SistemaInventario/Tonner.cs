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
        private DataTable CargarR()
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                DataTable dt = new DataTable();


                string query = "SELECT * FROM Marcas";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                adap.Fill(dt);
                return dt;
            }
        }

        private void Tonner_Load(object sender, EventArgs e)
        {
            cbx_Marcas.DataSource = CargarR();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
            GridFill();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("TonnerAddEddit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idTonner", TonnerID);
                mysqlCmd.Parameters.AddWithValue("_Modelo", txt_Modelo.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_MarcasIdTonner", cbx_Marcas.SelectedValue);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Guardado");
                GridFill();
                
            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(conexionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("TonnerViewAll", mysqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable carga_datos = new DataTable();
                sqlda.Fill(carga_datos);
                gtb_datos.DataSource = carga_datos;
                //  gtb_datos.Columns[0].Visible = false;

            }

        }

    }
}
