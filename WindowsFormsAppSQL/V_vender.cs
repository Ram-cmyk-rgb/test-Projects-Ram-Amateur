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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppSQL
{
   
    public partial class V_vender : Form
    {
       
        public V_vender()
        {
            InitializeComponent();
        }

        private void V_vender_Load(object sender, EventArgs e)
        {

            string sqlBuscarProducto = "SELECT nombredelproducto,preciopublico FROM productos";
            string sqlBuscarCliente = "SELECT nombre FROM clientes";
            MySqlConnection sqlConnection = conexion.connexion();
            MySqlConnection sqlConnectionc = conexion.connexion();
            try
            {
                sqlConnection.Open();
                sqlConnectionc.Open();
                MySqlCommand comandoBuscarP = new MySqlCommand(sqlBuscarProducto, sqlConnection);
                MySqlDataReader readerProducto = comandoBuscarP.ExecuteReader();
                MySqlCommand comandoBuscarC = new MySqlCommand(sqlBuscarCliente, sqlConnectionc);
                MySqlDataReader readerCliente = comandoBuscarC.ExecuteReader();
                if (readerProducto.HasRows)
                {
                    while (readerProducto.Read())
                    {

                        comboBoxProducto.Items.Add(readerProducto.GetString(0));
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
                if (readerCliente.HasRows)
                {
                    while (readerCliente.Read())
                    {

                        comboBoxCliente.Items.Add(readerCliente.GetString(0));
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
                sqlConnectionc.Close();
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlBuscarDireccion = "SELECT direccion FROM clientes WHERE nombre='" + comboBoxCliente.SelectedItem + "'";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoBuscar = new MySqlCommand(sqlBuscarDireccion, sqlConnection);
                MySqlDataReader readerDireccion = comandoBuscar.ExecuteReader();

                if (readerDireccion.HasRows)
                {
                    while (readerDireccion.Read())
                    {
                        textBox2.Text = readerDireccion.GetString(0);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarNuevoCliente_Click(object sender, EventArgs e)
        {

            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;

            string sqlGuardar = "INSERT INTO clientes (nombre,direccion) VALUES ('" + nombre + "','" + direccion + "');";
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

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlBuscarPrecio = "SELECT preciopublico, existencias FROM productos WHERE nombredelproducto='" + comboBoxProducto.SelectedItem + "'";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoBuscarP = new MySqlCommand(sqlBuscarPrecio, sqlConnection);
                MySqlDataReader readerProducto = comandoBuscarP.ExecuteReader();

                if (readerProducto.HasRows)
                {
                    while (readerProducto.Read())
                    {

                        textBoxPrecio.Text=Convert.ToString(readerProducto.GetDouble(0));
                        textBoxStock.Text = Convert.ToString(readerProducto.GetDouble(1));
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

                //textBoxPrecio.Text=com

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

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBoxPrecioTotal.Text = Convert.ToString(Convert.ToDouble(textBoxCantidad.Text) * Convert.ToDouble(textBoxPrecio.Text));
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            string sqlBuscarProductoid = "SELECT idproductos, existencias FROM productos WHERE nombredelproducto='"+comboBoxProducto.SelectedItem+"'";
            string sqlBuscarClienteid = "SELECT idclientes FROM clientes WHERE nombre='"+ comboBoxCliente.SelectedItem + "'";
            MySqlConnection sqlConnection = conexion.connexion();
            MySqlConnection sqlConnectionc = conexion.connexion();
            try
            {
                sqlConnection.Open();
                sqlConnectionc.Open();
                MySqlCommand comandoBuscarPid = new MySqlCommand(sqlBuscarProductoid, sqlConnection);
                MySqlDataReader readerProductoid = comandoBuscarPid.ExecuteReader();
                MySqlCommand comandoBuscarCid = new MySqlCommand(sqlBuscarClienteid, sqlConnectionc);
                MySqlDataReader readerClienteid = comandoBuscarCid.ExecuteReader();
                if (readerProductoid.HasRows)
                {
                    while (readerProductoid.Read())
                    {

                        VariablesGlobales.globalproductoid = readerProductoid.GetInt32(0);

                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
                if (readerClienteid.HasRows)
                {
                    while (readerClienteid.Read())
                    {

                        VariablesGlobales.globalclienteid=readerClienteid.GetInt32(0);
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

                string sqlActualizar = "UPDATE productos SET existencias =" + (Convert.ToInt32(textBoxStock.Text)- Convert.ToInt32(textBoxCantidad.Text)) + " WHERE idproductos=" + VariablesGlobales.globalproductoid + ";";
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
               
                string sqlVenta = "INSERT INTO clientes_has_productos (clientes_idclientes,productos_idproductos,cantidad) VALUES ("+VariablesGlobales.globalclienteid+","+VariablesGlobales.globalproductoid+","+textBoxCantidad.Text+");";
                MySqlConnection sqlConnectionV = conexion.connexion();
                try
                {
                    sqlConnectionV.Open();
                    MySqlCommand comandoGuardar = new MySqlCommand(sqlVenta, sqlConnectionV);
                    comandoGuardar.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");

                }
                finally
                {
                    sqlConnectionV.Close();
                    VariablesGlobales.globalclienteid =0 ;
                    VariablesGlobales.globalproductoid = 0;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
            finally
            {
                sqlConnection.Close();
                sqlConnectionc.Close();
            }
        }
    }
}
