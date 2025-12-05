using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPersona:AccesoBD
    {
        public string Registro(BDEFEntities bd,Persona u)
        {
            bd.Persona.Add(u);
            bd.SaveChanges();
            return "Registro Exitoso";
        }
        public string Modificar(BDEFEntities bd, Persona u)
        {
            var persona = bd.Persona.Find(u.IdPersona);
            if (persona == null)
            {
                return "Persona no encontrada";
            }
            bd.Entry(persona).CurrentValues.SetValues(u);
            return "Modificación Exitosa";
        }
        public string Eliminar(BDEFEntities bd, int IdPersona)
        {
            var persona = bd.Persona.Find(IdPersona);
            if (persona == null)
            {
                return "Persona no encontrada";
            }
           bd.Persona.Remove(persona);
           bd.SaveChanges();
           return "Eliminación Exitosa";
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


    }
}
