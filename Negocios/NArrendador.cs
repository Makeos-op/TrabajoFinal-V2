using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class NArrendador
    {
        private DArrendador dArrendador = new DArrendador();
        public string Registro(Arrendador a)
        {
            return dArrendador.Registro(a);
        }
        public string Modificar(Arrendador a)
        {
            return dArrendador.Modificar(a);
        }
        public string Eliminar(int idArrendador)
        {
            return dArrendador.Eliminar(idArrendador);
        }
        public List<Arrendador> Listar()
        {
            return dArrendador.Listar();
        }
        public Arrendador ObtenerPorId(int idArrendador)
        {
            return dArrendador.ObtenerPorId(idArrendador);
        }
        public List<Espacio> MostrarEspaciosPorArrendador(int idArrendador)
        {
            return dArrendador.MostrarEspaciosPorArrendador(idArrendador);
        }
    }
}
