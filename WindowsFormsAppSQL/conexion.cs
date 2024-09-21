using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQL
{

    internal class conexion
    {
        
        
        
        public static MySqlConnection connexion()
        {
            string servidor = "localhost";
            string puerto = "3307";
            string baseDatos = "tienda";
            string contrasena = "Ramses01!";
            string usuario = "root";

            string cadenaConexion = "Database=" + baseDatos + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + contrasena;
            //string conexion = "Database=" + baseDatos + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + contrasena;
            MySqlConnection mySqlConnection = null;

            try
            {
                mySqlConnection = new MySqlConnection(cadenaConexion);
               // mySqlConnection.Open();
                return mySqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }


        }


    }
}
