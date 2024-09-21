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
    public partial class Direccion_general : Form
    {
        public Direccion_general()
        {
            InitializeComponent();
        }

        private void panelvisdirecciongeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProduccion_Click(object sender, EventArgs e)
        {
            panelvisdirecciongeneral.Controls.Clear();

            Granja granja = new Granja();

            granja.TopLevel = false;
            granja.Dock = DockStyle.Fill;
            panelvisdirecciongeneral.Controls.Add(granja);
            granja.Show();
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            panelvisdirecciongeneral.Controls.Clear();

            Compras compras = new Compras();

            compras.TopLevel = false;
            compras.Dock = DockStyle.Fill;
            panelvisdirecciongeneral.Controls.Add(compras);
            compras.Show();
        }

        private void buttonRH_Click(object sender, EventArgs e)
        {
            panelvisdirecciongeneral.Controls.Clear();

            RH RH = new RH();

            RH.TopLevel = false;
            RH.Dock = DockStyle.Fill;
            panelvisdirecciongeneral.Controls.Add(RH);
            RH.Show();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            panelvisdirecciongeneral.Controls.Clear();

            Ventas ventas = new Ventas();

            ventas.TopLevel = false;
            ventas.Dock = DockStyle.Fill;
            panelvisdirecciongeneral.Controls.Add(ventas);
            ventas.Show();
        }
    }
}
