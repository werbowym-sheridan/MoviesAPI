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
            new Movie { Title = "Interstellar", ReleaseYear = "2014", Duration = "169 min", Rating = 8.6 },
            new Movie { Title = "The Shawshank Redemption", ReleaseYear = "1994", Duration = "142 min", Rating = 9.3 },
            new Movie { Title = "The Godfather", ReleaseYear = "1972", Duration = "175 min", Rating = 9.2 },
            new Movie { Title = "The Dark Knight", ReleaseYear = "2008", Duration = "152 min", Rating = 9.0 },
            new Movie { Title = "Pulp Fiction", ReleaseYear = "1994", Duration = "154 min", Rating = 8.9 },
            new Movie { Title = "School of Rock", ReleaseYear = "2003", Duration = "109 min", Rating = 7.2 }

        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // Add other necessary API methods here (POST, PUT, DELETE, etc.)
    }
}
