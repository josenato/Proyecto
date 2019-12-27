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
using Microsoft.Reporting.WinForms;

namespace SistemaInventario
{
    public partial class ImpresoraReporte : Form
    {
       MySqlConnection Connexion;

        string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";

         ClsTonner objTonner = new ClsTonner();
        public ImpresoraReporte( MySqlConnection Connexion)
        {
            InitializeComponent();
            this.Connexion = Connexion;
        }

        private void ImpresoraReporte_Load(object sender, EventArgs e)
        {

            this.RptImpresora.RefreshReport();
        }

        private void btnRporte_Click(object sender, EventArgs e)
        {
            String Consulta = "select * from impresora";

            MySqlDataAdapter da = new MySqlDataAdapter(Consulta, conexionString);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource Fuentes;
            Fuentes = new ReportDataSource("Impresora", ds.Tables[0]);

            RptImpresora.LocalReport.DataSources.Clear();
            RptImpresora.LocalReport.DataSources.Add(Fuentes);
            RptImpresora.LocalReport.ReportEmbeddedResource = "SistemaInventario.ReporteImpresora.rdlc";

            RptImpresora.LocalReport.Refresh();
            RptImpresora.Refresh();
            RptImpresora.RefreshReport();
        }
    }
}
