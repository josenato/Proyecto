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
    public partial class Marcas : MetroFramework.Forms.MetroForm
    {
        string conexionString = @"Server=localhost; Database=sistemaimpresora; Udi=root; Pwd=;";
        int MarcasID = 0;
        public Marcas()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("MarcasAddEddit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idMarcas", MarcasID);
                mysqlCmd.Parameters.AddWithValue("_Descripcion", txt_Descripcion.Text.Trim());
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
                MySqlDataAdapter sqlda = new MySqlDataAdapter("MarcasViewAll", mysqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable carga_datos = new DataTable();
                sqlda.Fill(carga_datos);
                gtb_datos.DataSource = carga_datos;

            }

        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}
