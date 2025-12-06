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
    public partial class FormLogin : Form
    {
        private NPersona nPersona = new NPersona();
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
            if (string.IsNullOrWhiteSpace(txtususario.Text) ||
                string.IsNullOrWhiteSpace(txtcontrasenalogin.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos Vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            string correoIngresado = txtususario.Text.Trim();
            string contrasenaIngresada = txtcontrasenalogin.Text.Trim();
            if (!nPersona.Validacion(correoIngresado, contrasenaIngresada))
            {
                MessageBox.Show("Correo o contraseña incorrectos. Por favor, intente nuevamente.",
                                "Error de inicio de sesión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                LimpiarCampos();
                return;
            }
            var usuario = nPersona.ObtenerPersona(correoIngresado, contrasenaIngresada);
            if (usuario == null)
            {
                MessageBox.Show("Error al obtener los datos del usuario.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("¡Inicio de sesión exitoso!",
                            "Bienvenido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            LimpiarCampos();
            this.Hide();
            if (usuario.TipoUsuario == "Conductor")
            {
                FormMenuConductor formConductor = new FormMenuConductor(usuario);
                formConductor.FormClosed += (s, args) => this.Show(); 
                formConductor.Show();
            }
            else if (usuario.TipoUsuario == "Arrendador")
            {
                FormMenuArrendador formArrendador = new FormMenuArrendador(usuario);
                formArrendador.FormClosed += (s, args) => this.Show();
                formArrendador.Show();
            }
            else
            {
                MessageBox.Show("Tipo de usuario no válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Show();
            }
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
