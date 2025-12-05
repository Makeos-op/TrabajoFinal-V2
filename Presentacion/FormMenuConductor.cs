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
    public partial class FormMenuConductor : Form
    {
        private Persona usuario = new Persona();
        public FormMenuConductor(Persona usuarioingresado)
        {
            InitializeComponent();
            usuario = usuarioingresado;
        }

        private void FormMenuConductor_Load(object sender, EventArgs e)
        {

        }
    }
}
