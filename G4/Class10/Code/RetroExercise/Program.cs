using System;
using System.Collections.Generic;
using System.Linq;
using RetroExercise.Domain;

namespace RetroExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jerry = new Person(1, "Jerry", "Jersky", 33, GenreEnum.HipHop);
            Person bob = new Person(2, "Bob", "Bobsky", 23, GenreEnum.Classical);
            Person kate = new Person(3, "Kate", "Bobsky", 27, GenreEnum.Rock);
            Person bill = new Person(4, "Bill", "Billsky", 27, GenreEnum.Techno);

            List<Person> fans = new List<Person>
            {
                jerry,
                bob,
                kate,
                bill
            };

            //example with array property
            jerry.FavoriteSongsArray = new Song[5];
            jerry.FavoriteSongsArray[0] = new Song("test", 10, GenreEnum.Rock);


            Song[] songsArray = jerry.FavoriteSongsArray;
            Array.Resize(ref songsArray, 5);

            Song song1 = new Song("Bohemian Rhapsody", 367, GenreEnum.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, GenreEnum.Rock);
            Song song3 = new Song("Riders On The Storm", 430, GenreEnum.Rock);
            Song song4 = new Song("Not Fade Away", 108, GenreEnum.Rock);
            Song song5 = new Song("Breaking Glass", 111, GenreEnum.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, GenreEnum.Rock);
            Song song7 = new Song("Walk Of Life", 266, GenreEnum.Rock);
            Song song8 = new Song("Smoke on the Water", 340, GenreEnum.Rock);
            Song song9 = new Song("93 'til Infinity", 209, GenreEnum.Techno);
            Song song10 = new Song("Fight the Power", 321, GenreEnum.Techno);
            Song song11 = new Song("The Message", 363, GenreEnum.Techno);
            Song song12 = new Song("Butterfly Effect", 213, GenreEnum.Techno);
            Song song13 = new Song("No Fear", 182, GenreEnum.Techno);
            Song song14 = new Song("Hereditary", 340, GenreEnum.Techno);
            Song song15 = new Song("Bounce Back", 226, GenreEnum.Techno);
            Song song16 = new Song("The Four Seasons", 2520, GenreEnum.Classical);
            Song song17 = new Song("Canon in D major", 376, GenreEnum.Classical);
            Song song18 = new Song("Swan Lake", 461, GenreEnum.Classical);
            Song song19 = new Song("Symphony No. 5", 425, GenreEnum.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, GenreEnum.Classical);
            Song song21 = new Song("The Magic Flute", 458, GenreEnum.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, GenreEnum.Classical);
            Song song23 = new Song("Planet E", 420, GenreEnum.Techno);
            Song song24 = new Song("Phasor", 368, GenreEnum.Techno);
            Song song25 = new Song("Counting Comets", 242, GenreEnum.Techno);
            Song song26 = new Song("Cold Summer", 358, GenreEnum.Techno);
            Song song27 = new Song("Destroyer", 359, GenreEnum.Techno);
            Song song28 = new Song("Phalanx", 307, GenreEnum.Techno);
            Song song29 = new Song("Vision", 693, GenreEnum.Techno);
            Song song30 = new Song("Chain Reaction", 181, GenreEnum.Techno);

            List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                                song8, song9, song10, song11, song12, song13, song14,
                                                song15, song16, song17, song18, song19, song20,
                                                song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

            //first requirement
            fans.First(x => x.FirstName.ToLower() == "Jerry".ToLower())
                .FavoriteSongs = songs.Where(x => x.Title.StartsWith("B")).ToList();

            foreach (Song song in jerry.FavoriteSongs)
            {
                
            }
            Console.WriteLine("==========Jerry:==============");

            jerry.PrintFavSongs();

            //second requirement
            fans.First(x => x.FirstName.Equals("Bob", StringComparison.InvariantCultureIgnoreCase))
                .FavoriteSongs = songs.Where(x => x.Length > 360).ToList();

            Console.WriteLine("==========Bob:==============");
            fans.First(x => x.FirstName.Equals("Bob", StringComparison.InvariantCultureIgnoreCase)).PrintFavSongs();
            bob.PrintFavSongs();

            //third requirement
            fans.First(x => x.FirstName.Equals("Kate", StringComparison.InvariantCultureIgnoreCase))
                .FavoriteSongs = songs.Where(s => s.Genre == GenreEnum.Rock).ToList();
            Console.WriteLine("==========Kate:==============");
            kate.PrintFavSongs();

            //fourth requirement
            //empty list, because no object fulfills the condition
            bill.FavoriteSongs = songs.Where(s => s.Length < 180 && s.Genre == GenreEnum.HipHop).ToList();
            Console.WriteLine("==========Bill:==============");
            bill.PrintFavSongs();

            List<Person> fansWithLessThanFoursSongs = fans.Where(f => f.FavoriteSongs.Count > 4).ToList();
            foreach (Person person in fansWithLessThanFoursSongs)
            {
                Console.WriteLine($"{person.FirstName}");
            }

            //COUNT
            int countRock = songs.Count(s => s.Genre == GenreEnum.Rock);
            int countHipHop = songs.Count(s => s.Genre == GenreEnum.HipHop);

        }
    }
}
