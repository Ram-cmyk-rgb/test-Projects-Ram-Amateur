using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQL
{
   
    public partial class FormLogIn : Form
    {
        
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            VariablesGlobales.globalusuario = usuario;
            string contrasena= textBoxContrasena.Text;
           
            string querysqlcontrasena= "SELECT contrasena FROM login WHERE usuario LIKE '" + usuario + "' LIMIT 1";
            ;
           MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoIngresar = new MySqlCommand(querysqlcontrasena, sqlConnection);
                MySqlDataReader reader = comandoIngresar.ExecuteReader();
              
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String sqlcontrasena = reader.GetString(0);
                     
                    }
                    reader.Close();
                    string sqlGetDepartamento = "SELECT e.Departamento FROM empleados e JOIN login l ON l.usuario= e.Login_usuario  WHERE l.usuario ='" + usuario+"';";
                    MySqlCommand comadoDepartamento = new MySqlCommand(sqlGetDepartamento, sqlConnection);
                    reader = comadoDepartamento.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string sqlDepartamento = reader.GetString(0);
                  
                        }
                        if (reader.GetString(0) == "Dirección general")
                        {

                            Direccion_general direcciongeneral = new Direccion_general();
                            direcciongeneral.Show();

                        }
                        else if (reader.GetString(0) == "Ventas")
                        {
                            Ventas ventas = new Ventas();
                            ventas.Show();
                        }
                        else if (reader.GetString(0) == "Compras")
                        {
                            Compras compras = new Compras();
                            compras.Show();
                        }
                        else if (reader.GetString(0) == "RH")
                        {
                            RH RH = new RH();
                            RH.Show();
                        }
                        else if (reader.GetString(0) == "Producción")
                        {
                            Granja granja = new Granja();
                            granja.Show();
                        }

                        else
                        {
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el departamento");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                } 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
            finally
            {
                sqlConnection.Close();
            }
        }
            
    }
}
