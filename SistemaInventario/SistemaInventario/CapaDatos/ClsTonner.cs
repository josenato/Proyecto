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

        // metodo para los combobpx
        public DataTable ListarMarcas()
        {
            //metodo para listar los datos de la tabla marcas en un combobox
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "MarcasViewAll";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

        public DataTable ListarUbicaciones()
        {
            //metodo para listar los datos de la tabla ubicaciones en un combobox
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "UbicacionViewAll";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

        public DataTable ListarTonerCbx()
        {
            //metodo para listar los datos de la tabla tonner en un combobox
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerViewAll";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }
        ///////////////////////////////////////////////////////////////////////////////////////






        //metodo para agregar los datos para la tabla tonner
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

        public void InsertarProveedor(int idProveedor, string Nombre, int Marcas_idMarcas, string Adquisicion, DateTime Fecha_Adquisicion, string Estatus_Adquisicion)
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ProveedorAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idProveedor", idProveedor);
            cm.Parameters.AddWithValue("_Nombre", Nombre);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.Parameters.AddWithValue("_Adquisicion", Adquisicion);
            cm.Parameters.AddWithValue("_Fecha_Adquisicion", Fecha_Adquisicion);
            cm.Parameters.AddWithValue("_Estatus_Adquisicion", Estatus_Adquisicion);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
        }

        //metodo para agregar datos  en la tabla CantidadColor 
        public void InsertarCantidadColor(int idColor_Cantidad, string Color, int Cantidad, int Marcas_idMarcas, int Tonner_idTonner)
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ColorCantidadAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idColor_Cantidad", idColor_Cantidad);
            cm.Parameters.AddWithValue("_Color", Color);
            cm.Parameters.AddWithValue("_Cantidad", Cantidad);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.Parameters.AddWithValue("_Tonner_idTonner", Tonner_idTonner);
            cm.ExecuteNonQuery(); //error  revisar el procedimiento almacenado 
            cm.Parameters.Clear();
        }



        //////////////////////////////////////////////////////////////////////////////////////////

        public DataTable ListarTonner()
        {//metodo para listar los datos de la tabla tonner en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }


        public DataTable ListarCantidadColor()
        {//metodo para listar los datos de la tabla Cantidad Color  en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "Color_CantidadViewAllInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

        public DataTable ListarImpresora()
        {//metodo para listar los datos de la tabla Cantidad Color  en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ImpresoraViewAllInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

        public DataTable ListarReportes()
        {//metodo para listar los datos de la tabla Reportes  en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ReportesViewAllInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }
        public DataTable ListarProveedor()
        {//metodo para listar los datos de la tabla tonner en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ProveedorViewAllInnerJoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }

    }
}
