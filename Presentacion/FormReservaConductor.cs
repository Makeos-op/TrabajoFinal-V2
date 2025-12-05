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
    public partial class FormReservaConductor : Form
    {
        private Conductor usuario = new Conductor();
        public FormReservaConductor(Conductor usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }
    }
}
