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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(360, 284);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_AgregarEspacio
            // 
            this.btn_AgregarEspacio.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_AgregarEspacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEspacio.Location = new System.Drawing.Point(22, 380);
            this.btn_AgregarEspacio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AgregarEspacio.Name = "btn_AgregarEspacio";
            this.btn_AgregarEspacio.Size = new System.Drawing.Size(102, 40);
            this.btn_AgregarEspacio.TabIndex = 4;
            this.btn_AgregarEspacio.Text = "Agregar Espacio";
            this.btn_AgregarEspacio.UseVisualStyleBackColor = false;
            this.btn_AgregarEspacio.Click += new System.EventHandler(this.btn_AgregarEspacio_Click);
            // 
            // btn_VerReservas
            // 
            this.btn_VerReservas.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_VerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerReservas.Location = new System.Drawing.Point(280, 380);
            this.btn_VerReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VerReservas.Name = "btn_VerReservas";
            this.btn_VerReservas.Size = new System.Drawing.Size(102, 40);
            this.btn_VerReservas.TabIndex = 5;
            this.btn_VerReservas.Text = "Ver Reservas";
            this.btn_VerReservas.UseVisualStyleBackColor = false;
            this.btn_VerReservas.Click += new System.EventHandler(this.btn_VerReservas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(154, 380);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(102, 40);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARRENDADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido arrendador, en esta sección podra agregar su espacio y ver su reserva";
            // 
            // FormMenuArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_VerReservas);
            this.Controls.Add(this.btn_AgregarEspacio);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuArrendador";
            this.Text = "FormArrendador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarEspacio;
        private System.Windows.Forms.Button btn_VerReservas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}