using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NPersona
    {
        private DPersona dPersona = new DPersona();
        public string Registro(Persona u)
        {
            return dPersona.Registro(u);
        }
        public string Modificar(Persona u)
        {
            return dPersona.Modificar(u);
        }
        public string Eliminar(int IdPersona)
        {
            return dPersona.Eliminar(IdPersona);
        }
        public bool Validacion(string correo, string contrasena)
        {
            return dPersona.Validacion(correo, contrasena);
        }
        public Persona ObtenerPersona(string correo, string contrasena)
        {
            return dPersona.ObtenerPersona(correo, contrasena);
        }
        public List<Persona> Listar()
        {
            return dPersona.Listar();
        }
        public Persona ObtenerPorId(int idConductor)
        {
            return dPersona.ObtenerPorId(idConductor);
        }
        public List<Vehiculo> MostraVehiculos(int id)
        {
            return dPersona.MostraVehiculos(id);
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            return dPersona.MostrarBrevetes(id);
        }
        public List<Espacio> MostrarEspacios(int idArrendador)
        {
            return dPersona.MostrarEspacios(idArrendador);
        }
        public List<Reserva> MostrarReservas(int id)
        {
            return dPersona.MostrarReservas(id);
        }
        public List<Reserva> ReservasPorRango(DateTime inicio, DateTime fin, int idConductor)
        {
            return dPersona.ReservasPorRango(inicio, fin, idConductor); 
        }
        public List<Reporte2> CantidadVehiculosPorTipo()
        {
           return dPersona.CantidadVehiculosPorTipo();
        }

        public int TotalReservas()
        {
            return dPersona.TotalReservas();
        }
        public decimal GananciasDelDia(int idArrendador, DateTime fecha)
        {
            return dPersona.GananciasDelDia(idArrendador, fecha);
        }
    }
}
