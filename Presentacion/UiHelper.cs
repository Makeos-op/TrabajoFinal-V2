using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class UiHelper
    {
        public static void Mostrar<T>(DataGridView grid, List<T> lista)
        {
            grid.DataSource = null;

            if (lista == null || lista.Count == 0)
                return;

            grid.DataSource = lista;
        }
        public static void MensajesPOPUP()
        {
            //Recibir funcion de Negocio 
            //Formatearlo Apropiadamente (Error Icono de error, aprobado icono aprobado, etc.)
            //3 tipos de formato
        }
    }
}
