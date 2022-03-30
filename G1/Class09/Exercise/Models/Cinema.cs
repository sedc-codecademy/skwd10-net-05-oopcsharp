using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise.Models
{
    internal class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception("Name is requried");

            if (halls == null || halls.Count == 0)
                throw new Exception("Halls is requried");

            if (movies == null || movies.Count == 0)
                throw new Exception("Movies is requried");

            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public string MoviePlaying(Movie movie)
        {
            if (Movies.All(m => m.Title.ToLower() != movie.Title.ToLower()))
            {
                throw new ArgumentException($"The movie {movie.Title} is not playing in {Name}");
            }

            return $"Watching {movie.Title}";

            //if (!Movies.Any(m => m.Title.ToLower() == movie.Title.ToLower()))
            //{
            //    throw new ArgumentException($"The movie {movie.Title} is not playing in {Name}");
            //}

            //return $"Watching {movie.Title}";

            //if (Movies.Any(m => m.Title.ToLower() == movie.Title.ToLower()))
            //{
            //    return $"Watching {movie.Title}";                
            //}

            //throw new ArgumentException($"The movie {movie.Title} is not playing in {Name}");
        }
    }
}
