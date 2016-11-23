using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private static Persona personaSeleccionada;
        private static ObservableCollection<Persona> listado;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageVM()
        {
            listado = new ListadoPersona().getListado();
        }
        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                personaSeleccionada = value;
                onPropertyChanged("PersonaSeleccionada");
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

        protected void onPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void eliminar()
        {
            listado.Remove(personaSeleccionada);
        }

    }
    /// <summary>
    /// Aquí se harán todos los cambios que queremos de la clase persona, como por ejemplo
    /// validación o cambios en setters y getters
    /// </summary>
    /*public class MainPageVM : Persona,INotifyPropertyChanged
    {
        private ObservableCollection<Persona> listado;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageVM()
        {
            this.listado = new ListadoPersona().getListado();
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

        protected void onPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }*/
}
