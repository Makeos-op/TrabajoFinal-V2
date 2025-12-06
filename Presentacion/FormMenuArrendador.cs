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
    public partial class FormMenuArrendador : Form
    {
        private Persona usuario = new Persona();
        private NPersona nArrendador = new NPersona();
        public FormMenuArrendador(Persona usuarioIngresado)
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

            // Obtener el arrendador completo desde la base de datos
            usuario = nArrendador.ObtenerPorId(usuarioIngresado.IdPersona);

            if (usuario == null)
            {
                MessageBox.Show("Error al cargar los datos del arrendador",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
                return;
            }
            // Cargar espacios del arrendador
            CargarEspacios();
        }

        private void CargarEspacios()
        {
            try
            {
                var espacios = nArrendador.MostrarEspacios(usuario.IdPersona);
                UiHelper.Mostrar(DgEspacios, espacios);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar espacios: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_VerReservas_Click(object sender, EventArgs e)
        {
            FormReservaArrendador form = new FormReservaArrendador(usuario);
            form.Show();
        }

        private void btn_AgregarEspacio_Click(object sender, EventArgs e)
        {
            FormRegistroEspacio form = new FormRegistroEspacio(usuario);
            form.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            FormReporteArrendador form = new FormReporteArrendador(usuario);
            form.Show();
        }
    }
}
