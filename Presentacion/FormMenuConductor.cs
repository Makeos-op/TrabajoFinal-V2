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
        private Persona usuario = new Persona();
        private NPersona nConductor = new NPersona();
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
            if (dgVehiculos.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Seleccione un vehiculo para hacer la reservar");
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            FormReporteConductor form = new FormReporteConductor(usuario);
            form.Show();
        }
        private void btn_GestionarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para gestionarlo.",
                                "Vehículo no seleccionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            try
            {
                var matricula = dgVehiculos.SelectedRows[0].Cells["Matricula"].Value.ToString();
                var vehiculo = nVehiculo.BuscarPorMatricula(matricula);

                if (vehiculo != null)
                {
                    FormGestionVehiculo form = new FormGestionVehiculo(vehiculo);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CargarVehiculos(); // Refrescar la lista
                        MessageBox.Show("Vehículo actualizado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el vehículo seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al gestionar vehículo: {ex.Message}");
            }
        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestionUsuario form = new FormGestionUsuario(usuario);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar datos del usuario
                    usuario = nConductor.ObtenerPorId(usuario.IdPersona);

                    if (usuario == null)
                    {
                        MessageBox.Show("La cuenta ha sido eliminada. Cerrando sesión...");
                        Application.Restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_HacerReversas_Click_1(object sender, EventArgs e)
        {

        }
    }
}
