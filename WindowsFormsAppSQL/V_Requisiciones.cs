using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQL
{
    public partial class V_Requisiciones : Form
    {
        MySqlDataAdapter dataAdapter = null;
        static int Pactual = 0;
        public V_Requisiciones()
        {
            InitializeComponent();
           
        }

        private void V_Requisiciones_Load(object sender, EventArgs e)
        {
            string sqlBuscar = "SELECT * from compras WHERE compracompletada=0";

            MySqlConnection sqlConnection = conexion.connexion();
            try
            {
                sqlConnection.Open();
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sqlBuscar, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter1.Fill(dataTable);
               
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["Requisición"].ReadOnly = true;
                dataGridView1.Columns["departamento"].ReadOnly = true;

               DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
               {
                   Name = "COmpracompletada",
                   HeaderText = "Compra completada",
                   DataPropertyName = "Compracompletada", // Nombre de la columna en la base de datos
                   TrueValue = 1,
                   FalseValue = 0
               };
               

                //Agrega la columna CheckBox al DataGridView
                if (dataGridView1.Columns["Compracompletada"] != null)
                {
                   dataGridView1.Columns.Remove("Compracompletada");
                }
                   dataGridView1.Columns.Add(checkBoxColumn);
               
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
            

            MySqlConnection sqlConnection = conexion.connexion();
                     

            try
            {
                DataTable dataTable2 = ((DataTable)dataGridView1.DataSource).GetChanges();
                


                if (dataTable2 != null)

                {

                    foreach (DataRow row in dataTable2.Rows)
                    {
                        if (row["CompraCompletada"] == DBNull.Value || row["CompraCompletada"] == null)
                        {
                            row["CompraCompletada"] = 0; 
                        }
                    }
                    foreach (DataRow row in dataTable2.Rows)
                    {
                        if (Convert.ToInt32(row["CompraCompletada"]) == 1)
                        {
                            string ReqItem = Convert.ToString(row["Requisición"]);
                            string[] partes = Convert.ToString(row["Requisición"]).Split(',');

                            if (partes.Length == 2)
                            {
                                string reqItem = partes[0];
                                int reqCant;
                                if (int.TryParse(partes[1], out reqCant))
                                {
                                    Console.WriteLine("Primer valor: " + reqItem);
                                    Console.WriteLine("Segundo valor: " + reqCant);
                                    string sqlBuscarh = "SELECT existencias FROM productos WHERE nombredelproducto= '"+reqItem+"';";
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
                                                V_Requisiciones.Pactual= Convert.ToInt32(readerh.GetValue(0));
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
                                    string sqlActualizar = "UPDATE productos SET existencias =" + (reqCant+V_Requisiciones.Pactual )+ " WHERE nombredelproducto='" + reqItem + "';";
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
                                }
                                else
                                {
                                    Console.WriteLine("El segundo valor no es un número entero válido.");
                                }

                        }   }
                    }
                    using (MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM compras", sqlConnection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter2);

                        adapter2.UpdateCommand = commandBuilder.GetUpdateCommand();
                        // adapter2.InsertCommand = commandBuilder.GetInsertCommand();
                        //adapter2.DeleteCommand = commandBuilder.GetDeleteCommand();

                        adapter2.Update(dataTable2);
                        dataTable2.AcceptChanges(); 
                    }
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
