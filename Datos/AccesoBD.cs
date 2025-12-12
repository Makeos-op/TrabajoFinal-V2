using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class AccesoBD
    {
        //Ejecutar Funcion ()
        protected T EjecutarFuncion<T>(Func<BDEFEntities,T> funcion)
        {
            try
            {
                using (var contexto = new BDEFEntities())
                {
                    return funcion(contexto);
                }
            }
            catch (Exception ex)
            {
                if (typeof(T) == typeof(string))
                    return (T)(object)$"Error: {ex.Message}";
                return default(T);
            }
        }
        //Crear
        protected (bool validacion, string mensaje) Crear<T>(T entidad)where T : class
        {
            if (entidad == null)
            {
                return (false, $"{typeof(T).Name} no puede ser nulo");
            }
            return EjecutarFuncion(bd =>
            {
                bd.Set<T>().Add(entidad);
                bd.SaveChanges();
                return (true,$"{typeof(T).Name} ha sido registrado");
            });
        }
        //Modificar
        protected (bool validacion, string mensaje) Modificar<T>(T b, object id) where T : class
        {
            if (b == null)
            {
                return (false,$"{typeof(T).Name} no puede ser nulo.");
            }
            return EjecutarFuncion(bd =>
            {
                var objeto = bd.Set<T>().Find(id);
                if (objeto == null)
                {
                    return (false, $"{typeof(T).Name} no ha sido encontrado");
                }
                bd.Entry(objeto).CurrentValues.SetValues(b);
                bd.SaveChanges();
                return (true, $"{typeof(T).Name} ha sido modificado");
            });
        }
        //Eliminar
        protected (bool validacion, string mensaje) Eliminar<T>(object id) where T : class
        {
            return EjecutarFuncion(bd =>
            {
                var objeto = bd.Set<T>().Find(id);
                if (objeto == null)
                {
                    return (false, $"{typeof(T).Name} no ha sido encontrado");
                }
                bd.Set<T>().Remove(objeto);
                bd.SaveChanges();
                return (true, $"{typeof(T).Name} ha sido eliminado");
            });
        }
        //Listar
        protected List<T>Listar<T>() where T : class
        {
            return EjecutarFuncion(bd =>
            {
                return bd.Set<T>().ToList();
            });
        }
    }
}
