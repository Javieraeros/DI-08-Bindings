using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ejercicio_1
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void txtOrigen_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            /*
            if (char.IsControl((char) e.Key) || char.IsDigit((char) e.Key)
                || e.Key == VirtualKey.NumberPad0 || e.Key == VirtualKey.NumberPad1
                || e.Key == VirtualKey.NumberPad2 || e.Key == VirtualKey.NumberPad3
                || e.Key == VirtualKey.NumberPad4 || e.Key == VirtualKey.NumberPad5
                || e.Key == VirtualKey.NumberPad6 || e.Key == VirtualKey.NumberPad7
                || e.Key == VirtualKey.NumberPad8 || e.Key == VirtualKey.NumberPad9)
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }*/
            //Falla con ciertos carácteres
            if (Regex.IsMatch(e.Key.ToString(),"[0-9]")){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
    }
}
