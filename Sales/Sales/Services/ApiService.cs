

namespace Sales.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Plugin.Connectivity;
    using Sales.Common.Models;
    using Sales.Helpers;

    public class ApiService
    {

        public async Task<Response> CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = Languages.TurnOnInternet,
                };
            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");
            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = Languages.NoInternet,
                };
            }

            return new Response
            {
                IsSuccess = true,
            };
        }

        public async Task<Response> GetList<T>(string urlBase, string prefix, string controller)
        {
            try
            {
                //Nos sirve para crear la comunicacion
                var client = new HttpClient();

                //Cargar la direccion
                client.BaseAddress = new Uri(urlBase);

                //Concatenar el prefix y controller
                var url = $"{prefix}{controller}";

                //Realizar el requerimiento - Aqui realiza las comunicaciones
                var response = await client.GetAsync(url);

                //Regresa un objeto en memoria, debo leer esto como un string

                //Answer es un string Json. debemos convertirlo o desserializarlo
                var answer = await response.Content.ReadAsStringAsync();


                //No sabemos que llega, entonces debemos verificarlo

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = answer,
                    };
                }


                //Si llega hasta este punto quiere decir que funciono, pero aun esta como cadena Json, tenemos que deserializar, para que quede tipo objeto
                var list = JsonConvert.DeserializeObject<List<T>>(answer);


                //Retornamos la respues con el objeta ya listo que esta deserealizado
                return new Response
                {
                    IsSuccess = true,
                    Result = list,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
