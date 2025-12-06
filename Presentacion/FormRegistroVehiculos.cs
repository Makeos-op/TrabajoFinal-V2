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
    public partial class FormRegistroVehiculos : Form
    {
        private Conductor usuario = new Conductor();
        private NVehiculo nVehiculo = new NVehiculo();
        public FormRegistroVehiculos(Conductor usuarioIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
        }

        private void FormRegistroVehiculos_Load(object sender, EventArgs e)
        {
            if (tbMatricula.Text == "" || tbModelo.Text == "" || tbMarca.Text == "" || tbColor.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos Vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Vehiculo vehiculo = new Vehiculo();
            {
                vehiculo.Matricula = tbMatricula.Text;
                vehiculo.Marca = tbMarca.Text;
                vehiculo.Color = tbColor.Text;
                vehiculo.Modelo = tbModelo.Text;
                vehiculo.Conductor.IdPersona = usuario.IdPersona;
                vehiculo.LicenciaNecesaria = comboBox1.Text;
            }
            if (nVehiculo.Registro(vehiculo) != "Vehiculo registrado correctamente.")
            {
                MessageBox.Show("Error al registrar el vehículo.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            MessageBox.Show("Vehículo registrado correctamente.",
                                "Éxito",
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
