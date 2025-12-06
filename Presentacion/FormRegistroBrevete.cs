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
    public partial class FormRegistroBrevete : Form
    {
        private Persona usuario = new Persona();
        private NBrevete nBrevete = new NBrevete();
        public FormRegistroBrevete(Persona usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void btnregistrarbrevete_Click(object sender, EventArgs e)
        {
            // --- Obtener valores de los TextBox ---
            string idText = txtidbrevete.Text.Trim();
            string categoria = txtcategoriabrevete.Text.Trim();
            string fechaEmisionText = dateTimePicker1.Text.Trim();
            string fechaCaducidadText = dateTimePicker2.Text.Trim();
            int DNI = usuario.IdPersona;

            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(fechaEmisionText) ||
                string.IsNullOrWhiteSpace(fechaCaducidadText))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int id;
            DateTime fechaEmision;
            DateTime fechaCaducidad;

            if (!int.TryParse(idText, out id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(fechaEmisionText, out fechaEmision))
            {
                MessageBox.Show("La fecha de emisión no tiene un formato válido. (Ejemplo: 24/10/2025)",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(fechaCaducidadText, out fechaCaducidad))
            {
                MessageBox.Show("La fecha de caducidad no tiene un formato válido. (Ejemplo: 24/10/2030)",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (fechaCaducidad <= fechaEmision)
            {
                MessageBox.Show("La fecha de caducidad debe ser posterior a la fecha de emisión.",
                                "Fechas inválidas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (fechaEmision > DateTime.Now)
            {
                MessageBox.Show("La fecha de emisión no puede ser en el futuro.",
                                "Fecha inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            Brevete brevete = new Brevete();
            {
                brevete.IdBrevete = id;
                brevete.Categoria = categoria;
                brevete.FechaCaducidad = fechaCaducidad;
                brevete.FechaEmision = fechaEmision;
                brevete.IdPersona = usuario.IdPersona;
            }
            if (nBrevete.Registro(brevete)!= "Brevete registrado correctamente.")
            {
                MessageBox.Show("Error en el registro",
                                "Error de registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Brevete registrado con éxito.",
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
