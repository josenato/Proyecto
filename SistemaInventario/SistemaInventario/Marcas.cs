﻿using System;
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
        string conexionString = "Server=sql3.freesqldatabase.com;Database=sql3301281;Uid=sql3301281;Pwd=HdXuswUhwU;";
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
                clear();
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
              //  gtb_datos.Columns[0].Visible = false;

            }

        }
        void clear()
        {
            txt_Descripcion.Text = txt_Descripcion.Text ="" ;
            MarcasID = 0;
            btn_guardar.ButtonText = "Guardar";
        }


        private void Marcas_Load(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }

        private void Gtb_datos_DoubleClick(object sender, EventArgs e)
        {
            if (gtb_datos.CurrentRow.Index !=  -1 )
            {
                txt_Descripcion.Text = gtb_datos.CurrentRow.Cells[1].Value.ToString();
                MarcasID = Convert.ToInt32(gtb_datos.CurrentRow.Cells[0].Value.ToString());
                btn_guardar.ButtonText = "Actualizar";
            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(conexionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("MarcasBuscarPalabra", mysqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_BuscarDatos", txt_buscar.text);
                DataTable carga_datos = new DataTable();
                sqlda.Fill(carga_datos);
                gtb_datos.DataSource = carga_datos;
              //  gtb_datos.Columns[0].Visible = false;

            }
        }
    }
}
