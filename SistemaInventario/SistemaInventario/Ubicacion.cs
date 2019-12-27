using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Ubicacion : MetroFramework.Forms.MetroForm       
    {
        string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";
        int UbicacionID = 0;
        public Ubicacion()
        {
            InitializeComponent();
        }

        private void Ubicacion_Load(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("UbicacionAddEddit", mysqlCon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_idUbicacion", UbicacionID);
                mysqlcmd.Parameters.AddWithValue("_Ubicacion", tbx_Ubucacion.Text.Trim());
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("DATO GUARDADO");
                GridFill();
                clear();

            }
        }

        void GridFill()
        {
            using (MySqlConnection myslCon = new MySqlConnection(conexionString))
            {
                myslCon.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("UbicacionViewAll", myslCon);
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
                mysqlCmd.Parameters.AddWithValue("_idMarcas", UbicacionID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                GridFill();
                clear();

            }
        }

        void clear()
        {
            tbx_Ubucacion.Text = "";
              UbicacionID = 0;
            btn_guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
            GridFill();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
            GridFill();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                tbx_Ubucacion.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                UbicacionID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;

            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Impresoras fm = new Impresoras();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void Btn_Envios_Click(object sender, EventArgs e)
        {
            Envios_de_Toner fm = new Envios_de_Toner();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
    }

