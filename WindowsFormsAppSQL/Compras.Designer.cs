namespace WindowsFormsAppSQL
{
    partial class Compras
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
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonRequisiciones = new System.Windows.Forms.Button();
            this.panelviscompras = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.buttonEstadisticas);
            this.panel1.Controls.Add(this.buttonCompras);
            this.panel1.Controls.Add(this.buttonRequisiciones);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 80);
            this.panel1.TabIndex = 0;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEstadisticas.Location = new System.Drawing.Point(319, 12);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(169, 41);
            this.buttonEstadisticas.TabIndex = 3;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // buttonCompras
            // 
            this.buttonCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCompras.Location = new System.Drawing.Point(180, 12);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(133, 41);
            this.buttonCompras.TabIndex = 3;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonRequisiciones
            // 
            this.buttonRequisiciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequisiciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRequisiciones.Location = new System.Drawing.Point(11, 12);
            this.buttonRequisiciones.Name = "buttonRequisiciones";
            this.buttonRequisiciones.Size = new System.Drawing.Size(163, 41);
            this.buttonRequisiciones.TabIndex = 3;
            this.buttonRequisiciones.Text = "Requisiciones";
            this.buttonRequisiciones.UseVisualStyleBackColor = true;
            this.buttonRequisiciones.Click += new System.EventHandler(this.buttonRequisiciones_Click);
            // 
            // panelviscompras
            // 
            this.panelviscompras.BackColor = System.Drawing.Color.OldLace;
            this.panelviscompras.Location = new System.Drawing.Point(1, 80);
            this.panelviscompras.Name = "panelviscompras";
            this.panelviscompras.Size = new System.Drawing.Size(860, 480);
            this.panelviscompras.TabIndex = 1;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.panelviscompras);
            this.Controls.Add(this.panel1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonRequisiciones;
        private System.Windows.Forms.Panel panelviscompras;
    }
}