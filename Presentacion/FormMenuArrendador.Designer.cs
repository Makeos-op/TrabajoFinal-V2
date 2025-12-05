namespace Presentacion
{
    partial class FormMenuArrendador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AgregarEspacio = new System.Windows.Forms.Button();
            this.btn_VerReservas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(480, 350);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_AgregarEspacio
            // 
            this.btn_AgregarEspacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEspacio.Location = new System.Drawing.Point(120, 27);
            this.btn_AgregarEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AgregarEspacio.Name = "btn_AgregarEspacio";
            this.btn_AgregarEspacio.Size = new System.Drawing.Size(136, 49);
            this.btn_AgregarEspacio.TabIndex = 4;
            this.btn_AgregarEspacio.Text = "Agregar Espacio";
            this.btn_AgregarEspacio.UseVisualStyleBackColor = true;
            this.btn_AgregarEspacio.Click += new System.EventHandler(this.btn_AgregarEspacio_Click);
            // 
            // btn_VerReservas
            // 
            this.btn_VerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerReservas.Location = new System.Drawing.Point(296, 27);
            this.btn_VerReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_VerReservas.Name = "btn_VerReservas";
            this.btn_VerReservas.Size = new System.Drawing.Size(136, 49);
            this.btn_VerReservas.TabIndex = 5;
            this.btn_VerReservas.Text = "Ver Reservas";
            this.btn_VerReservas.UseVisualStyleBackColor = true;
            this.btn_VerReservas.Click += new System.EventHandler(this.btn_VerReservas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(205, 468);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(136, 49);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormMenuArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 539);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_VerReservas);
            this.Controls.Add(this.btn_AgregarEspacio);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuArrendador";
            this.Text = "FormArrendador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarEspacio;
        private System.Windows.Forms.Button btn_VerReservas;
        private System.Windows.Forms.Button btn_Salir;
    }
}