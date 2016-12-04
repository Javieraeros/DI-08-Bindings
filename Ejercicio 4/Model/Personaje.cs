using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.Model
{
    public class Personaje :INotifyPropertyChanged
    {
        #region Atributos
        public event PropertyChangedEventHandler PropertyChanged;

        private string nombre;

        private string apellido;

        #endregion

        #region Constructores

        public Personaje(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

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


        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
                onPropertyChanged(Apellido);
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
