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
    public partial class Cantidad_y_Color : MaterialSkin.Controls.MaterialForm
    {
        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";
        int CantidadColorID = 0;

        public Cantidad_y_Color()
        {
            InitializeComponent();
        }

        private void Cantidad_y_Color_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarTonner();
            ListarCantidadColor();
        }

        ////metodo para hacer select en los combox 
        private void CargarMarcas()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Marcas.DataSource = ObjTonn.ListarMarcas();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
        }

        private void CargarTonner()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Tonner.DataSource = ObjTonn.ListarTonerCbx();
            cbx_Tonner.DisplayMember = "Modelo";
            cbx_Tonner.ValueMember = "idTonner";
        }
        ///////////////////////////////////////
        
            //metodo para limpiar campos 
        void clear()
        {
            TbtxColor.Text = cbx_Marcas.Text = cbx_Marcas.Text = cbx_Tonner.Text = "";
            nudExistecia.Value = 0;
            CantidadColorID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }
        // ///////////////////////////////////////

        //evento del boton cancelar  ejecuta el metodo clear
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }
        // //////////////////////

            //metodo para cargar los datos en el datagrid
        private void ListarCantidadColor()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarCantidadColor();
        }

        //Evento del boton Guardar  
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarCantidadColor(Convert.ToInt32(CantidadColorID), TbtxColor.Text, Convert.ToInt32(nudExistecia.Value) ,Convert.ToInt32(cbx_Marcas.SelectedValue), Convert.ToInt32(cbx_Tonner.SelectedValue) );
            MessageBox.Show("Se agrego correctamente");
            ListarCantidadColor();
            clear();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                TbtxColor.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                nudExistecia.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[3].Value.ToString();
                cbx_Tonner.Text = gtb_datos.CurrentRow.Cells[4].Value.ToString();

                CantidadColorID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;

            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("Color_CantidadDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idColor_Cantidad", CantidadColorID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                clear();
                ListarCantidadColor();
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
