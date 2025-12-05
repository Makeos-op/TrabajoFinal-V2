using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormMenuArrendador : Form
    {
        public FormMenuArrendador()
        {
            InitializeComponent();
        }

        private void btn_VerReservas_Click(object sender, EventArgs e)
        {
            FormReservaArrendador form = new FormReservaArrendador();
            form.Show();
        }

        private void btn_AgregarEspacio_Click(object sender, EventArgs e)
        {
            FormRegistroEspacio form = new FormRegistroEspacio();
            form.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
