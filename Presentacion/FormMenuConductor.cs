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

            if (usuarioIngresado == null)
            {
                MessageBox.Show("Error: Usuario no válido",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Obtener el conductor completo desde la base de datos
            usuario = nConductor.ObtenerPorId(usuarioIngresado.IdPersona);

            if (usuario == null)
            {
                MessageBox.Show("Error al cargar los datos del conductor",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Cargar vehículos del conductor
            CargarVehiculos();
        }

        private void CargarVehiculos()
        {
            try
            {
                var vehiculos = nConductor.MostraVehiculos(usuario.IdPersona);
                UiHelper.Mostrar(dgVehiculos, vehiculos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar vehículos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
