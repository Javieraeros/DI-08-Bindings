using Ejercicio_4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.ViewModel
{
    public class VMStarWars:VMBase
    {
        #region Atributos
        private ObservableCollection<Trilogia> trilogias;
        private Trilogia trilogiaSeleccionada;

        private ObservableCollection<Pelicula> peliculas;
        private Pelicula peliculaSeleccionada;

        private ObservableCollection<Personaje> personajes;
        private Personaje personajeSeleccionado;

        #endregion

        #region Constructores
        public VMStarWars()
        {
            Listados recuperar = new Listados();
            trilogias = recuperar.devuelveTrilogia();

        }
        #endregion

        #region Propiedades
        public Personaje PersonajeSeleccionado
        {
            get
            {
                return personajeSeleccionado;
            }

            set
            {
                personajeSeleccionado = value;
                NotifyPropertyChanged("PersonajeSeleccionado");
            }
        }

        public Pelicula PeliculaSeleccionada
        {
            get
            {
                return peliculaSeleccionada;
            }

            set
            {
                peliculaSeleccionada = value;
                personajes = peliculaSeleccionada.Personajes;
                NotifyPropertyChanged("Personajes");
            }
        }

        public Trilogia TrilogiaSeleccionada
        {
            get
            {
                return trilogiaSeleccionada;
            }

            set
            {
                trilogiaSeleccionada = value;
                peliculas = trilogiaSeleccionada.Peliculas;

                //Importanet llamar a la propiedad pública que es la que notifica el cambio a la vista!!
                Personajes = null; //Necesario por si cambiamos entre trilogías no se mantengan los personajes!
                NotifyPropertyChanged("Peliculas");
            }
        }

        public ObservableCollection<Trilogia> Trilogias
        {
            get
            {
                return trilogias;
            }

            set
            {
                trilogias = value;
                NotifyPropertyChanged("Trilogias");
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
                NotifyPropertyChanged("Peliculas");
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
                NotifyPropertyChanged("Personajes");
            }
        }
    }
    #endregion
}
