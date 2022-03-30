using CSharpBasic_G2_L8_E2.Entities;
using CSharpBasic_G2_L8_E2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasic_G2_L8_E2
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Song> songList = new List<Song>()
            //                            {
            //                                new Song("Notorious", 2, Genre.Hip_Hop),
            //                                new Song("Zoshto?", 4, Genre.Hip_Hop),
            //                                new Song("Check tha rhyme", 3, Genre.Hip_Hop),
            //                                new Song("Stairway to Heaven", 3, Genre.Rock),
            //                                new Song("Chop Suey", 3, Genre.Rock),
            //                                new Song("Hard Rock Halleluyah!", 3, Genre.Rock),
            //                                new Song("Traffic", 3, Genre.Techno),
            //                                new Song("God is a DJ", 3, Genre.Techno),
            //                            };

            //List<string> songsList = songList.Where(song => song.Genre == Genre.Hip_Hop)
            //                                 .Select(song => song.Title)
            //                                 .ToList();


            Person person = new Person(1, "Mihajlo", "Dimovski", Genre.Hip_Hop,
                                        new List<Song>() {
                                            new Song("Notorious", 2, Genre.Hip_Hop),
                                            new Song("Zoshto?", 4, Genre.Hip_Hop),
                                            new Song("Check tha rhyme", 3, Genre.Hip_Hop)
                                        });

            person.GetFavSongs();

            Person personTwo = new Person(2, "Mihajlo", "Dimovski", Genre.Hip_Hop,
                            new List<Song>()
                            {

                            });
            personTwo.GetFavSongs();
        }
    }
}
