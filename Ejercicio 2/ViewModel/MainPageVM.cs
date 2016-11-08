using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.ViewModel
{
    public class MainPageVM
    {
        private Persona personaSeleccionada;
        private ObservableCollection<Persona> listado;
        public MainPageVM()
        {
            this.personaSeleccionada = new Persona();
            this.listado = new ListadoPersona().Listado;
        }
        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                this.personaSeleccionada = value;
            }
        }

        public ObservableCollection<Persona> Listado
        {
            get
            {
                return listado;
            }
            set
            {
                listado = value;
            }
        }
    }
}
