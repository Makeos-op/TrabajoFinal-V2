namespace Presentacion
{
    partial class FormReporteArrendador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Modelo = new System.Windows.Forms.Label();
            this.btn_Reporte3 = new System.Windows.Forms.Button();
            this.btn_Reporte4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(177, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 34);
            this.label4.TabIndex = 41;
            this.label4.Text = "REPORTES ARRENDADOR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 52;
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(22, 122);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(53, 16);
            this.Modelo.TabIndex = 51;
            this.Modelo.Text = "Modelo";
            // 
            // btn_Reporte3
            // 
            this.btn_Reporte3.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Reporte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Reporte3.Location = new System.Drawing.Point(52, 176);
            this.btn_Reporte3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reporte3.Name = "btn_Reporte3";
            this.btn_Reporte3.Size = new System.Drawing.Size(165, 49);
            this.btn_Reporte3.TabIndex = 49;
            this.btn_Reporte3.Text = "Refrescar";
            this.btn_Reporte3.UseVisualStyleBackColor = false;
            // 
            // btn_Reporte4
            // 
            this.btn_Reporte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte4.Location = new System.Drawing.Point(421, 182);
            this.btn_Reporte4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reporte4.Name = "btn_Reporte4";
            this.btn_Reporte4.Size = new System.Drawing.Size(148, 43);
            this.btn_Reporte4.TabIndex = 48;
            this.btn_Reporte4.Text = "Salir";
            this.btn_Reporte4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "label1";
            // 
            // FormReporteArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 256);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.btn_Reporte3);
            this.Controls.Add(this.btn_Reporte4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FormReporteArrendador";
            this.Text = "FormReporteArrendador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Button btn_Reporte3;
        private System.Windows.Forms.Button btn_Reporte4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}