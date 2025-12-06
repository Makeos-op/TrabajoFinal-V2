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
    public partial class FormGestionUsuario : Form
    {
        private Persona usuario;
        private NPersona nPersona = new NPersona();

        public FormGestionUsuario(Persona usuarioActual)
        {
            InitializeComponent();
            usuario = usuarioActual;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            // Cargar datos del usuario actual en los controles
            txtnombres.Text = usuario.Nombres;
            txtapellidos.Text = usuario.Apellidos;
            txtdni.Text = usuario.Dni.ToString();
            txtedad.Text = usuario.Edad.ToString();
            txtnacionalidad.Text = usuario.Nacionalidad;
            txttelefono.Text = usuario.Telefono;
            txtcorreo.Text = usuario.Correo;
            txtcontrasena.Text = usuario.Contrasena;
            txtconfirmarcontrasena.Text = usuario.Contrasena;
            cmbtipoususario.Text = usuario.TipoUsuario;

            // Deshabilitar campos que no deberían modificarse
            txtdni.Enabled = false;
            cmbtipoususario.Enabled = false;
        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtnombres.Text) ||
                    string.IsNullOrWhiteSpace(txtapellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtedad.Text) ||
                    string.IsNullOrWhiteSpace(txtnacionalidad.Text) ||
                    string.IsNullOrWhiteSpace(txttelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtcorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtcontrasena.Text) ||
                    string.IsNullOrWhiteSpace(txtconfirmarcontrasena.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                                    "Campos Vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Validar coincidencia de contraseñas
                if (txtcontrasena.Text != txtconfirmarcontrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.",
                                    "Error de Validación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Actualizar datos del usuario
                usuario.Nombres = txtnombres.Text.Trim();
                usuario.Apellidos = txtapellidos.Text.Trim();
                usuario.Edad = int.Parse(txtedad.Text);
                usuario.Nacionalidad = txtnacionalidad.Text.Trim();
                usuario.Telefono = txttelefono.Text.Trim();
                usuario.Correo = txtcorreo.Text.Trim();
                usuario.Contrasena = txtcontrasena.Text.Trim();

                string resultado = nPersona.Modificar(usuario);

                if (resultado == "Modificación Exitosa")
                {
                    MessageBox.Show("Datos actualizados correctamente.",
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
                    "¿Está seguro que desea eliminar su cuenta? Esta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultado = nPersona.Eliminar(usuario.IdPersona);

                    if (resultado == "Eliminación Exitosa")
                    {
                        MessageBox.Show("Cuenta eliminada correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Cerrar todos los formularios y volver al login
                        Application.Restart();
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

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
