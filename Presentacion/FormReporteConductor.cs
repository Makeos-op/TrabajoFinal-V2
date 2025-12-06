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

        public FormReporteConductor(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            dgReporteConductor.DataSource = null;
            dataGridView1.DataSource = null;
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            UiHelper.Mostrar(dgReporteConductor, nConductor.MostrarBrevetes(usuario.IdPersona));
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reporte1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.",
                                    "Validación de Fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                DateTime inicio = dateTimePicker1.Value.Date;
                DateTime fin = dateTimePicker2.Value.Date;
                var reservas = nConductor.ReservasPorRango(inicio, fin, usuario.IdPersona);

                if (reservas == null || reservas.Count == 0)
                {
                    MessageBox.Show("No se encontraron reservas en el rango de fechas seleccionado.",
                                    "Sin Resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    dgReporteConductor.DataSource = null;
                    return;
                }
                var reporte = reservas.Select(r => new
                {
                    IdReserva = r.IdReserva,
                    Fecha = r.Fecha.ToString("dd/MM/yyyy"),
                    Hora = r.Hora.ToString("HH:mm"),
                    CantidadHoras = r.CantidadHoras,
                    Espacio = r.Espacio?.Ubicacion ?? "N/A",
                    Vehículo = r.Vehiculo?.Matricula ?? "N/A",
                    Modelo = r.Vehiculo?.Modelo ?? "N/A"
                }).ToList();

                dgReporteConductor.DataSource = reporte;

                MessageBox.Show($"Se encontraron {reporte.Count} reserva(s) en el rango seleccionado.",
                                "Reporte Generado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_Reporte2_Click(object sender, EventArgs e)
        {
            try
            {
                string marcaVehiculo = textBox1.Text.Trim();

                var lista = nConductor.CantidadVehiculosPorTipo();

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No hay vehículos registrados.", "Sin resultados",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    return;
                }

                // Filtrar si hay texto
                if (!string.IsNullOrEmpty(marcaVehiculo))
                {
                    lista = lista
                        .Where(x => x.Marca.ToLower().Contains(marcaVehiculo.ToLower()))
                        .ToList();

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron coincidencias.",
                                        "Sin resultados",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        return;
                    }
                }

                dataGridView1.DataSource = lista;

                MessageBox.Show("Reporte generado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void btn_Refrescar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConfigurarFormulario();
                MessageBox.Show("Formulario actualizado correctamente.",
                                "Actualización",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el formulario: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
