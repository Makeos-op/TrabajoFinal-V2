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
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dataGridViewBrete = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrete)).BeginInit();
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
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrescar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Refrescar.Location = new System.Drawing.Point(476, 466);
            this.btn_Refrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(165, 49);
            this.btn_Refrescar.TabIndex = 37;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(280, 470);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 43);
            this.btn_Salir.TabIndex = 36;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBrete
            // 
            this.dataGridViewBrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrete.Location = new System.Drawing.Point(53, 140);
            this.dataGridViewBrete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBrete.Name = "dataGridViewBrete";
            this.dataGridViewBrete.RowHeadersWidth = 51;
            this.dataGridViewBrete.RowTemplate.Height = 24;
            this.dataGridViewBrete.Size = new System.Drawing.Size(588, 310);
            this.dataGridViewBrete.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(211, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 34);
            this.label4.TabIndex = 41;
            this.label4.Text = "REPORTES ARRENDADOR";
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Ejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ejecutar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ejecutar.Location = new System.Drawing.Point(53, 467);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(165, 49);
            this.btn_Ejecutar.TabIndex = 42;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = false;
            // 
            // FormReporteArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 548);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGridViewBrete);
            this.Name = "FormReporteArrendador";
            this.Text = "FormReporteArrendador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dataGridViewBrete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Ejecutar;
    }
}