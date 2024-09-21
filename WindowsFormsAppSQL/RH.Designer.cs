namespace WindowsFormsAppSQL
{
    partial class RH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonPagoDeSueldos = new System.Windows.Forms.Button();
            this.buttonDarDeBaja = new System.Windows.Forms.Button();
            this.buttonRegistrarEmpleado = new System.Windows.Forms.Button();
            this.panelvisRH = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.buttonEstadisticas);
            this.panel1.Controls.Add(this.buttonPagoDeSueldos);
            this.panel1.Controls.Add(this.buttonDarDeBaja);
            this.panel1.Controls.Add(this.buttonRegistrarEmpleado);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 80);
            this.panel1.TabIndex = 0;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEstadisticas.Location = new System.Drawing.Point(498, 11);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(140, 61);
            this.buttonEstadisticas.TabIndex = 6;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // buttonPagoDeSueldos
            // 
            this.buttonPagoDeSueldos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagoDeSueldos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPagoDeSueldos.Location = new System.Drawing.Point(359, 11);
            this.buttonPagoDeSueldos.Name = "buttonPagoDeSueldos";
            this.buttonPagoDeSueldos.Size = new System.Drawing.Size(133, 61);
            this.buttonPagoDeSueldos.TabIndex = 5;
            this.buttonPagoDeSueldos.Text = "Pago de sueldos";
            this.buttonPagoDeSueldos.UseVisualStyleBackColor = true;
            this.buttonPagoDeSueldos.Click += new System.EventHandler(this.buttonPagoDeSueldos_Click);
            // 
            // buttonDarDeBaja
            // 
            this.buttonDarDeBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDarDeBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDarDeBaja.Location = new System.Drawing.Point(188, 11);
            this.buttonDarDeBaja.Name = "buttonDarDeBaja";
            this.buttonDarDeBaja.Size = new System.Drawing.Size(165, 61);
            this.buttonDarDeBaja.TabIndex = 4;
            this.buttonDarDeBaja.Text = "Dar de baja empleado";
            this.buttonDarDeBaja.UseVisualStyleBackColor = true;
            this.buttonDarDeBaja.Click += new System.EventHandler(this.buttonDarDeBaja_Click);
            // 
            // buttonRegistrarEmpleado
            // 
            this.buttonRegistrarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegistrarEmpleado.Location = new System.Drawing.Point(10, 11);
            this.buttonRegistrarEmpleado.Name = "buttonRegistrarEmpleado";
            this.buttonRegistrarEmpleado.Size = new System.Drawing.Size(172, 61);
            this.buttonRegistrarEmpleado.TabIndex = 3;
            this.buttonRegistrarEmpleado.Text = "Registrar empleado";
            this.buttonRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.buttonRegistrarEmpleado.Click += new System.EventHandler(this.buttonRegistrarEmpleado_Click);
            // 
            // panelvisRH
            // 
            this.panelvisRH.BackColor = System.Drawing.Color.OldLace;
            this.panelvisRH.Location = new System.Drawing.Point(1, 79);
            this.panelvisRH.Name = "panelvisRH";
            this.panelvisRH.Size = new System.Drawing.Size(860, 480);
            this.panelvisRH.TabIndex = 1;
            this.panelvisRH.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvisRH_Paint);
            // 
            // RH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.panelvisRH);
            this.Controls.Add(this.panel1);
            this.Name = "RH";
            this.Text = "RH";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelvisRH;
        private System.Windows.Forms.Button buttonDarDeBaja;
        private System.Windows.Forms.Button buttonRegistrarEmpleado;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Button buttonPagoDeSueldos;
    }
}