using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Ejercicio_3
{
    /// <summary>
    /// Clase de utilidades de prueba, no se debe usar así
    /// </summary>
    public class ListadoPersona
    {
     
        public ObservableCollection<Persona> getListado()
        {
            ObservableCollection<Persona> listado = new ObservableCollection<Persona>();
            Persona Fernando = new Persona(0, "Fernando", "Galiana", new DateTime(1980, 12, 12), "Su casa", "Su teléfono");
            Persona Yo = new Persona(1, "Francisco Javier", "Ruiz", new DateTime(1992, 11, 19), "Mi casa", "Teléeeeefono");
            Persona Tu = new Persona(2, "Lector", "Intrépido", new DateTime(1935, 5, 4), "Tu casa", "Tu teléfono");
            Persona El = new Persona(3, "He", "Him", new DateTime(1937, 2, 27), "lacasadeel", "633212121");
            Persona Ella = new Persona(4, "She", "Her", new DateTime(1980, 12, 12), "lacasadeella", "633202020");

            listado.Add(Fernando); listado.Add(Yo);
            listado.Add(Tu); listado.Add(El);
            listado.Add(Ella);
            return listado;
        }
    }
}