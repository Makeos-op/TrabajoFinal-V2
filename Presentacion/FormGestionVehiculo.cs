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
    public partial class FormGestionVehiculo : Form
    {
        private Vehiculo vehiculo;
        private NVehiculo nVehiculo = new NVehiculo();
        public FormGestionVehiculo(Vehiculo vehiculoExistente)
        {
            InitializeComponent();
            vehiculo = vehiculoExistente;
            CargarDatosVehiculo();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Cambiar título y textos de botones
            this.Text = "Gestionar Vehículo";
            label2.Text = "Modificar o Eliminar Vehículo";
            btnRegistrar.Text = "Modificar";

            // Deshabilitar matrícula (no se puede cambiar)
            tbMatricula.Enabled = false;
        }

        private void CargarDatosVehiculo()
        {
            tbMatricula.Text = vehiculo.Matricula;
            tbModelo.Text = vehiculo.Modelo;
            tbMarca.Text = vehiculo.Marca;
            tbColor.Text = vehiculo.Color;
            comboBox1.Text = ""; // Brevete no está directamente relacionado, solo es informativo
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el vehículo {vehiculo.Matricula}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultado = nVehiculo.Eliminar(vehiculo.IdVehiculo);

                    if (resultado == "Vehiculo eliminado correctamente.")
                    {
                        MessageBox.Show("Vehículo eliminado correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {resultado}",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbMatricula.Text) ||
                    string.IsNullOrWhiteSpace(tbModelo.Text) ||
                    string.IsNullOrWhiteSpace(tbMarca.Text) ||
                    string.IsNullOrWhiteSpace(tbColor.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                                    "Campos Vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar datos del vehículo
                vehiculo.Modelo = tbModelo.Text.Trim();
                vehiculo.Marca = tbMarca.Text.Trim();
                vehiculo.Color = tbColor.Text.Trim();

                string resultado = nVehiculo.Modificar(vehiculo);

                if (resultado == "Vehiculo modificado correctamente.")
                {
                    MessageBox.Show("Vehículo actualizado correctamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar: {resultado}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
