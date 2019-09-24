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
using MySql.Data.MySqlClient;
using MySql.Data;
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
            GridFill();           
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("MarcasAddEddit", mysqlCon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_idMarcas", MarcasID);
                mysqlcmd.Parameters.AddWithValue("_Descripcion", tbx_Marcas.Text.Trim());
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("DATO GUARDADO");
                GridFill();
                clear();
            }
        }

        void clear()
        {
            tbx_Marcas.Text = " ";
            MarcasID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
            GridFill();
        }

        void GridFill()
        {
            using (MySqlConnection myslCon = new MySqlConnection(conexionString))
            {
                myslCon.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("MarcasViewAll", myslCon);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtb_Marcas = new DataTable();
                sqlDA.Fill(dtb_Marcas);
                gtb_datos.DataSource = dtb_Marcas;
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("MarcasDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idMarcas", MarcasID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                GridFill();
                clear();
            }
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                tbx_Marcas.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();              
                MarcasID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;

            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
            GridFill();
        }
    }
}
