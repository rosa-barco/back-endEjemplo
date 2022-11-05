
using BackendEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendEjemplo.Services
{
    public class PeliculaService

    {
        public List<pelicula> ObtenerPeliculas()
        {


            var pelicula1 = new pelicula()
            {
                Titulo = "Superman",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 11, 12)
            };
            var pelicula2 = new pelicula()
            {
                Titulo = "Superman",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 11, 12)
            };
            return new List<pelicula> { pelicula1, pelicula2 };
    }
    }
}