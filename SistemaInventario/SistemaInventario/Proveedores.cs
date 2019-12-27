using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.CapaDatos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Proveedores : MaterialSkin.Controls.MaterialForm
    {

        ClsTonner objTonner = new ClsTonner();

        string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";
        int ProveedorID = 0;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            ListarProveedor();
        }

        private void CargarMarcas()
        {
            ClsTonner ObjTonn = new ClsTonner();
            cbx_Marcas.DataSource = ObjTonn.ListarMarcas();
            cbx_Marcas.DisplayMember = "Descripcion";
            cbx_Marcas.ValueMember = "idMarcas";
            
        }


        private void ListarProveedor()
        {
            ClsTonner objTonn = new ClsTonner();
            gtb_datos.DataSource = objTonn.ListarProveedor();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            objTonner.InsertarProveedor(Convert.ToInt32(ProveedorID), txtNombre.Text, Convert.ToInt32(cbx_Marcas.SelectedValue), txtAdquisicion.Text, dtpFecha.Value, tbxStatus.Text);
            MessageBox.Show("Se agrego correctamente");
            ListarProveedor();
            clear();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index != -1)
            {
                txtNombre.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                cbx_Marcas.Text = gtb_datos.CurrentRow.Cells[2].Value.ToString();
                txtAdquisicion.Text = gtb_datos.CurrentRow.Cells[3].Value.ToString();
                dtpFecha.Text = gtb_datos.CurrentRow.Cells[4].Value.ToString();
                tbxStatus.Text = gtb_datos.CurrentRow.Cells[5].Value.ToString();
                ProveedorID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = true;
            }
        }

        void clear()
        {
            tbxStatus.Text = cbx_Marcas.Text = txtAdquisicion.Text = txtNombre.Text = "";

            ProveedorID = 0;
            btn_Guardar.ButtonText = "Guardar";
            btn_Eliminar.Enabled = false;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("ProveedorDelete", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_idProveedor", ProveedorID);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dato Eliminado");
                ListarProveedor();
                clear();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ListarProveedor();
            clear();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Impresoras fm = new Impresoras();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
