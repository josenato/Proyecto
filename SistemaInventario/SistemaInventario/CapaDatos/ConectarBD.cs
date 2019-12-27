using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace SistemaInventario.CapaDatos
{
    class ConectarBD
    {
        // static private string conexionString = "Server=localhost; Database=sistemas2019; Uid=root; Pwd=;"; 
        static private string conexionString = "Server=172.17.254.84; Database=sistemas2019; Uid=SistemasCDC; Pwd=;";
        public MySqlConnection CX = new MySqlConnection(conexionString); 

        public MySqlConnection AbrirCX()
        {
            if (CX.State == System.Data.ConnectionState.Closed)
                CX.Open();
            return CX;
        }
       
        public MySqlConnection CerraCX()
        {
            if (CX.State == System.Data.ConnectionState.Open)
                CX.Close();
            return CX;
        }
    }
}
