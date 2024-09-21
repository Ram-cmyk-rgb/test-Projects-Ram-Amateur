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
    public partial class V_gallina : Form
    {
        public V_gallina()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            int isla = Convert.ToInt32(textBoxIsla.Text);
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            int z = Convert.ToInt32(textBoxZ.Text);
            string codigo = Convert.ToString(isla + "," + x + "," + y + "," + z);
            string fecha = textBoxFecha.Text;
            string huevo = textBoxhuevo.Text;


          



            string sqlGuardar = "INSERT INTO gallinas (codigo,fechadenacida,idusuario,huevo) VALUES ('" + codigo + "','" + fecha + "','" + VariablesGlobales.globalusuario + "','" + huevo+"');";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");
                buttonBuscar_Click(this, EventArgs.Empty);
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int isla = Convert.ToInt32(textBoxIsla.Text);
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            int z = Convert.ToInt32(textBoxZ.Text);
            string codigo = Convert.ToString(isla + "," + x + "," + y + "," + z);
            string fecha = textBoxFecha.Text;
            string huevo = textBoxhuevo.Text;

            string sqlBuscar = "SELECT idgallinas,estado FROM gallinas WHERE codigo = '" + codigo + "' AND fechadenacida='"+fecha + "' AND huevo='"+huevo + "'";

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
                        int estado = Convert.ToInt32(reader.GetValue(1));
                        if (estado == 1)
                        {
                            textBoxEstado.Text = "Activo";
                        }
                        else
                        {
                            textBoxEstado.Text = "No activo";
                        }
                        

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

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;


            string sqlGuardar = "DELETE FROM gallinas WHERE idGallinas='" + id+ "';";
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
