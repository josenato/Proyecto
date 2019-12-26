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


namespace SistemaInventario
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistemas2019; Uid=root; Pwd=;");
        //En donde server="nombre del servidor", user id="root" y database="Nombre de la BD a la que nos conectaremos.

        public Login()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            con.Open(); //Abrimos la conexion creada.
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE Nombre='" + txtUsuario.Text + "'AND Contraseña='" + txtPass.Text + "' ", con); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                this.Hide();
                Principal ss = new Principal();
                ss.Show();
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
            }
            else //Si no lo es mostrara este mensaje.
                MessageBox.Show("Error - Ingrese sus datos correctamente");
            con.Close(); //Cerramos la conexion.   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
