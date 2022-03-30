using CSharpBasic_G2_L8_E2.Enums;

namespace CSharpBasic_G2_L8_E2.Entities
{
    public class Song
    {
        public string Title { get; set; }

        public int Duration { get; set; }

        public Genre Genre { get; set; }

        public Song(string title, int duration, Genre genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }
    }
}
