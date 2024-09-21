namespace WindowsFormsAppSQL
{
    partial class Ventas
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
            this.panelOpVentas = new System.Windows.Forms.Panel();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.panelVisVentas = new System.Windows.Forms.Panel();
            this.panelOpVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpVentas
            // 
            this.panelOpVentas.BackColor = System.Drawing.Color.Tan;
            this.panelOpVentas.Controls.Add(this.buttonEstadisticas);
            this.panelOpVentas.Controls.Add(this.buttonVender);
            this.panelOpVentas.Controls.Add(this.buttonProductos);
            this.panelOpVentas.ForeColor = System.Drawing.Color.SandyBrown;
            this.panelOpVentas.Location = new System.Drawing.Point(1, 0);
            this.panelOpVentas.Name = "panelOpVentas";
            this.panelOpVentas.Size = new System.Drawing.Size(860, 80);
            this.panelOpVentas.TabIndex = 0;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEstadisticas.Location = new System.Drawing.Point(300, 12);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(175, 41);
            this.buttonEstadisticas.TabIndex = 4;
            this.buttonEstadisticas.Text = "Estadísticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // buttonVender
            // 
            this.buttonVender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVender.Location = new System.Drawing.Point(150, 12);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(144, 41);
            this.buttonVender.TabIndex = 3;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProductos.Location = new System.Drawing.Point(11, 12);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(133, 41);
            this.buttonProductos.TabIndex = 2;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // panelVisVentas
            // 
            this.panelVisVentas.BackColor = System.Drawing.Color.OldLace;
            this.panelVisVentas.Location = new System.Drawing.Point(1, 81);
            this.panelVisVentas.Name = "panelVisVentas";
            this.panelVisVentas.Size = new System.Drawing.Size(860, 480);
            this.panelVisVentas.TabIndex = 1;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.panelVisVentas);
            this.Controls.Add(this.panelOpVentas);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panelOpVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpVentas;
        private System.Windows.Forms.Panel panelVisVentas;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Button buttonEstadisticas;
    }
}