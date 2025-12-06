using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPersona:AccesoBD
    {
        public string Registro(Persona u)
        {
            return EjecutarFuncion(bd =>
            {
                if (bd.Persona.Any(p => p.Correo == u.Correo))
                {
                    throw new Exception("El correo ya está registrado.");
                }
                bd.Persona.Add(u);
                bd.SaveChanges();
                return "Registro Exitoso";
            });
        }
        public string Modificar(Persona u)
        {
            return EjecutarFuncion(bd =>
            {
                var persona = bd.Persona.Find(u.IdPersona);
                if (persona == null)
                {
                    throw new Exception("Persona no encontrada");
                }
                bd.Entry(persona).CurrentValues.SetValues(u);
                bd.SaveChanges();
                return "Modificación Exitosa";
            });
        }
        public string Eliminar(int IdPersona)
        {
            return EjecutarFuncion(bd =>
            {
                var persona = bd.Persona.Find(IdPersona);
                if (persona == null)
                {
                    return "Persona no encontrada";

                }
                bd.Persona.Remove(persona);
                bd.SaveChanges();
                return "Eliminación Exitosa";
            });
        }
        public bool Validacion(string correo,string contrasena)
        {
            return EjecutarFuncion(bd =>
            {
                if (bd.Persona.Any(p => p.Correo == correo && p.Contrasena == contrasena))
                    return true;
                return false;
            });
        }
        public Persona ObtenerPersona (string correo, string contrasena)
        {
            return EjecutarFuncion(bd =>
            {
                if (bd.Persona.Any(p => p.Correo == correo && p.Contrasena == contrasena))
                {
                    return bd.Persona.FirstOrDefault(p => p.Correo == correo && p.Contrasena == contrasena);
                }
                return null;
            });
        }
        public List<Persona> Listar()
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Persona.ToList();
            });
        }
        public Persona ObtenerPorId(int idConductor)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Persona.FirstOrDefault(a => a.IdPersona == idConductor);
            });
        }
        public List<Vehiculo> MostraVehiculos(int id)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Vehiculo.Where(v => v.IdPersona == id).ToList();
            });
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Brevete.Where(b => b.IdPersona == id).ToList();
            });
        }
        public List<Espacio> MostrarEspacios(int idArrendador)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                return bd.Espacio.Include("Arrendador").Where(e => e.IdPersona == idArrendador).ToList();
            });
        }
        public List<Reserva> MostrarReservas(int id)
        {
            return EjecutarFuncion(bd =>
            {
                bd.Configuration.LazyLoadingEnabled = false;
                var reservas = bd.Reserva.Include("Espacio").Where(r => r.Espacio.IdPersona == id).ToList();
                return reservas;
            });
        }

    }
}
