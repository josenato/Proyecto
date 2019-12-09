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


        public DataTable ListarColor()
        {
            //metodo para listar los datos de la tabla color_cantidad en un combobox
            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "Color_CantidadSELECT";
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
        ////////////////////////////////////METODO INSER INTO EN EL DATA GRID///////////////////////////////////////////////////


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


        public void InsertarTonerSS(int idTonnerSS, int Marcas_idMarcas, DateTime Fecha_Llegada, int Color_Cantidad_idColor_Cantidad, int Tonner_idTonner, int TonnerRecivido)
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerSolicitudAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idTonnerSS", idTonnerSS);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.Parameters.AddWithValue("_Fecha_Llegada", Fecha_Llegada);
            cm.Parameters.AddWithValue("_Color_Cantidad_idColor_Cantidad", Color_Cantidad_idColor_Cantidad);
            cm.Parameters.AddWithValue("_Tonner_idTonner", Tonner_idTonner);
            cm.Parameters.AddWithValue("_TonnerRecivido", TonnerRecivido);
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

        public void InsertarReporte(int idReportes, int Ubicacion_idUbicacion, DateTime Fecha_Reporte, DateTime Fecha_Cierre, string Observacion, int Marcas_idMarcas)
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ReportesAddEdit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idReportes", idReportes);
            cm.Parameters.AddWithValue("_Ubicacion_idUbicacion", Ubicacion_idUbicacion);
            cm.Parameters.AddWithValue("_Fecha_Reporte", Fecha_Reporte);
            cm.Parameters.AddWithValue("_Fecha_Cierre", Fecha_Cierre);
            cm.Parameters.AddWithValue("_Observacion", Observacion);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.ExecuteNonQuery(); //error  revisar el procedimiento almacenado 
            cm.Parameters.Clear();
        }


        public void InsertarImpresora(int idImpresora, int Marcas_idMarcas, string Serialss, int Ubicacion_idUbicacion, string IpImpresora , string Estatus, string Modelo )
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "ImpresoraAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idImpresora", idImpresora);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.Parameters.AddWithValue("_Serialss", Serialss);
            cm.Parameters.AddWithValue("_Ubicacion_idUbicacion",Ubicacion_idUbicacion);
            cm.Parameters.AddWithValue("_IpImpresora", IpImpresora);
            cm.Parameters.AddWithValue("_Estatus", Estatus);
            cm.Parameters.AddWithValue("_Modelo", Modelo);
            cm.ExecuteNonQuery(); //error  revisar el procedimiento almacenado 
            cm.Parameters.Clear();
        }


        public void InsertarTonerEnvios(int idTonnerC, int Ubicacion_idUbicacion, int Marcas_idMarcas,  int Tonner_idTonner, int EnviosToner, int idColor_Cantidad_Color_Cantidad, DateTime Fecha_Cambio)
        {
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerEnviosAddEddit";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_idTonnerC", idTonnerC);
            cm.Parameters.AddWithValue("_Ubicacion_idUbicacion", Ubicacion_idUbicacion);
            cm.Parameters.AddWithValue("_Marcas_idMarcas", Marcas_idMarcas);
            cm.Parameters.AddWithValue("_Tonner_idTonner", Tonner_idTonner);
            cm.Parameters.AddWithValue("_EnviosToner", EnviosToner);
            cm.Parameters.AddWithValue("_idColor_Cantidad_Color_Cantidad", idColor_Cantidad_Color_Cantidad);
            cm.Parameters.AddWithValue("_Fecha", Fecha_Cambio);
            cm.ExecuteNonQuery(); //error  revisar el procedimiento almacenado 
            cm.Parameters.Clear();
        }


        //////////////////////////////////METODO SELECT FROM DATAGRID//////////////////////////////////////////////////////

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
            cm.CommandText = "TonnerSolicitudViewAlljoin";
            cm.CommandType = CommandType.StoredProcedure;
            LeerFilas = cm.ExecuteReader();
            tabla.Load(LeerFilas);
            Conexion.CerraCX();
            return tabla;
        }


        public DataTable ListarTonerSolicitud()
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

        public DataTable ListarTonerEnvios()
        {//metodo para listar los datos de la tabla Cantidad Color  en el datagrid

            DataTable tabla = new DataTable();
            cm.Connection = Conexion.AbrirCX();
            cm.CommandText = "TonnerEnviosViewAllInnerJoin";
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
