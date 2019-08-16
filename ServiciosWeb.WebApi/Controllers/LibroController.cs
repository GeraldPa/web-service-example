using ServiciosWeb.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class LibroController : ApiController
    {
        Libreria3Connection DB = new Libreria3Connection();

        /// <summary>
        /// Permite consultar la informacion de todos los libros
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            var listado = DB.Libro.ToList();

            return listado;
        }

        [HttpGet]
        public Libro Get(int id)
        {
            var libro = DB.Libro.FirstOrDefault(x => x.idLibro == id);

            return libro;
        }

        [HttpPost]
        public bool Post(Libro libro)
        {
            DB.Libro.Add(libro);
            return DB.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Libro libro)
        {
            var libroActualizar = DB.Libro.FirstOrDefault( x => x.idLibro == libro.idLibro );
            libroActualizar.Titulo = libro.Titulo;
            libroActualizar.Sinopsis = libro.Sinopsis;
            libroActualizar.Autor = libro.Autor;
            libroActualizar.Editorial = libro.Editorial;
            libroActualizar.Idioma = libro.Idioma;
            libroActualizar.Formato = libro.Formato;
            libroActualizar.Genero = libro.Genero;
            libroActualizar.Disponible = libro.Disponible;

            DB.Entry(libroActualizar).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var libroEliminar = DB.Libro.FirstOrDefault(x => x.idLibro == id);
            DB.Libro.Remove(libroEliminar);

            return DB.SaveChanges() > 0;
        }
    }
}
