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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormReporteArrendador : Form
    {
        private Persona usuario = new Persona();
        private NPersona nArrendador = new NPersona();
        public FormReporteArrendador(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void btn_Reporte3_Click(object sender, EventArgs e)
        {
            try
            {
                int totalReservas = nArrendador.TotalReservas();
                string mensaje = $"Total de reservas en el sistema: {totalReservas}\n\n" +
                                $"Este reporte muestra la cantidad total de todas las reservas\n" +
                                $"registradas en el sistema, sin importar el arrendador.";

                MessageBox.Show(mensaje,
                                "Reporte 3 - Total de Reservas",
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

        private void btn_Reporte4_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = nArrendador.GananciasDelDia(usuario.IdPersona, DateTime.Today);
                MessageBox.Show(
                        "Ganancias del día: S/. " + total.ToString("0.00"),
                        "Reporte 4",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }
    }
}
