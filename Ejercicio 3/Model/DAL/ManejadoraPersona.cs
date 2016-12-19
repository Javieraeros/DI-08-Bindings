using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace Ejercicio_3.Model.DAL
{
    public class ManejadoraPersona
    {
        Conexion miCone = new Conexion();
        HttpClient miHTTPClient = new HttpClient();

        //TODO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> deletePersona(int id)
        {
            HttpStatusCode miStatuscode = new HttpStatusCode();

            try
            {
                await miHTTPClient.DeleteAsync(new Uri(miCone.laUri+"/"+id));
                miStatuscode = HttpStatusCode.Accepted;
                miHTTPClient.Dispose();
            }
            catch (Exception)
            {

                miStatuscode= HttpStatusCode.BadRequest;
            }

            return miStatuscode;
        }

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
        public async Task<HttpStatusCode> postPersona(Persona p)
        {
            HttpStatusCode miStatuscode = new HttpStatusCode();
            String body = "";
            HttpStringContent contenido;
            try
            {
                body = JsonConvert.SerializeObject(p);
                contenido = new HttpStringContent(body,Windows.Storage.Streams.UnicodeEncoding.Utf8,"application/json");
                await miHTTPClient.PostAsync(new Uri(miCone.laUri),);
                miStatuscode = HttpStatusCode.Accepted;
                miHTTPClient.Dispose();
            }
            catch (Exception)
            {

                miStatuscode = HttpStatusCode.BadRequest;
            }

            return miStatuscode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Task<HttpStatusCode> putPersona(Persona p)
        {

        }

    }
}
