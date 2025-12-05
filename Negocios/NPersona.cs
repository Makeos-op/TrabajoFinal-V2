using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NPersona
    {
        private DPersona dPersona = new DPersona();
        public string Registro(BDEFEntities bd, Persona u)
        {
            return dPersona.Registro(bd, u);
        }
        public string Modificar(BDEFEntities bd, Persona u)
        {
            return dPersona.Modificar(bd, u);
        }
        public string Eliminar(BDEFEntities bd, int IdPersona)
        {
            return dPersona.Eliminar(bd, IdPersona);
        }
        public bool Validacion(string correo, string contrasena)
        {
            return dPersona.Validacion(correo, contrasena);
        }
        public Persona ObtenerPersona(string correo, string contrasena)
        {
            return dPersona.ObtenerPersona(correo, contrasena);
        }
    }
}
