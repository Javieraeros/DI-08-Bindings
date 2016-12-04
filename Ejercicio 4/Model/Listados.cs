using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.Model
{
    public class Listados
    {
        public ObservableCollection<Trilogia> devuelveTrilogia()
        {
            Personaje Han = new Personaje("Han", "Solo");
            Personaje Chew = new Personaje("Chew", "Baca");
            ObservableCollection<Personaje> primeraPersonaje = new ObservableCollection<Personaje>();
            primeraPersonaje.Add(Han);
            primeraPersonaje.Add(Chew);

            Personaje Luke = new Personaje("Luke", "Skywalker");
            Personaje Anakyn = new Personaje("Anakyn", "Skywalker");
            ObservableCollection<Personaje> segundaPersonaje = new ObservableCollection<Personaje>();
            primeraPersonaje.Add(Luke);
            primeraPersonaje.Add(Anakyn);

            Personaje Leia = new Personaje("Leia", "IDontKnow");
            Personaje Darth = new Personaje("Darth", "Vader");
            ObservableCollection<Personaje> terceraPersonaje = new ObservableCollection<Personaje>();
            primeraPersonaje.Add(Leia);
            primeraPersonaje.Add(Darth);


            Pelicula primera = new Pelicula("Primera",primeraPersonaje);
            Pelicula segunda = new Pelicula("Segunda", segundaPersonaje);
            Pelicula tercera = new Pelicula("Tercera", terceraPersonaje);
            ObservableCollection<Pelicula> listaTrilogiaUno = new ObservableCollection<Pelicula>();
            listaTrilogiaUno.Add(primera);
            listaTrilogiaUno.Add(segunda);
            listaTrilogiaUno.Add(tercera);

            Trilogia buena = new Trilogia("La buena",listaTrilogiaUno);


            ObservableCollection<Pelicula> listaTrilogiaDos = new ObservableCollection<Pelicula>();
            listaTrilogiaDos.Add(segunda);
            listaTrilogiaDos.Add(tercera);

            Trilogia mala = new Trilogia("La mala",listaTrilogiaDos);

            ObservableCollection<Trilogia> devolver = new ObservableCollection<Trilogia>();
            devolver.Add(buena);
            devolver.Add(mala);

            return devolver;
        }
    }
}
