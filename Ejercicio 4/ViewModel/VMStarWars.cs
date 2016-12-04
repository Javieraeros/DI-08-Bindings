using Ejercicio_4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.ViewModel
{
    public class VMStarWars
    {
        #region Atributos
        private ObservableCollection<Trilogia> trilogias;
        private Trilogia trilogiaSeleccionada;

        private ObservableCollection<Pelicula> peliculas;
        private Pelicula peliculaSeleccionada;

        private ObservableCollection<Personaje> personajes;
        private Pelicula personajeSeleccionado;

        #endregion

        #region Constructores
        public VMStarWars()
        {
            Listados recuperar = new Listados();
            trilogias = recuperar.devuelveTrilogia();
        }
        #endregion

        #region Propiedades
        public Pelicula PersonajeSeleccionado
        {
            get
            {
                return personajeSeleccionado;
            }

            set
            {
                personajeSeleccionado = value;
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
    }
    #endregion
}
