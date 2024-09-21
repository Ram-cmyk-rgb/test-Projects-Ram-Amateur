namespace WindowsFormsAppSQL
{
    partial class Direccion_general
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
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonRH = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonProduccion = new System.Windows.Forms.Button();
            this.panelvisdirecciongeneral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.buttonVentas);
            this.panel1.Controls.Add(this.buttonRH);
            this.panel1.Controls.Add(this.buttonCompras);
            this.panel1.Controls.Add(this.buttonProduccion);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 80);
            this.panel1.TabIndex = 0;
            // 
            // buttonVentas
            // 
            this.buttonVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVentas.Location = new System.Drawing.Point(575, 13);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(182, 41);
            this.buttonVentas.TabIndex = 8;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // buttonRH
            // 
            this.buttonRH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRH.Location = new System.Drawing.Point(387, 13);
            this.buttonRH.Name = "buttonRH";
            this.buttonRH.Size = new System.Drawing.Size(182, 41);
            this.buttonRH.TabIndex = 7;
            this.buttonRH.Text = "RH";
            this.buttonRH.UseVisualStyleBackColor = true;
            this.buttonRH.Click += new System.EventHandler(this.buttonRH_Click);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCompras.Location = new System.Drawing.Point(199, 13);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(182, 41);
            this.buttonCompras.TabIndex = 6;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonProduccion
            // 
            this.buttonProduccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProduccion.Location = new System.Drawing.Point(11, 13);
            this.buttonProduccion.Name = "buttonProduccion";
            this.buttonProduccion.Size = new System.Drawing.Size(182, 41);
            this.buttonProduccion.TabIndex = 5;
            this.buttonProduccion.Text = "Producción";
            this.buttonProduccion.UseVisualStyleBackColor = true;
            this.buttonProduccion.Click += new System.EventHandler(this.buttonProduccion_Click);
            // 
            // panelvisdirecciongeneral
            // 
            this.panelvisdirecciongeneral.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelvisdirecciongeneral.Location = new System.Drawing.Point(-2, 78);
            this.panelvisdirecciongeneral.Name = "panelvisdirecciongeneral";
            this.panelvisdirecciongeneral.Size = new System.Drawing.Size(880, 600);
            this.panelvisdirecciongeneral.TabIndex = 1;
            this.panelvisdirecciongeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvisdirecciongeneral_Paint);
            // 
            // Direccion_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(879, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelvisdirecciongeneral);
            this.Name = "Direccion_general";
            this.Text = "Direccion_general";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelvisdirecciongeneral;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonProduccion;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonRH;
    }
}