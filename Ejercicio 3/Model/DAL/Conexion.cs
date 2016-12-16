using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Model.DAL
{
    public class Conexion
    {
        public Uri laUri { get; set; }

        public Conexion()
        {
            laUri =new Uri( "http://wpfsampleapi.azurewebsites.net/api/persona");
        }
    }
}
