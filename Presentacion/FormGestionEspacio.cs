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
    public partial class FormGestionEspacio : Form
    {
        private Espacio espacio;
        private NEspacio nEspacio = new NEspacio();

        public FormGestionEspacio(Espacio espacioExistente)
        {
            InitializeComponent();
            espacio = espacioExistente;
            CargarDatosEspacio();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Gestionar Espacio";
            label4.Text = "Modificar o Eliminar Espacio de Alquiler";
            btn_Registrar.Text = "Modificar";

            // Deshabilitar ID (no se puede cambiar)
            txtidespacioalquilar.Enabled = false;
        }

        private void CargarDatosEspacio()
        {
            txtidespacioalquilar.Text = espacio.IdEspacio.ToString();
            txttarifaporhora.Text = espacio.TarifaHora.ToString("0.00");
            txtubicacionalquilar.Text = espacio.Ubicacion;
            txtareaalquilar.Text = espacio.Valoracion?.ToString() ?? ""; // Área o valoración
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                string tarifaText = txttarifaporhora.Text.Trim();
                string ubicacion = txtubicacionalquilar.Text.Trim();

                if (string.IsNullOrWhiteSpace(tarifaText) ||
                    string.IsNullOrWhiteSpace(ubicacion))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                                    "Campos Vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tarifaText, out decimal tarifa))
                {
                    MessageBox.Show("La tarifa debe ser un número válido.",
                                    "Error de Formato",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                if (tarifa <= 0)
                {
                    MessageBox.Show("La tarifa debe ser mayor a 0.",
                                    "Valor Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar datos del espacio
                espacio.TarifaHora = tarifa;
                espacio.Ubicacion = ubicacion;

                string resultado = nEspacio.Modificar(espacio);

                if (resultado == "Espacio modificado correctamente.")
                {
                    MessageBox.Show("Espacio actualizado correctamente.",
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el espacio en {espacio.Ubicacion}?\n" +
                    "Esto también eliminará todas las reservas asociadas.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultado = nEspacio.Eliminar(espacio.IdEspacio);

                    if (resultado == "Espacio eliminado correctamente.")
                    {
                        MessageBox.Show("Espacio eliminado correctamente.",
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
