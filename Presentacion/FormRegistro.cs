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
    public partial class FormRegistro : Form
    {
        private NPersona nPersona = new NPersona();
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtnombres.Clear();
            txtapellidos.Clear();
            txtedad.Clear();
            txtnacionalidad.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            txtdni.Clear();
            txtcontrasena.Clear();
            txtconfirmarcontrasena.Clear();
            cmbtipoususario.SelectedIndex = -1;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txtnombres.Text == "" || txtdni.Text == "" || txtedad.Text == "" || txtapellidos.Text == "" ||
                txtnacionalidad.Text == "" || txttelefono.Text == "" || cmbtipoususario.Text == "" ||
                txtcorreo.Text == "" || txtcontrasena.Text == "" || txtconfirmarcontrasena.Text == "")
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (txtcontrasena.Text != txtconfirmarcontrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica e intenta nuevamente.",
                                "Error de contraseña",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            Persona usuario = new Persona
            {
                Dni = int.Parse(txtdni.Text),
                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                Edad = int.Parse(txtedad.Text),
                Nacionalidad = txtnacionalidad.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Contrasena = txtcontrasena.Text,
                TipoUsuario = cmbtipoususario.Text,
            };
            if (nPersona.Registro(usuario)!= "Registro Exitoso")
            {
                MessageBox.Show("Hubo un problema con el registro del usuario. Intente de nuevo",
                                "Error de registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Registro Exitoso",
                                "Registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            LimpiarCampos();
                Close();
            }
        }
    }   