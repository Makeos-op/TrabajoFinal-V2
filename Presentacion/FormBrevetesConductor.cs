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
    public partial class FormBrevetesConductor : Form
    {
        private Conductor usuario = new Conductor();
        public FormBrevetesConductor(Conductor usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Abrir formulario de registro de brevete
            FormRegistroBrevete form = new FormRegistroBrevete(usuario);    //Logica de registro de brevete
            //Mostrar Datos
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            //Mostrar Datos
        }
    }
}
