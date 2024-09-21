namespace WindowsFormsAppSQL
{
    partial class V_pagoDeSueldos
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
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            this.buttonBuscarTrabajadores = new System.Windows.Forms.Button();
            this.buttonPagados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPagos.Location = new System.Drawing.Point(48, 57);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.Size = new System.Drawing.Size(682, 300);
            this.dataGridViewPagos.TabIndex = 1;
            // 
            // buttonBuscarTrabajadores
            // 
            this.buttonBuscarTrabajadores.BackColor = System.Drawing.Color.Sienna;
            this.buttonBuscarTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarTrabajadores.Location = new System.Drawing.Point(166, 372);
            this.buttonBuscarTrabajadores.Name = "buttonBuscarTrabajadores";
            this.buttonBuscarTrabajadores.Size = new System.Drawing.Size(158, 66);
            this.buttonBuscarTrabajadores.TabIndex = 2;
            this.buttonBuscarTrabajadores.Text = "Buscar trabajadores";
            this.buttonBuscarTrabajadores.UseVisualStyleBackColor = false;
            this.buttonBuscarTrabajadores.Click += new System.EventHandler(this.buttonBuscarTrabajadores_Click);
            // 
            // buttonPagados
            // 
            this.buttonPagados.BackColor = System.Drawing.Color.Maroon;
            this.buttonPagados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagados.Location = new System.Drawing.Point(466, 372);
            this.buttonPagados.Name = "buttonPagados";
            this.buttonPagados.Size = new System.Drawing.Size(158, 66);
            this.buttonPagados.TabIndex = 3;
            this.buttonPagados.Text = "Pagados";
            this.buttonPagados.UseVisualStyleBackColor = false;
            this.buttonPagados.Click += new System.EventHandler(this.buttonPagados_Click);
            // 
            // V_pagoDeSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPagados);
            this.Controls.Add(this.buttonBuscarTrabajadores);
            this.Controls.Add(this.dataGridViewPagos);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_pagoDeSueldos";
            this.Text = "V_pagoDeSueldos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPagos;
        private System.Windows.Forms.Button buttonBuscarTrabajadores;
        private System.Windows.Forms.Button buttonPagados;
    }
}