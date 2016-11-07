using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ejercicio_2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Persona> listado = new List<Persona>();
        public MainPage()
        {
            this.InitializeComponent();
            Persona Fernando = new Persona(0, "Fernando", "Galiana", new DateTime(1980, 12, 12), "Su casa", "Su teléfono");
            Persona Yo = new Persona(1, "Francisco Javier", "Ruiz", new DateTime(1992, 11, 19), "Mi casa", "Teléeeeefono");
            Persona Tu = new Persona(2, "Lector", "Intrépido", new DateTime(1935, 5, 4), "Tu casa", "Tu teléfono");
            Persona El = new Persona(3, "He", "Him", new DateTime(1937, 2, 27), "lacasadeel", "633212121");
            Persona Ella = new Persona(4, "She", "Her", new DateTime(1980, 12, 12), "lacasadeella", "633202020");

            listado.Add(Fernando); listado.Add(Yo);
            listado.Add(Tu); listado.Add(El);
            listado.Add(Ella);
            foreach(Persona p in listado)
            {
                lstPersonas.Items.Add(p.toString());
            }
        }
    }
}
