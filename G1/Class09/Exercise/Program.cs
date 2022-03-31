using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Movie movie0 = new Movie("Test", Genre.Drama, 9);
                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
                List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
                List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

                List<Movie> AllMovies = new List<Movie>();
                AllMovies.AddRange(MovieSet1);
                AllMovies.AddRange(MovieSet2);

                Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
                Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);

                //UI
                Console.WriteLine("Choose cinema:");
                Console.WriteLine($"1. {cinema1.Name}");
                Console.WriteLine($"2. {cinema2.Name}");

                string input = Console.ReadLine();
                Cinema choosenCinema = null;

                switch (input)
                {
                    case "1":
                        choosenCinema = cinema1;
                        break;
                    case "2":
                        choosenCinema = cinema2;
                        break;
                    default:
                        throw new Exception("Invalid cinema");
                }

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. All movies");
                Console.WriteLine("2. Movies by genre");

                string inputOption = Console.ReadLine();
                if (inputOption == "1")
                {
                    Console.WriteLine("List of all movies");
                    foreach (Movie m in choosenCinema.Movies)
                    {
                        Console.WriteLine($"{m.Title} [{m.Genre}] ({m.Rating}) ({m.TicketPrice})");
                    }
                    Console.WriteLine("Choose a movie that you want to watch");
                    string choosenMovie = Console.ReadLine();

                    Movie movie = AllMovies.FirstOrDefault(m => m.Title.ToLower() == choosenMovie.ToLower());
                    string result = choosenCinema.MoviePlaying(movie);
                    Console.WriteLine(result);
                }
                else if (inputOption == "2")
                {
                    Console.WriteLine("Please choose a genre");
                    Console.WriteLine($"1. {Genre.Comedy}");
                    Console.WriteLine($"2. {Genre.Horror}");
                    Console.WriteLine($"3. {Genre.Action}");
                    Console.WriteLine($"4. {Genre.Drama}");
                    Console.WriteLine($"5. {Genre.SciFi}");

                    string inputChoosenGenre = Console.ReadLine();

                    if(!int.TryParse(inputChoosenGenre, out int intChoosenGenre))
                    {
                        throw new Exception("Invalid input of a genre");
                    }

                    if(intChoosenGenre < 1 || intChoosenGenre > 5)
                    {
                        throw new Exception("Invalid Genre selected");
                    }

                    Genre choosenGenre = (Genre)intChoosenGenre;

                    foreach (Movie m in choosenCinema.Movies.Where(m => m.Genre == choosenGenre).ToList())
                    {
                        Console.WriteLine($"{m.Title} [{m.Genre}] ({m.Rating}) ({m.TicketPrice})");
                    }

                    Console.WriteLine("Choose a movie that you want to watch");
                    string choosenMovie = Console.ReadLine();

                    Movie movie = AllMovies.FirstOrDefault(m => m.Title.ToLower() == choosenMovie.ToLower());
                    string result = choosenCinema.MoviePlaying(movie);
                    Console.WriteLine(result);
                }
                else
                {
                    throw new Exception("Invalid input of the choosen option.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NullReferenceException: Error happend please contact administrator");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: error happend");
            } finally
            {
                Console.WriteLine("Thank you for visiting our app");
            }
        }
    }
}
