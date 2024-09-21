using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppSQL
{
    public partial class V_cajas : Form
    {
        public V_cajas()
        {
            InitializeComponent();
        }

        private void buttonRequisicion_Click(object sender, EventArgs e)
        {
            string item = comboBoxItem.SelectedItem.ToString();
            string caltidad = textBoxCantidad.Text;
            string requisicion = item + "," + caltidad;
            string sqlGuardar = "INSERT INTO compras (requisición,idusuariorequisitor) VALUES ('" + requisicion + "','" + VariablesGlobales.globalusuario + "');";
            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlCommand comandoGuardar = new MySqlCommand(sqlGuardar, sqlConnection);
                comandoGuardar.ExecuteNonQuery();
                MessageBox.Show("Requisición enviada a compras");
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

        private void V_cajas_Load(object sender, EventArgs e)
        {
            
            string sqlBuscara = "SELECT existencias FROM productos;";
            string sqlBuscarh = "SELECT existencias FROM productos WHERE nombredelproducto= 'huevost';";


            MySqlConnection sqlConnection = conexion.connexion();
            MySqlConnection sqlConnectionh = conexion.connexion();
            try
            {
                sqlConnection.Open();
                sqlConnectionh.Open();
                MySqlCommand comandoBuscara = new MySqlCommand(sqlBuscara, sqlConnection);
                MySqlCommand comandoBuscarh = new MySqlCommand(sqlBuscarh, sqlConnectionh);
                MySqlDataReader readera = comandoBuscara.ExecuteReader();
                MySqlDataReader readerh = comandoBuscarh.ExecuteReader();
                if (readera.HasRows)
                {
                    int index = 0;
                    while (readera.Read())
                    {

                        switch (index)
                        {
                            case 0:
                                textBoxCintas.Text = Convert.ToString(readera.GetValue(0)); 
                                break;
                            case 1:
                                textBoxCajasdeCarton.Text = Convert.ToString(readera.GetValue(0)); 
                                break;
                            case 2:
                                textBoxTapadeCarton.Text = Convert.ToString(readera.GetValue(0)); 
                                break;
                            case 3:
                                textBoxCajasdeHuevo.Text = Convert.ToString(readera.GetValue(0)); 
                                break;
                        }

                        index++;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

                if (readerh.HasRows)
                {
                    while (readerh.Read())
                    {

                        
                        textBoxHuevos.Text = Convert.ToString(readera.GetValue(0));

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
                sqlConnectionh.Close();
            }
        }

        private void buttonRistrar_Click(object sender, EventArgs e)
        {
            int cintas = Convert.ToInt32(textBoxCintas.Text);
            int cajasdecarton = Convert.ToInt32(textBoxCajasdeCarton.Text);
            int tapadecarton = Convert.ToInt32(textBoxTapadeCarton.Text);
            int cajasdehuevo = Convert.ToInt32(textBoxCajasdeHuevo.Text);
            int huevos = Convert.ToInt32(textBoxHuevos.Text);

            cintas = cintas-1;
            cajasdecarton = cajasdecarton-1;
            tapadecarton = tapadecarton-10;
            cajasdehuevo = cajasdehuevo+1;
            huevos = huevos - 36*10;

            textBoxCintas.Text = Convert.ToString(cintas);
            textBoxCajasdeCarton.Text = Convert.ToString(cajasdecarton);
            textBoxTapadeCarton.Text = Convert.ToString(tapadecarton);
            textBoxCajasdeHuevo.Text = Convert.ToString(cajasdehuevo);
            textBoxHuevos.Text = Convert.ToString(huevos);


            string sqlGuardar = "UPDATE productos SET existencias = CASE nombredelproducto WHEN 'cintas' THEN "+cintas+" WHEN 'cajas de carton' THEN "+cajasdecarton+"  WHEN 'tapa de carton' THEN "+tapadecarton+" WHEN 'cajas de carton de huevo' THEN "+cajasdehuevo+" WHEN 'huevost' THEN "+huevos+" ELSE existencias END;";
            
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
    }
}
