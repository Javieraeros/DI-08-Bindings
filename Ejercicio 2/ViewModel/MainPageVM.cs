﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private Persona personaSeleccionada;
        private ObservableCollection<Persona> listado;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageVM()
        {
            this.listado = new ListadoPersona().getListado();
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

    }
}
