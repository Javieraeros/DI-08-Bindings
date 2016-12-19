using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace Ejercicio_3.Model.BL
{
    public class ManejadoraPersonaBL
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Task<Persona> getPersona(int id)
        {
            //ToDo
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Task<HttpStatusCode> postPersona(Persona p)
        {
            //ToDo
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Task<HttpStatusCode> putPersona(Persona p)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<HttpStatusCode> deletePersona(int id)
        {

        }
    }
}
