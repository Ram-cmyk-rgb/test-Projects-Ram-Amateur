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
    
    public partial class Ventas : Form
    {
        
        public Ventas()
        {
            InitializeComponent();
        }
        
        private void buttonProductos_Click(object sender, EventArgs e)
        {
            panelVisVentas.Controls.Clear();
            V_Productos v_Productos = new V_Productos();
            v_Productos.TopLevel = false;
            v_Productos.Dock = DockStyle.Fill;
            panelVisVentas.Controls.Add(v_Productos);
            v_Productos.Show();
    
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            panelVisVentas.Controls.Clear();
            V_vender v_vender = new V_vender();
            v_vender.TopLevel = false;
            v_vender.Dock = DockStyle.Fill;
            panelVisVentas.Controls.Add(v_vender);
            v_vender.Show();
            
        }
    }
}
