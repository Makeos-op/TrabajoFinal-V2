using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class NReserva
    {
        private DReserva dReserva = new DReserva();
        //Registro
        public string Registro(Reserva r)
        {
            return dReserva.Registro(r);
        }
        //Modificar
        public string Modificar(Reserva r)
        {
            return dReserva.Modificar(r);
        }
        //Eliminar
        public string Eliminar(int idReserva)
        {
            return dReserva.Eliminar(idReserva);
        }
    }
}
