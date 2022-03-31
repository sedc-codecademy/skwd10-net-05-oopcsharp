using CSharpBasic_G2_L8_E2.Enums;
using System;
using System.Collections.Generic;

namespace CSharpBasic_G2_L8_E2.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; } = new List<Song>();

        public Person(int id, string firstName, string lastName, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs ?? new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is a boring person because he has no favorite music");
            }
        }
    }
}
