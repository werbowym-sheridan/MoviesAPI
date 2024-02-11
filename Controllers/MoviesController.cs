using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System.Collections.Generic;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "Inception", ReleaseYear = "2010", Duration = "148 min", Rating = 8.8 },
            new Movie { Title = "The Matrix", ReleaseYear = "1999", Duration = "136 min", Rating = 8.7 },
            new Movie { Title = "Interstellar", ReleaseYear = "2014", Duration = "169 min", Rating = 8.6 }
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // Add other necessary API methods here (POST, PUT, DELETE, etc.)
    }
}
