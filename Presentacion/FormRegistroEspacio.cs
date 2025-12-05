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
        private Persona usuario = new Persona();
        public FormRegistroEspacio(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }
    }
}
