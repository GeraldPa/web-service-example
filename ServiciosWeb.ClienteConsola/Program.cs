using ServiciosWeb.ClienteConsola.ServiceLibroASMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServiciosWeb.ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Invocar Servicio ASMX
            //ServicioLibroSoapClient cliente = new ServicioLibroSoapClient();           
            //var libros =  cliente.ObtenerLibros();

            //// Invocar servicio WCF
            //ServiceLibroWCF.ServicioLibroClient clienteWCF = new ServiceLibroWCF.ServicioLibroClient();
            //var libros2 = clienteWCF.ObtenerLibros();

            // Invocar servicio REST
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:3757/");

            var request = clienteHttp.GetAsync("api/Libro").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;

                var listado = JsonConvert.DeserializeObject<List<Libro>>(resultString);

                foreach (var item in listado)
                {
                    Console.WriteLine(item.idLibro);
                    Console.WriteLine(item.Titulo);
                    Console.WriteLine(item.Sinopsis);
                    Console.WriteLine(item.Autor);
                    Console.WriteLine(item.Editorial);
                    Console.WriteLine(item.Idioma);
                    Console.WriteLine(item.Formato);
                    Console.WriteLine(item.Genero);
                    Console.WriteLine(item.Disponible);
                }

                Console.ReadLine();

            }

            //clienteHttp.PostAsync();
            //clienteHttp.PutAsync();
            //clienteHttp.DeleteAsync();

        }
    }
}
