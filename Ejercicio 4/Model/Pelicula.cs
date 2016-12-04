using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.Model
{
    public class Pelicula:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string nombre;
        private ObservableCollection<Personaje> personajes;

        public Pelicula(string nombre, ObservableCollection<Personaje> actores)
        {
            this.nombre = nombre;
            this.personajes = actores;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                onPropertyChanged(Nombre);
            }
        }

        public ObservableCollection<Personaje> Personajes
        {
            get
            {
                return personajes;
            }

            set
            {
                personajes = value;
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

    }
}
