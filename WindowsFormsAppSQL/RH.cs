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
    public partial class RH : Form
    {
        public RH()
        {
            InitializeComponent();
        }

        private void buttonRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            panelvisRH.Controls.Clear();
            V_registrarEmpleado v_registrarEmpleado = new V_registrarEmpleado();
            v_registrarEmpleado.TopLevel = false;
            v_registrarEmpleado.Dock = DockStyle.Fill;
            panelvisRH.Controls.Add(v_registrarEmpleado);
            v_registrarEmpleado.Show();
        
        }

        private void panelvisRH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDarDeBaja_Click(object sender, EventArgs e)
        {
            panelvisRH.Controls.Clear();
            V_darDeBajaEmpleado v_darDeBajaEmpleado = new V_darDeBajaEmpleado();
            v_darDeBajaEmpleado.TopLevel = false;
            v_darDeBajaEmpleado.Dock = DockStyle.Fill;
            panelvisRH.Controls.Add(v_darDeBajaEmpleado);
            v_darDeBajaEmpleado.Show();
            
        }

        private void buttonPagoDeSueldos_Click(object sender, EventArgs e)
        {
            panelvisRH.Controls.Clear();
            V_pagoDeSueldos v_pagoDeSueldos = new V_pagoDeSueldos();
            v_pagoDeSueldos.TopLevel = false;
            v_pagoDeSueldos.Dock = DockStyle.Fill;
            panelvisRH.Controls.Add(v_pagoDeSueldos);
            v_pagoDeSueldos.Show();
        }
    }
}
