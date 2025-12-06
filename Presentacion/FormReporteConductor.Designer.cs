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
            this.dgReporteConductor = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Modelo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Reporte1 = new System.Windows.Forms.Button();
            this.btn_Reporte2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteConductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 55);
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
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "REPORTES CONDUCTOR";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrescar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Refrescar.Location = new System.Drawing.Point(46, 523);
            this.btn_Refrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(165, 49);
            this.btn_Refrescar.TabIndex = 37;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(430, 529);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 43);
            this.btn_Salir.TabIndex = 36;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgReporteConductor
            // 
            this.dgReporteConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteConductor.Location = new System.Drawing.Point(235, 58);
            this.dgReporteConductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgReporteConductor.Name = "dgReporteConductor";
            this.dgReporteConductor.RowHeadersWidth = 51;
            this.dgReporteConductor.RowTemplate.Height = 24;
            this.dgReporteConductor.Size = new System.Drawing.Size(440, 209);
            this.dgReporteConductor.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 296);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 208);
            this.dataGridView1.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 73);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(95, 121);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker2.TabIndex = 43;
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(13, 338);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(45, 16);
            this.Modelo.TabIndex = 44;
            this.Modelo.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "FechaFin";
            // 
            // btn_Reporte1
            // 
            this.btn_Reporte1.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Reporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Reporte1.Location = new System.Drawing.Point(44, 176);
            this.btn_Reporte1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reporte1.Name = "btn_Reporte1";
            this.btn_Reporte1.Size = new System.Drawing.Size(165, 49);
            this.btn_Reporte1.TabIndex = 51;
            this.btn_Reporte1.Text = "Ejecutar Reporte 1";
            this.btn_Reporte1.UseVisualStyleBackColor = false;
            this.btn_Reporte1.Click += new System.EventHandler(this.btn_Reporte1_Click);
            // 
            // btn_Reporte2
            // 
            this.btn_Reporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte2.Location = new System.Drawing.Point(27, 389);
            this.btn_Reporte2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reporte2.Name = "btn_Reporte2";
            this.btn_Reporte2.Size = new System.Drawing.Size(165, 43);
            this.btn_Reporte2.TabIndex = 50;
            this.btn_Reporte2.Text = "Ejecutar Reporte 2";
            this.btn_Reporte2.UseVisualStyleBackColor = true;
            this.btn_Reporte2.Click += new System.EventHandler(this.btn_Reporte2_Click);
            // 
            // FormReporteConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 583);
            this.Controls.Add(this.btn_Reporte1);
            this.Controls.Add(this.btn_Reporte2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dgReporteConductor);
            this.Name = "FormReporteConductor";
            this.Text = "FormReporteConductor";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteConductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgReporteConductor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Reporte1;
        private System.Windows.Forms.Button btn_Reporte2;
    }
}