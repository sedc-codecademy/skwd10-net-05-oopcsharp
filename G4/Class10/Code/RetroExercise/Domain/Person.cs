using System;
using System.Collections.Generic;

namespace RetroExercise.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }

        //default value null
        public List<Song> FavoriteSongs { get; set; }
        public Song[] FavoriteSongsArray { get; set; }

        public Person(int id, string firstName, string lastName, int age, GenreEnum favoriteMusicType)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;

            //protects from potential null reference exception
            FavoriteSongs = new List<Song>();
            FavoriteSongsArray = new Song[0];
        }

        public void PrintFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} {LastName} hates music and has no favorite songs!");
            }
            else
            {
                //Because FavoriteSongs is a collection (List), we use foreach
                Console.WriteLine($"{FirstName} {LastName}'s favorite songs:");
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
