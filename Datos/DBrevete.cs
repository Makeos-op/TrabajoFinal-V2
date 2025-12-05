using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBrevete: AccesoBD
    {
        //Registro
        public string Registro(Brevete b)
        {
            if (b?.Conductor == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                bd.Brevete.Add(b);
                bd.SaveChanges();
                return "Brevete registrado correctamente.";
            });
        }
        //Modificar
        public string Modificar(Brevete b)
        {
            if (b?.Conductor == null)
            {
                return "El conductor no puede ser nulo.";
            }
            return EjecutarFuncion(bd =>
            {
                var brevete = bd.Brevete.Find(b.IdBrevete);
                if (brevete == null)
                {
                    return "Brevete no encontrado.";
                }
                bd.Entry(brevete).CurrentValues.SetValues(b); //Modificar los valores
                bd.SaveChanges();
                return "Brevete modificado correctamente.";
            });
        }
        //Eliminar
        public string Eliminar(int idBrevete)
        {
            return EjecutarFuncion(bd =>
            {
                var brevete = bd.Brevete.Find(idBrevete);
                if (brevete == null)
                {
                    return "Brevete no encontrado.";
                }
                bd.Brevete.Remove(brevete);
                bd.SaveChanges();
                return "Brevete eliminado correctamente.";
            });
        }
    }
}
