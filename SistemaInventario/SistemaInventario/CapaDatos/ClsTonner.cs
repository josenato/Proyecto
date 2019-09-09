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
    class ClsTonner
    {
        private ConectarBD Conexion = new ConectarBD();
        private MySqlCommand cm = new MySqlCommand();
        private MySqlDataReader LeerFilas;

        public DataTable ListarMarcas()
        {
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "MarcasViewAll";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

        public void InsertarTonner(int idTonner, string Modelo, int marcas_idMarcas )
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idTonner", idTonner);
            cm.Parameters.AddWithValue("_Modelo", Modelo);
            cm.Parameters.AddWithValue("_marcas_idMarcas", marcas_idMarcas);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
        }
        public DataTable ListarTonner()
        {
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

    }
}
