﻿using System;
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
        static private string conexionString = "Server=bwuqcvalsdelocgxtp9a-mysql.services.clever-cloud.com; Database=bwuqcvalsdelocgxtp9a; Uid=uy0okgaxam4x58av; Pwd=hvdeODwGw6OQ0qgdpxjH;";
        private MySqlConnection CX = new MySqlConnection(conexionString);

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