using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NConductor
    {
        private DConductor dConductor = new DConductor();
        public string Registro(Conductor a)
        {
            return dConductor.Registro(a);
        }
        public string Modificar(Conductor a)
        {
            return dConductor.Modificar(a);
        }
        public string Eliminar(int idConductor)
        {
            return dConductor.Eliminar(idConductor);
        }
        public List<Conductor> Listar()
        {
            return dConductor.Listar(); 
        }
        public Conductor ObtenerPorId(int idConductor)
        {
            return dConductor.ObtenerPorId(idConductor);
        }
        public List<Vehiculo> MostraVehiculos(int id)
        {
            return dConductor.MostraVehiculos(id);
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            return dConductor.MostrarBrevetes(id);
        }
    }
}
