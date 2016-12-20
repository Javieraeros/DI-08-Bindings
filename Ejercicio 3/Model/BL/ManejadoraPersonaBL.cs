using Ejercicio_3.Model.DAL;
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
        ManejadoraPersona miMane = new ManejadoraPersona();

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public async Task<Persona> getPersona(int id)
        {
            return await miMane.getPersona(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> postPersona(Persona p)
        {
            return await miMane.postPersona(p);
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> putPersona(Persona p)
        {
            return await miMane.putPersona(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> deletePersona(int id)
        {
            return await miMane.deletePersona(id);
        }
    }
}
