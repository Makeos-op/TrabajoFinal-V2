using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class NEspacio
    {
        private DEspacio dEspacio = new DEspacio();
        //Registro
        public string Registro(Espacio b)
        {
            return dEspacio.Registro(b);
        }
        //Modificar
        public string Modificar(Espacio b)
        {
            return dEspacio.Modificar(b);
        }
        //Eliminar
        public string Eliminar(int idEspacio)
        {
            return dEspacio.Eliminar(idEspacio);
        }
        public Espacio BuscarEspacioPorId(int Id)
        {
            return dEspacio.BuscarEspacioPorId(Id);
        }
    }
}
