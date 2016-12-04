using Ejercicio_3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ejercicio_3
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Persona> listado = new ObservableCollection<Persona>();
        private ListadoPersona lp = new ListadoPersona();

        public MainPageVM ViewModel { get; }
        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new MainPageVM();

            //Versión de Fernando
            //this.ViewModel = (MainPageVM)this.DataContext;

        }

        private void lista_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            ListView list = (ListView)sender;
            MiMenu.ShowAt(list, e.GetPosition(list));
            var a=((FrameworkElement)e.OriginalSource).DataContext;
        }
        /*
private void Save_Click(object sender, RoutedEventArgs e)
{
   this.txtNombre.GetBindingExpression(TextBox.TextProperty).UpdateSource();
   this.txtApellidos.GetBindingExpression(TextBox.TextProperty).UpdateSource();
   this.txtFechaNacimiento.GetBindingExpression(TextBox.TextProperty).UpdateSource();
   this.txtDiorección.GetBindingExpression(TextBox.TextProperty).UpdateSource();
   this.txtTeléfono.GetBindingExpression(TextBox.TextProperty).UpdateSource();
}*/
    }
}
