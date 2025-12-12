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
    public partial class FormRegistroEspacio : Form
    {
        private Persona usuario = new Persona();
        private NPersona nArrendador = new NPersona();
        private NEspacio nEspacio = new NEspacio();
        public FormRegistroEspacio(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string idText, tarifaText, ubicacion;
            bool flowControl = ValidacionVacio(out idText, out tarifaText, out ubicacion);
            if (!flowControl)
            {
                return;
            }

            int id;
            decimal tarifa;
            bool flow = Validacion(idText, tarifaText, out id, out tarifa);
            if (!flow)
            {
                return;
            }
            Espacio espacio = new Espacio();
            {
                espacio.IdPersona = usuario.IdPersona;
                espacio.TarifaHora = tarifa;
                espacio.Ubicacion = ubicacion;
                espacio.IdEspacio = id;
            }
            if (nEspacio.Registro(espacio) != "Espacio registrado correctamente.")
            {
                MessageBox.Show("Error en el registro",
                            "Error de registro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Espacio registrado con éxito.",
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }

        private static bool Validacion(string idText, string tarifaText, out int id, out decimal tarifa)
        {
            tarifa = 0;
            if (!int.TryParse(idText, out id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(tarifaText, out tarifa))
            {
                MessageBox.Show("La tarifa debe ser un número válido (use solo dígitos o coma decimal).",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }


            if (tarifa <= 0)
            {
                MessageBox.Show("La tarifa por hora debe ser mayor a 0.",
                                "Valor inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidacionVacio(out string idText, out string tarifaText, out string ubicacion)
        {
            idText = txtidespacioalquilar.Text.Trim();
            tarifaText = txttarifaporhora.Text.Trim();
            ubicacion = txtubicacionalquilar.Text.Trim();
            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrWhiteSpace(tarifaText) ||
                string.IsNullOrWhiteSpace(ubicacion))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}