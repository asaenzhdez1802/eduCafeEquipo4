using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    internal class Conexion
    {
        //Cadena de conexion a la base de datos con los 5 parametros
        private readonly string Cadena;

        //constructor
        public Conexion()
        {
            Cadena = "Server=127.0.0.1; Database=edu_cafe; Uid=root; Pwd=; Port=3306;";
        }

        //metodo para conectar a la base de datos
        public MySqlConnection GetConexion()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Cadena);
                con.Open();
                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectarse:\n" + ex.Message);
                return null;
            }
        }
    }
}
