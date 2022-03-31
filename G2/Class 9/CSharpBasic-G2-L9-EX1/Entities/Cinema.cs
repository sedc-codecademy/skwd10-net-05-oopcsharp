using System;
using System.Collections.Generic;

namespace CSharpBasic_G2_L9_EX1.Entities
{
    public class Cinema
    {
        public string Name { get; set; }

        public List<string> Halls { get; set; }

        public List<Movie> Movies { get; set; }

        public Cinema(string name, List<string> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
