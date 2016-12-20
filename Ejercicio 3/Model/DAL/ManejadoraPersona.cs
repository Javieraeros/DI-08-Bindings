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

        //TODO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> deletePersona(int id)
        {
            HttpClient miHTTPClient = new HttpClient();
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
        public async Task<Persona> getPersona(int id)
        {
            Persona persona;
            HttpClient miHTTPClient = new HttpClient();
            try
            {
                string respuesta = await miHTTPClient.GetStringAsync(miCone.laUri);
                miHTTPClient.Dispose();
                persona = JsonConvert.DeserializeObject<Persona>(respuesta);
            }
            catch (Exception)
            {
                //TODO
                throw;
            }
            return persona;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> postPersona(Persona p)
        {
            HttpClient miHTTPClient = new HttpClient();
            HttpStatusCode miStatuscode = new HttpStatusCode();
            String body = "";
            HttpStringContent contenido;
            try
            {
                body = JsonConvert.SerializeObject(p);
                contenido = new HttpStringContent(body,Windows.Storage.Streams.UnicodeEncoding.Utf8,"application/json");
                await miHTTPClient.PostAsync(miCone.laUri,contenido);
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
        public async Task<HttpStatusCode> putPersona(Persona p)
        {
            HttpClient miHTTPClient = new HttpClient();
            HttpStatusCode miStatuscode = new HttpStatusCode();
            String body = "";
            HttpStringContent contenido;
            try
            {
                body = JsonConvert.SerializeObject(p);
                contenido = new HttpStringContent(body, Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json");
                await miHTTPClient.PutAsync(new Uri(miCone.laUri+"/"+p.id), contenido);
                miStatuscode = HttpStatusCode.Accepted;
                miHTTPClient.Dispose();
            }
            catch (Exception)
            {

                miStatuscode = HttpStatusCode.BadRequest;
            }

            return miStatuscode;
        }

    }
}
