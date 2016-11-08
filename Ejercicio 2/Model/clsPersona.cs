using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Persona
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Display (Name="Fecha de Nacimiento")]
        public DateTime FechaNac { get; set; }

        public int id { get; set; }
        [Display (Name ="Teléfono")]
        public string telefono { get; set; }
        public string direccion { get; set; }

        public Persona(){
            id = 0;
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTime();
            direccion = "Mi casa";
            telefono = "teléeefono";
            }

        public Persona(int parId,string nombre, string apellidos, DateTime fechaNac,
            string direccion,string telefono)
        {
            this.id = parId;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }
    }
}
