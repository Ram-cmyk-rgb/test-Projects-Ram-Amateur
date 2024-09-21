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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void buttonRequisiciones_Click(object sender, EventArgs e)
        {
            panelviscompras.Controls.Clear();
            V_Requisiciones v_Requisiciones = new V_Requisiciones();
            v_Requisiciones.TopLevel = false;
            v_Requisiciones.Dock = DockStyle.Fill;
            panelviscompras.Controls.Add(v_Requisiciones);
            v_Requisiciones.Show();
           
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            panelviscompras.Controls.Clear();
            V_Compras v_Compras = new V_Compras();
            v_Compras.TopLevel = false;
            v_Compras.Dock = DockStyle.Fill;
            panelviscompras.Controls.Add(v_Compras);
            v_Compras.Show();
        }
    }
}
