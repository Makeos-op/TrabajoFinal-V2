using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();
        //Registro
        public string Registro(Vehiculo b)
        {
            return dVehiculo.Registro(b);
        }
        //Modificar
        public string Modificar(Vehiculo b)
        {
            return dVehiculo.Modificar(b);
        }
        //Eliminar
        public string Eliminar(int idVehiculo)
        {
            return dVehiculo.Eliminar(idVehiculo);
        }
        public Vehiculo BuscarPorMatricula(string matricula)
        {
            return dVehiculo.BuscarPorMatricula(matricula);
        }
    }
}
