using Ejercicio_3.Model.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Model.BL
{
    public class ListadoPersonaBL
    {
        ListadoPersona miListado = new ListadoPersona();

        public async Task<ObservableCollection<Persona>> getListado()
        {
            return await miListado.getListado();
        }
    }
}
