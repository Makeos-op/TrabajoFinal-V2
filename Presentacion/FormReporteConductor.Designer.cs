namespace Presentacion
{
    partial class FormReporteConductor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.dataGridViewBrete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrete)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(229, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "REPORTES ARRENDADOR";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrescar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Refrescar.Location = new System.Drawing.Point(476, 456);
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
            this.btn_Salir.Location = new System.Drawing.Point(280, 460);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 43);
            this.btn_Salir.TabIndex = 36;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Ejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ejecutar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ejecutar.Location = new System.Drawing.Point(53, 456);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(165, 49);
            this.btn_Ejecutar.TabIndex = 35;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewBrete
            // 
            this.dataGridViewBrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrete.Location = new System.Drawing.Point(53, 97);
            this.dataGridViewBrete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBrete.Name = "dataGridViewBrete";
            this.dataGridViewBrete.RowHeadersWidth = 51;
            this.dataGridViewBrete.RowTemplate.Height = 24;
            this.dataGridViewBrete.Size = new System.Drawing.Size(588, 343);
            this.dataGridViewBrete.TabIndex = 34;
            // 
            // FormReporteConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.dataGridViewBrete);
            this.Name = "FormReporteConductor";
            this.Text = "FormReporteConductor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.DataGridView dataGridViewBrete;
    }
}