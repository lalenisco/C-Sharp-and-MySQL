using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Tienda
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "tienda";
            string usuario = "root";
            string password = "Admin123";
            string port = "3306"; 

            string cadenaConexion = " Database =" + bd + "; Data Source=" + servidor + "; Port ="+ port + "; User id =" + usuario +
                "; Password=" + password+ "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
