using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.Model
{
    public class Trilogia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string nombre;

        private ObservableCollection<Pelicula> peliculas;

        public Trilogia(string nombre, ObservableCollection<Pelicula> peliculas)
        {
            this.nombre = nombre;
            this.peliculas = peliculas;
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

        public ObservableCollection<Pelicula> Peliculas
        {
            get
            {
                return peliculas;
            }

            set
            {
                peliculas = value;
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
