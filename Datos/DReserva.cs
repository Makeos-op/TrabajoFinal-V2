using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReserva:AccesoBD
    {
        //Registro
        public string Registro(Reserva r)
        {
            if (r.IdVehiculo<=0 || r.IdEspacio<=0 )
            {
                return "El vehiculo y/o reserva no puede ser nula.";
            }
            return EjecutarFuncion(bd =>
            {
                bd.Reserva.Add(r);
                bd.SaveChanges();
                return "Reserva registrada correctamente.";
            });
        }
        //Modificar
        public string Modificar(Reserva r)
        {
            if (r?.Vehiculo == null || r?.Espacio == null)
            {
                return "El vehiculo y/o reserva no puede ser nula.";
            }
            return EjecutarFuncion(bd =>
            {
                var reserva = bd.Reserva.Find(r.IdReserva);
                if (reserva == null)
                {
                    return "Reserva no encontrada.";
                }
                bd.Entry(reserva).CurrentValues.SetValues(r);
                bd.SaveChanges();
                return "Reserva modificada correctamente.";
            });
        }
        //Eliminar
        public string Eliminar(int idReserva)
        {
            return EjecutarFuncion(bd =>
            {
                var reserva = bd.Reserva.Find(idReserva);
                if (reserva == null)
                {
                    return "Reserva no encontrada.";
                }
                bd.Reserva.Remove(reserva);
                bd.SaveChanges();
                return "Reserva eliminada correctamente.";
            });
        }
    }
}
