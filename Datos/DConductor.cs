using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConductor : AccesoBD
    {
        private readonly DPersona dPersona = new DPersona();
        public string Registro(Conductor a)
        {
            if (a?.Persona == null)
            {
                return "Error: Datos de conductor incompletos.";
            }
            return EjecutarFuncion(bd =>
            {
                var persona = dPersona.Registro(bd, a.Persona);
                if (persona != "Correctamente")
                    return persona;
                bd.Conductor.Add(a);
                bd.SaveChanges();
                return "Correctamente";
            });
        }
        public string Modificar(Conductor a)
        {
            if (a == null)
            {
                return "Datos Invalidos";
            }

            return EjecutarFuncion(bd =>
            {
                var conductor = bd.Conductor.FirstOrDefault(ar => ar.IdConductor == a.IdConductor);
                if (conductor == null)
                {
                    return "Conductor no encontrado.";
                }
                var personaModificada = dPersona.Modificar(bd, a.Persona);
                if (personaModificada != "Correctamente")
                    return personaModificada;
                conductor.IdPersona = a.IdPersona;
                bd.SaveChanges();
                return "Conductor modificado correctamente";
            });
        }
        public string Eliminar(int idConductor)
        {
            return EjecutarFuncion(bd =>
            {
                var conductor = bd.Conductor.Include("Persona")
                                          .FirstOrDefault(x => x.IdConductor == idConductor);

                if (conductor == null)
                    return "Conductor no encontrado.";

                int idPersona = conductor.IdPersona;
                bd.Conductor.Remove(conductor);
                bd.SaveChanges();
                return dPersona.Eliminar(bd, idPersona);
            });
        }
        public List<Conductor> Listar()
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Conductor.Include("Persona").ToList();
            });
        }
        public Conductor ObtenerPorId(int idConductor)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Conductor.Include("Persona").FirstOrDefault(a => a.IdConductor == idConductor);
            });
        }
        public List<Vehiculo> MostraVehiculos(int id)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Vehiculo.Where(v => v.IdConductor == id).ToList();
            });
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Brevete.Where(b => b.IdConductor == id).ToList();
            });
        }
    }       
}
