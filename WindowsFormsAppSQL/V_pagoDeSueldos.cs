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
    public partial class V_pagoDeSueldos : Form
    {
        public V_pagoDeSueldos()
        {
            InitializeComponent();
        }

        private void buttonBuscarTrabajadores_Click(object sender, EventArgs e)
        {

            string sqlBuscar = "SELECT * from empleados";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
            
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlBuscar, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewPagos.DataSource = dataTable;
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

        private void buttonPagados_Click(object sender, EventArgs e)
        {
            dataGridViewPagos.DataSource = null;
        }
    }
}
