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
        public string Registro(Reserva b)
        {
            if (b?.Vehiculo==null || b?.Espacio== null)
            {
                return "El vehiculo y/o reserva no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                bd.Reserva.Add(b);
                bd.SaveChanges();
                return "Reserva registrado correctamente.";
            });
        }
        //Modificar
        public string Modificar(Reserva b)
        {
            if (b?.Vehiculo == null || b?.Espacio == null)
            {
                return "El vehiculo y/o reserva no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                var reserva = bd.Reserva.Find(b.IdReserva);
                if (reserva == null)
                {
                    return "Reserva no encontrada.";
                }
                bd.Entry(reserva).CurrentValues.SetValues(b);
                bd.SaveChanges();
                return "Reserva modificado correctamente.";
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
