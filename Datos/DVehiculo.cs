using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo:AccesoBD
    {
        //Registro
        public string Registro(Vehiculo b)
        {
            if (b?.Conductor == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                bd.Vehiculo.Add(b);
                bd.SaveChanges();
                return "Vehiculo registrado correctamente.";
            });
        }
        //Modificar
        public string Modificar(Vehiculo b)
        {
            if (b?.Conductor == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                var vehiculo = bd.Vehiculo.Find(b.IdVehiculo);
                if (vehiculo == null)
                {
                    return "Vehiculo no encontrado.";
                }
                bd.Entry(vehiculo).CurrentValues.SetValues(b);
                bd.SaveChanges();
                return "Vehiculo modificado correctamente.";
            });
        }
        //Eliminar
        public string Eliminar(int idVehiculo)
        {
            return EjecutarFuncion(bd =>
            {
                var vehiculo = bd.Vehiculo.Find(idVehiculo);
                if (vehiculo == null)
                {
                    return "Vehiculo no encontrado.";
                }
                bd.Vehiculo.Remove(vehiculo);
                bd.SaveChanges();
                return "Vehiculo eliminado correctamente.";
            });
        }
        public Vehiculo BuscarPorMatricula(string matricula)
        {
            return EjecutarFuncion(bd =>
            {
                var vehiculo = bd.Vehiculo.FirstOrDefault(v => v.Matricula == matricula);
                return vehiculo;
            });
        }
    }
}
