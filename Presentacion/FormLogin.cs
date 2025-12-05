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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtususario.Clear();
            txtcontrasenalogin.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtususario.Text == "" || txtcontrasenalogin.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos Vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            string correoIngresado;

            try
            {
                correoIngresado = txtususario.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del correo es inválido. Por favor, verifica e intenta nuevamente.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            string contrasenaIngresada = txtcontrasenalogin.Text;
            // Aquí iría la lógica para validar el usuario con el servicio correspondiente
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            FormRegistro form = new FormRegistro();
            form.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
