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
    public partial class V_Compras : Form
    {
        public V_Compras()
        {
            InitializeComponent();
        }

        private void V_Compras_Load(object sender, EventArgs e)
        {
            string sqlBuscar = "SELECT * from compras WHERE compracompletada=1";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sqlBuscar, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter1.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["idCompras"].ReadOnly = true;
                dataGridView1.Columns["Requisición"].ReadOnly = true;
                dataGridView1.Columns["Costo"].ReadOnly = true;
                dataGridView1.Columns["Nombre del proveedor"].ReadOnly = true;
                dataGridView1.Columns["idUsuarioCompras"].ReadOnly = true;
                dataGridView1.Columns["idUsuariorequisitor"].ReadOnly = true;
                dataGridView1.Columns["Departamento"].ReadOnly = true;
                dataGridView1.Columns["Compracompletada"].ReadOnly = true;





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

        }
    }
}
