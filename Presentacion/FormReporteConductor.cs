using Datos;
using Negocios;
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
    public partial class FormReporteConductor : Form
    {
        private Persona usuario = new Persona();
        private NPersona nConductor = new NPersona();
        public FormReporteConductor()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            UiHelper.Mostrar(dgReporteConductor, nConductor.MostrarBrevetes(usuario.IdPersona));
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
