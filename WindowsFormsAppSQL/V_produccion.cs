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
    public partial class V_produccion : Form
    {
        static int huevost = 0;
        static int idalmacen= 0;
        public V_produccion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            int isla = Convert.ToInt32(textBoxIsla.Text);
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            int z= Convert.ToInt32(textBoxZ.Text);
            string codigo = Convert.ToString(isla +","+ x + "," + y + "," + z);
            string fecha = textBoxFecha.Text;
            int huevos = Convert.ToInt32(textBoxHuevos.Text);


            string sqlBuscarh = "SELECT existencias FROM productos WHERE nombredelproducto='huevost'";

            MySqlConnection sqlConnectionh = conexion.connexion();

            try
            {
                
                sqlConnectionh.Open();
                MySqlCommand comandoBuscarh = new MySqlCommand(sqlBuscarh, sqlConnectionh);
                MySqlDataReader readerh = comandoBuscarh.ExecuteReader();

                if (readerh.HasRows)
                {
                    while (readerh.Read())
                    {


                       V_produccion.huevost = Convert.ToInt32(readerh.GetValue(0));
                       
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
               
                sqlConnectionh.Close();
            }
            //

            string sqlActualizar = "UPDATE productos SET existencias=" +( V_produccion.huevost  + huevos) + " WHERE nombredelproducto='huevost';";
            MySqlConnection sqlConnectiona = conexion.connexion();
            try
            {
                sqlConnectiona.Open();
                MySqlCommand comandoActualizar = new MySqlCommand(sqlActualizar, sqlConnectiona);
                comandoActualizar.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
            finally
            {
                sqlConnectiona.Close();
            }


            string sqlGuardar = "INSERT INTO produccion (Huevos,Dia,idusuario,codigo) VALUES ('" +huevos + "','" + fecha + "','" + VariablesGlobales.globalusuario + "','" +codigo+ "');";
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

        private void labelx_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIsla_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIslas_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void V_produccion_Load(object sender, EventArgs e)
        {

        }
    }
}
