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
    public partial class V_registrarEmpleado : Form
    {
        public V_registrarEmpleado()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string departamento = comboBoxDepartamento.Text;
            string fechadeingreso = textBoxFechadeingreso.Text;
            string sueldo = textBoxSueldo.Text;
            string usuario= textBoxUsuario.Text;
            string ID = textBoxID.Text;

            string sqlGuardar = "INSERT INTO empleados (Nombre,Direccion,Departamento,Fechaingreso,Sueldo,Login_usuario) VALUES ('" + nombre+ "','" + direccion + "','" + departamento + "','" + fechadeingreso + "','" + sueldo + "','" + usuario + "');";
            string sqlBuscar = "SELECT Idempleados FROM empleados WHERE Login_usuario LIKE '" + usuario + "'";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MySqlCommand comandousuarioid = new MySqlCommand(sqlBuscar, sqlConnection);
                MySqlDataReader reader=comandousuarioid.ExecuteReader();
                MessageBox.Show("Empleado Guardado ID:"+ reader.GetValue(0));
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

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
