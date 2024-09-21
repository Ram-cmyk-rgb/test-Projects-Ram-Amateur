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
    public partial class V_Productos : Form
    {
        public V_Productos()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string codigo = textBoxCodigo.Text;
            string nombre = textBoxNombreProducto.Text;
            string descripcion = textBoxDescripcion.Text;
            double precio = Convert.ToDouble(textBoxPrecioPublico.Text);
            int existencias = Convert.ToInt32(textBoxExistencias.Text);

            string sqlGuardar = "INSERT INTO productos (codigo,nombredelproducto,descripcion,preciopublico,existencias,idmodificacion_usuario) VALUES ('" + codigo + "','" + nombre + "','" + descripcion + "','" + precio + "','" + existencias + "','" + VariablesGlobales.globalusuario + "');";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");
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

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string codigo = textBoxCodigo.Text;
            string nombre = textBoxNombreProducto.Text;
            string descripcion = textBoxDescripcion.Text;
            double precio = Convert.ToDouble(textBoxPrecioPublico.Text);
            int existencias = Convert.ToInt32(textBoxExistencias.Text);

            string sqlGuardar = "UPDATE productos SET codigo='" + codigo + "',nombredelproducto='" + nombre + "',descripcion='" + descripcion + "',preciopublico='" + precio + "',existencias='" + existencias + "' WHERE Idproductos='" + id + "';";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxCodigo.Text = "";
            textBoxNombreProducto.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecioPublico.Text = "";
            textBoxExistencias.Text = "";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string codigo = textBoxCodigo.Text;
            string sqlBuscar = "SELECT Idproductos,codigo,nombredelproducto,descripcion,preciopublico,existencias,idmodificacion_usuario FROM productos WHERE codigo LIKE '" +Convert.ToInt32(codigo) + "'";

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
                      //var a= reader.Get
                        textBoxId.Text = Convert.ToString(reader.GetValue(0));
                        textBoxCodigo.Text = Convert.ToString(reader.GetValue(1));
                        textBoxNombreProducto.Text = Convert.ToString( reader.GetValue(2));
                        textBoxDescripcion.Text = Convert.ToString(reader.GetValue(5));
                        textBoxPrecioPublico.Text = Convert.ToString(reader.GetValue(3));
                        textBoxExistencias.Text = Convert.ToString(reader.GetValue(4));
                        
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string codigo = textBoxCodigo.Text;


            string sqlGuardar = "DELETE FROM productos WHERE codigo='" + codigo + "';";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
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
