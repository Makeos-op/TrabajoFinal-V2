using Datos;
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
    public partial class FormRegistroEspacio : Form
    {
        private Arrendador usuario = new Arrendador();
        public FormRegistroEspacio(Arrendador usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

        }
    }
}