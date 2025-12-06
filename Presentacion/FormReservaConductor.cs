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
    public partial class FormReservaConductor : Form
    {
        private Persona usuario = new Persona();
        private Vehiculo vehiculo = new Vehiculo();
        private NPersona nConductor = new NPersona();
        private NEspacio nEspacio = new NEspacio();
        private NReserva nReserva = new NReserva();
        public FormReservaConductor(Persona usuarioIngresado,Vehiculo vehiculoIngresado)
        {
            InitializeComponent();
            usuario = usuarioIngresado;
            vehiculo = vehiculoIngresado;
            UiHelper.Mostrar(dgReservaConductores,nEspacio.Listar());
        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            if (dgReservaConductores.SelectedRows.Count == 0) //Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un espacio para reservar");
                return;
            }

            int IdEspacio = int.Parse(dgReservaConductores.SelectedRows[0].Cells["IdPersona"].Value.ToString());

            Reserva reserva = new Reserva()
            {
                IdVehiculo = vehiculo.IdVehiculo,
                IdEspacio = IdEspacio,
                Fecha = dateTimePicker1.Value.Date,
                Hora = dateTimePicker2.Value,
                CantidadHoras = int.Parse(textBox1.Text)
            };

            if (nReserva.Registro(reserva)!= "Reserva registrada correctamente.")
            {
                MessageBox.Show("La reserva se realizó con éxito.");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Ya existe una reserva para este horario o espacio.");
            }
        }
    }
}
