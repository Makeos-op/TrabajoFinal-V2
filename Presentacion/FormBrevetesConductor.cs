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
        private Persona usuario = new Persona();
        private NPersona nConductor = new NPersona();
        public FormBrevetesConductor(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
            UiHelper.Mostrar(dgBreveteMenu, nConductor.MostrarBrevetes(usuario.IdPersona));
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Abrir formulario de registro de brevete
            FormRegistroBrevete form = new FormRegistroBrevete(usuario);    //Logica de registro de brevete
            form.Show();
            //Mostrar Datos
            UiHelper.Mostrar(dgBreveteMenu, nConductor.MostrarBrevetes(usuario.IdPersona));
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            //Mostrar Datos
            UiHelper.Mostrar(dgBreveteMenu,nConductor.MostrarBrevetes(usuario.IdPersona));
        }
    }
}
