using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class AccesoBD
    {
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
    }
}
