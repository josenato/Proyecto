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
    public partial class Impresoras : MaterialSkin.Controls.MaterialForm  
    {

        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=bwuqcvalsdelocgxtp9a-mysql.services.clever-cloud.com; Database=bwuqcvalsdelocgxtp9a; Uid=uy0okgaxam4x58av; Pwd=hvdeODwGw6OQ0qgdpxjH;";
        int ImpresoraID = 0;

        public Impresoras()
        {
            InitializeComponent();
        }

        private void Impresoras_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            ListarImpresora();
            CargarUbicacion();
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

        private void ListarImpresora()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarImpresora();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarImpresora(Convert.ToInt32(ImpresoraID), Convert.ToInt32(cbx_Marcas.SelectedValue), btn_Serialss.Text, Convert.ToInt32(cbx_Ubicacion.SelectedValue), tbx_IP.Text, txb_status.Text, txtb_Modelo.Text);
            MessageBox.Show("Se agrego correctamente");
            ListarImpresora();
            
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                btn_Serialss.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                cbx_Ubicacion.Text = gtb_datos.CurrentRow.Cells[3].Value.ToString();
                tbx_IP.Text = gtb_datos.CurrentRow.Cells[4].Value.ToString();
                txb_status.Text = gtb_datos.CurrentRow.Cells[5].Value.ToString();
                txtb_Modelo.Text = gtb_datos.CurrentRow.Cells[6].Value.ToString();
                ImpresoraID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;
            }
        }

        void clear()
        {
            cbx_Marcas.Text = btn_Serialss.Text = cbx_Ubicacion.Text = tbx_IP.Text = txb_status.Text = txtb_Modelo.Text   = "";
            ImpresoraID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("ImpresoraDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idImpresora", ImpresoraID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                clear();
                ListarImpresora();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
