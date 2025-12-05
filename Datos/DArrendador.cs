using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArrendador: AccesoBD
    {
        private readonly DPersona dPersona = new DPersona();
        public string Registro(Arrendador a)
        {
            if (a?.Persona == null)
            {
                return "Error: Datos de arrendador incompletos.";
            }
            return EjecutarFuncion(bd =>
            {
                var persona = dPersona.Registro(bd,a.Persona);
                if (persona != "Correctamente")
                    return persona;
                bd.Arrendador.Add(a);
                bd.SaveChanges();
                return "Correctamente";
            });
        }
        public string Modificar(Arrendador a)
        {
            if (a == null)
            {
                return "Datos Invalidos";
            }

            return EjecutarFuncion(bd =>
            {
                var arrendadorExistente = bd.Arrendador.FirstOrDefault(ar => ar.IdArrendador == a.IdArrendador);
                if (arrendadorExistente == null)
                {
                    return "Arrendador no encontrado.";
                }
                var personaModificada = dPersona.Modificar(bd,a.Persona);
                if (personaModificada != "Correctamente")
                    return personaModificada;
                arrendadorExistente.IdPersona = a.IdPersona;
                bd.SaveChanges();
                return "Arrendador modificado correctamente";
            });
        }
        public string Eliminar(int idArrendador)
        {
            return EjecutarFuncion(bd =>
            {
                var existe = bd.Arrendador.Include("Persona")
                                          .FirstOrDefault(x => x.IdArrendador == idArrendador);

                if (existe == null)
                    return "Arrendador no encontrado.";

                int idPersona = existe.IdPersona;
                bd.Arrendador.Remove(existe);
                bd.SaveChanges();
                return dPersona.Eliminar(bd, idPersona);
            });
        }
        public List<Arrendador> Listar()
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Arrendador.Include("Persona").ToList();
            });
        }
        public Arrendador ObtenerPorId(int idArrendador)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Arrendador.Include("Persona").FirstOrDefault(a => a.IdArrendador == idArrendador);
            });
        }
        public List<Espacio> MostrarEspaciosPorArrendador(int idArrendador)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Espacio.Include("Arrendador").Where(e => e.IdArrendador == idArrendador).ToList();
            });
        }
    }
}
