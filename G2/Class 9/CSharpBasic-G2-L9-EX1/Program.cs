using CSharpBasic_G2_L9_EX1.Entities;
using CSharpBasic_G2_L9_EX1.Enums;
using CSharpBasic_G2_L9_EX1.Exceptions;
using System;
using System.Collections.Generic;

namespace CSharpBasic_G2_L9_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cineplexx = new Cinema("Cineplexx", new List<string>() { "Hall 7", "Hall 3", "Hall 4" },
                              new List<Movie>() { });
            TryCatch(cineplexx);
        }

        static void TryCatch(Cinema cinema)
        {
            try
            {
                cinema.Movies = new List<Movie>() {
                    new Movie("Batman", Genre.Action, 7),
                    new Movie("Lost City", Genre.Action, 5),
                    new Movie("Morbius", Genre.Comedy, 3)
                };

                Movie movie = cinema.Movies[0];
            }
            catch (InvalidRatingException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
