﻿namespace WindowsFormsAppSQL
{
    partial class Granja
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonProduccion = new System.Windows.Forms.Button();
            this.panelvisGranja = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonCompras);
            this.panel1.Controls.Add(this.buttonProduccion);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 80);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(337, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cajas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(476, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Estadisticas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCompras
            // 
            this.buttonCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCompras.Location = new System.Drawing.Point(198, 11);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(133, 41);
            this.buttonCompras.TabIndex = 5;
            this.buttonCompras.Text = "Gallinas";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonProduccion
            // 
            this.buttonProduccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProduccion.Location = new System.Drawing.Point(10, 11);
            this.buttonProduccion.Name = "buttonProduccion";
            this.buttonProduccion.Size = new System.Drawing.Size(182, 41);
            this.buttonProduccion.TabIndex = 4;
            this.buttonProduccion.Text = "Produccion";
            this.buttonProduccion.UseVisualStyleBackColor = true;
            this.buttonProduccion.Click += new System.EventHandler(this.buttonProduccion_Click);
            // 
            // panelvisGranja
            // 
            this.panelvisGranja.Location = new System.Drawing.Point(1, 80);
            this.panelvisGranja.Name = "panelvisGranja";
            this.panelvisGranja.Size = new System.Drawing.Size(860, 480);
            this.panelvisGranja.TabIndex = 1;
            // 
            // Granja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.panelvisGranja);
            this.Controls.Add(this.panel1);
            this.Name = "Granja";
            this.Text = "Granja";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonProduccion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelvisGranja;
    }
}