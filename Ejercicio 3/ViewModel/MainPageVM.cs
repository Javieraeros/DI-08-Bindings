using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_3.Model.DAL;
using Ejercicio_3.Model.BL;
using Windows.Web.Http;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

namespace Ejercicio_3.ViewModel
{
    //TODO Falta crear uno nuevo
    public class MainPageVM : clsVMBase
    {
        #region "Atributos"
        private static Persona personaSeleccionada;
        private static ObservableCollection<Persona> listado;

        /* Esta copia no se modificará nunca, pues será donde guardemos todas las personas de la base de datos
         * Mientras que en el otro, solo guardaremos lo que estamos mostrando
         * 
         * El problema es que si hay una modificación en la BBDD el usuario no lo verá hasta que no reinicie
         * la app. 
         * Creo que lo mejor será crear un método qeu te devuelva el número de personas que hay en la BBDD
         * (Select count(*) from personas) y si ese número no coincide con listado.size, inicializar dicho listado.
         */
        private static ObservableCollection<Persona> listadoCopia;
        private string _textoABuscar;
        private string _textoABuscarActualizable;

        private DelegateCommand _eliminarCommand;

        private DelegateCommand _buscarCommand;
        private DelegateCommand _guardarCommand;
        private ManejadoraPersonaBL miMane;

        #endregion

        #region "Constructores"
        public MainPageVM()
        {
            recuperaListado();
            miMane = new ManejadoraPersonaBL();

            _eliminarCommand = new DelegateCommand(EliminarCommand_Execute, EliminarCommand_CanExecute);
            _buscarCommand = new DelegateCommand(BuscarCommand_Execute, BuscarCommand_CanExecute);
            _guardarCommand = new DelegateCommand(GuardarCommand_Execute, GuardarCommand_CanExecute);
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
                _guardarCommand.RaiseCanExecuteChanged();
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

        public DelegateCommand guardarCommand
        {
            get
            {
                return _guardarCommand;
            }
        }

        #endregion

        #region "Métodos"
        public async void eliminar()
        {
            await miMane.deletePersona(personaSeleccionada.id);
        }

        public async void recuperaListado()
        {
            ListadoPersonaBL miLista = new ListadoPersonaBL();
            listado =await miLista.getListado();
            //No pongo listadoCopia=listado; por si hace referencia
            //TODO Cambiar para que no vuelva a llmar
            listadoCopia =await miLista.getListado();
            NotifyPropertyChanged("Listado");
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

        private async void EliminarCommand_Execute()
        {
            HttpStatusCode resultado= await miMane.deletePersona(personaSeleccionada.id);
            if (resultado == HttpStatusCode.Accepted)
            {
                recuperaListado();
            }else
            {
                MessageDialog error = new MessageDialog("Error");
                recuperaListado();
            }
        }

        private bool GuardarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (personaSeleccionada == null)
            {
                sePuedeBorrar = false;
            }
            return sePuedeBorrar;
        }

        private async void GuardarCommand_Execute()
        {
            HttpStatusCode resultado = await miMane.putPersona(personaSeleccionada);
            if (resultado == HttpStatusCode.Accepted)
            {
                recuperaListado();
            }
            else
            {
                MessageDialog error = new MessageDialog("Error");
                recuperaListado();
            }
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
                recuperaListado();
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
                recuperaListado();
            }
        }
        #endregion
    }
}
