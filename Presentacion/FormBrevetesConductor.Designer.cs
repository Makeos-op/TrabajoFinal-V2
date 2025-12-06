namespace Presentacion
{
    partial class FormBrevetesConductor
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
            this.dgBreveteMenu = new System.Windows.Forms.DataGridView();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBreveteMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBreveteMenu
            // 
            this.dgBreveteMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBreveteMenu.Location = new System.Drawing.Point(41, 94);
            this.dgBreveteMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgBreveteMenu.Name = "dgBreveteMenu";
            this.dgBreveteMenu.RowHeadersWidth = 51;
            this.dgBreveteMenu.RowTemplate.Height = 24;
            this.dgBreveteMenu.Size = new System.Drawing.Size(588, 343);
            this.dgBreveteMenu.TabIndex = 26;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Registrar.Location = new System.Drawing.Point(41, 453);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(165, 49);
            this.btn_Registrar.TabIndex = 27;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(268, 457);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 43);
            this.btn_Salir.TabIndex = 29;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrescar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Refrescar.Location = new System.Drawing.Point(464, 453);
            this.btn_Refrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(165, 49);
            this.btn_Refrescar.TabIndex = 30;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(217, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "REGISTRAR BREVETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "En este apartado, usted podra registrar su brevete ";
            // 
            // FormBrevetesConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgBreveteMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBrevetesConductor";
            this.Text = "FormBreveteMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgBreveteMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBreveteMenu;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}