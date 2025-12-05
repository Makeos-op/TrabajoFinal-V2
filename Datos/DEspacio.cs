using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEspacio:AccesoBD
    {
        //Registro
        public string Registro(Espacio b)
        {
            if (b?.Arrendador == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                bd.Espacio.Add(b);
                bd.SaveChanges();
                return "Espacio registrado correctamente.";
            });
        }
        //Modificar
        public string Modificar(Espacio b)
        {
            if (b?.IdArrendador == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                var espacio = bd.Espacio.Find(b.IdEspacio);
                if (espacio == null)
                {
                    return "Espacio no encontrado.";
                }
                bd.Entry(espacio).CurrentValues.SetValues(b);
                bd.SaveChanges();
                return "Espacio modificado correctamente.";
            });
        }
        //Eliminar
        public string Eliminar(int idEspacio)
        {
            return EjecutarFuncion(bd =>
            {
                var espacio = bd.Espacio.Find(idEspacio);
                if (espacio == null)
                {
                    return "Espacio no encontrado.";
                }
                bd.Espacio.Remove(espacio);
                bd.SaveChanges();
                return "Espacio eliminado correctamente.";
            });
        }
        public Espacio BuscarEspacioPorId(int Id)
        {
            return EjecutarFuncion(bd =>
            {
                return bd.Espacio.Find(Id);
            });
        }
    }
}
