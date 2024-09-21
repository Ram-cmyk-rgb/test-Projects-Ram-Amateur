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
    public partial class Granja : Form
    {
        public Granja()
        {
            InitializeComponent();
        }

        private void buttonProduccion_Click(object sender, EventArgs e)
        {
            panelvisGranja.Controls.Clear();
            V_produccion v_produccion = new V_produccion();
            v_produccion.TopLevel = false;
            v_produccion.Dock = DockStyle.Fill;
            panelvisGranja.Controls.Add(v_produccion);
            v_produccion.Show();
            
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            panelvisGranja.Controls.Clear();
            V_gallina v_gallina = new V_gallina();
            v_gallina.TopLevel = false;
            v_gallina.Dock = DockStyle.Fill;
            panelvisGranja.Controls.Add(v_gallina);
            v_gallina.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelvisGranja.Controls.Clear();
            V_cajas v_cajas = new V_cajas();
            v_cajas.TopLevel = false;
            v_cajas.Dock = DockStyle.Fill;
            panelvisGranja.Controls.Add(v_cajas);
            v_cajas.Show();
        }
    }
}
