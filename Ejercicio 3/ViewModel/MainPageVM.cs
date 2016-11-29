using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.ViewModel
{
    public class MainPageVM : clsVMBase
    {
        #region "Atributos"
        private static Persona personaSeleccionada;
        private static ObservableCollection<Persona> listado;
        //Esta copia no se modificará nunca, pues será donde guardemos todas las personas de la base de datos
        //Mientras que en el otro, solo guardaremos lo que estamos mostrando
        private static ObservableCollection<Persona> listadoCopia;
        private string _textoABuscar;
        private string _textoABuscarActualizable;

        private DelegateCommand _eliminarCommand;

        private DelegateCommand _buscarCommand;

        #endregion

        #region "Constructores"
        public MainPageVM()
        {
            listado = new ListadoPersona().getListado();
            //No pongo listadoCopia=listado; por si hace referencia
            listadoCopia = new ListadoPersona().getListado();
            _eliminarCommand = new DelegateCommand(EliminarCommand_Execute, EliminarCommand_CanExecute);
            _buscarCommand = new DelegateCommand(BuscarCommand_Execute, BuscarCommand_CanExecute);
        }

        #endregion

        #region "Propiedades"
        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                personaSeleccionada = value;
                _eliminarCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("PersonaSeleccionada");
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
                NotifyPropertyChanged("Listado");
            }
        }

        public string TextoABuscar
        {
            get{
                return _textoABuscar;
            }
            set
            {
                _textoABuscar = value;
            }
        }

        public string TextoABuscarActualizable
        {
            get
            {
                return _textoABuscarActualizable;
            }
            set
            {
                _textoABuscarActualizable = value;
                listaActualizable();
            }
        }

        #endregion

        #region "Métodos"
        public void eliminar()
        {
            listado.Remove(personaSeleccionada);
        }


        public DelegateCommand eliminarCommand
        {
            get
            {
                return _eliminarCommand;
            }
        }

        public DelegateCommand buscarCommand
        {
            get
            {
                return _buscarCommand;
            }
        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (personaSeleccionada == null)
            {
                sePuedeBorrar = false;
            }
            return sePuedeBorrar;
        }

        private void EliminarCommand_Execute()
        {
            listado.Remove(personaSeleccionada);
        }

        private bool BuscarCommand_CanExecute()
        {
            return true;
        }

        private void BuscarCommand_Execute()
        {
            if (!string.IsNullOrEmpty(_textoABuscar))
            {

                var _listaActualizada = from p in listadoCopia where p.Nombre.StartsWith(TextoABuscar) select p;
                Listado = new ObservableCollection<Persona>(_listaActualizada);
            }else
            {
                ListadoPersona listados = new ListadoPersona();
                Listado = listados.getListado();
            }
        }

        private void listaActualizable()
        {
            if (!string.IsNullOrEmpty(_textoABuscarActualizable))
            {

                var _listaActualizada = from p in listadoCopia where p.Nombre.StartsWith(TextoABuscarActualizable) select p;
                Listado = new ObservableCollection<Persona>(_listaActualizada);
            }
            else
            {
                ListadoPersona listados = new ListadoPersona();
                Listado = listados.getListado();
            }
        }
        #endregion
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
