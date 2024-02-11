using System;

namespace MoviesAPI.Models
{
    public class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public required string ReleaseYear { get; set; }
        public required string Duration { get; set; }
        public double Rating { get; set; }
    }
}
