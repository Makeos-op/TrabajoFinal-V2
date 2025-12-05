using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class NBrevete
    {
        private DBrevete dBrevete = new DBrevete();
        //Registro
        public string Registro(Brevete b)
        {
            return dBrevete.Registro(b);
        }
        //Modificar
        public string Modificar(Brevete b)
        {
            return dBrevete.Modificar(b);
        }
        //Eliminar
        public string Eliminar(int idBrevete)
        {
            return dBrevete.Eliminar(idBrevete);
        }
    }
}
