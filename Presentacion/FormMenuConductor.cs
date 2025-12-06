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
    public partial class FormMenuConductor : Form
    {
        private Conductor usuario = new Conductor();
        private NConductor nConductor = new NConductor();
        private NVehiculo nVehiculo = new NVehiculo();
        public FormMenuConductor(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = nConductor.ObtenerPorId(usuarioIngresado.IdPersona);
            UiHelper.Mostrar(dgVehiculos, nConductor.MostraVehiculos(usuario.IdPersona));
        }

        private void btn_VerBrevete_Click(object sender, EventArgs e)
        {
            FormBrevetesConductor form = new FormBrevetesConductor(usuario);
            form.Show();
        }

        private void btn_HacerReversas_Click(object sender, EventArgs e)
        {
            if (dgVehiculos.SelectedRows.Count == 0) //Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un espacio para reservar");
                return;
            }
            var vehiculo = nVehiculo.BuscarPorMatricula(dgVehiculos.SelectedRows[0].Cells["Matricula"].Value.ToString());
            FormReservaConductor form = new FormReservaConductor(usuario,vehiculo);
            form.Show();
        }

        private void btn_AgregarVehiculo_Click(object sender, EventArgs e)
        {
            FormRegistroVehiculos form = new FormRegistroVehiculos(usuario);
            form.Show();
        }
    }
}
