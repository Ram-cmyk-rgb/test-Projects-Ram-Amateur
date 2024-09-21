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
    public partial class V_darDeBajaEmpleado : Form
    {
        public V_darDeBajaEmpleado()
        {
            InitializeComponent();
        }

        private void buttonBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string sqlBuscar = "SELECT Idempleados,Direccion, departamento,Fechaingreso, sueldo, Login_usuario FROM empleados WHERE nombre LIKE '" + nombre+ "'";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoBuscar = new MySqlCommand(sqlBuscar, sqlConnection);
                MySqlDataReader reader = comandoBuscar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        textBoxId.Text = Convert.ToString(reader.GetValue(0));
                        textBoxDireccion.Text = Convert.ToString(reader.GetValue(1));
                        textBoxDepartamento.Text = Convert.ToString(reader.GetValue(2));
                        textBoxFechaIngreso.Text = Convert.ToString(reader.GetValue(3));
                        textBoxSueldo.Text = Convert.ToString(reader.GetValue(4));
                        textBoxUsuario.Text = Convert.ToString(reader.GetValue(5));
                        

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

        private void buttonBuscarPorUsuario_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string sqlBuscar = "SELECT Idempleados,Direccion, departamento,Fechaingreso, sueldo, Nombre FROM empleados WHERE Login_usuario LIKE '" + usuario + "'";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoBuscar = new MySqlCommand(sqlBuscar, sqlConnection);
                MySqlDataReader reader = comandoBuscar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBoxId.Text = Convert.ToString(reader.GetValue(0));
                        textBoxDireccion.Text = Convert.ToString(reader.GetValue(1));
                        textBoxDepartamento.Text = Convert.ToString(reader.GetValue(2));
                        textBoxFechaIngreso.Text = Convert.ToString(reader.GetValue(3));
                        textBoxSueldo.Text = Convert.ToString(reader.GetValue(4));
                        textBoxNombre.Text = Convert.ToString(reader.GetValue(5));


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

        private void buttonDarDeBaja_Click(object sender, EventArgs e)
        {
            string iD= textBoxId.Text;
            string nombre = textBoxNombre.Text;
            string Direccion = textBoxDireccion.Text;
            string Departamento = textBoxDepartamento.Text;
            double sueldo = Convert.ToDouble(textBoxSueldo.Text);
            string fechaIngreso = textBoxFechaIngreso.Text;
            string fechaTermino = textBoxFechaDeTermino.Text;
            string login = textBoxUsuario.Text;

            string sqlGuardar = "INSERT INTO Bajas (idempleados,Nombre,Direccion,Departamento,FechaIngreso,Sueldo,Login_usuario,Fechatermino) VALUES ('" + iD + "','" + nombre + "','" + Direccion + "','" + Departamento + "','" + fechaIngreso + "','" + sueldo + "','" + login + "','" + fechaTermino+"');";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
               

               string Id = textBoxId.Text;


                string sqlEliminar = "DELETE FROM empleados WHERE idempleados='" + Id + "';";
              
               
                  
                    MySqlCommand comandoEliminar = new MySqlCommand(sqlEliminar, sqlConnection);
                    comandoEliminar.ExecuteNonQuery();
                    MessageBox.Show("Empleado eliminado");
              
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
