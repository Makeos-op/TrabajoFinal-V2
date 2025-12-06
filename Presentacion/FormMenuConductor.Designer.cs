namespace Presentacion
{
    partial class FormMenuConductor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgVehiculos = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_HacerReversas = new System.Windows.Forms.Button();
            this.btn_AgregarVehiculo = new System.Windows.Forms.Button();
            this.btn_VerBrevete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id";
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Location = new System.Drawing.Point(31, 213);
            this.dgVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.RowHeadersWidth = 51;
            this.dgVehiculos.RowTemplate.Height = 24;
            this.dgVehiculos.Size = new System.Drawing.Size(511, 335);
            this.dgVehiculos.TabIndex = 25;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(383, 552);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(159, 49);
            this.btn_Salir.TabIndex = 28;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_HacerReversas
            // 
            this.btn_HacerReversas.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_HacerReversas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HacerReversas.Location = new System.Drawing.Point(377, 145);
            this.btn_HacerReversas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HacerReversas.Name = "btn_HacerReversas";
            this.btn_HacerReversas.Size = new System.Drawing.Size(165, 49);
            this.btn_HacerReversas.TabIndex = 27;
            this.btn_HacerReversas.Text = "Hacer Reservas";
            this.btn_HacerReversas.UseVisualStyleBackColor = false;
            this.btn_HacerReversas.Click += new System.EventHandler(this.btn_HacerReversas_Click);
            // 
            // btn_AgregarVehiculo
            // 
            this.btn_AgregarVehiculo.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_AgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarVehiculo.Location = new System.Drawing.Point(31, 145);
            this.btn_AgregarVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AgregarVehiculo.Name = "btn_AgregarVehiculo";
            this.btn_AgregarVehiculo.Size = new System.Drawing.Size(165, 49);
            this.btn_AgregarVehiculo.TabIndex = 26;
            this.btn_AgregarVehiculo.Text = "Agregar Vehiculo";
            this.btn_AgregarVehiculo.UseVisualStyleBackColor = false;
            this.btn_AgregarVehiculo.Click += new System.EventHandler(this.btn_AgregarVehiculo_Click);
            // 
            // btn_VerBrevete
            // 
            this.btn_VerBrevete.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_VerBrevete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerBrevete.Location = new System.Drawing.Point(201, 145);
            this.btn_VerBrevete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_VerBrevete.Name = "btn_VerBrevete";
            this.btn_VerBrevete.Size = new System.Drawing.Size(165, 49);
            this.btn_VerBrevete.TabIndex = 29;
            this.btn_VerBrevete.Text = "Ver Brevete";
            this.btn_VerBrevete.UseVisualStyleBackColor = false;
            this.btn_VerBrevete.Click += new System.EventHandler(this.btn_VerBrevete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(195, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "CONDUCTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bienvenido conductor, sientase libre de agregar su vehiculo,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "ver su brevete o hacer una reserva";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.Location = new System.Drawing.Point(30, 552);
            this.btn_Reportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(165, 49);
            this.btn_Reportes.TabIndex = 33;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            // 
            // FormMenuConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 609);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_VerBrevete);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_HacerReversas);
            this.Controls.Add(this.btn_AgregarVehiculo);
            this.Controls.Add(this.dgVehiculos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuConductor";
            this.Text = "FormConductor";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVehiculos;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_HacerReversas;
        private System.Windows.Forms.Button btn_AgregarVehiculo;
        private System.Windows.Forms.Button btn_VerBrevete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Reportes;
    }
}