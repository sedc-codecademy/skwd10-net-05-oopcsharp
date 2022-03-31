using CSharpBasic_G2_L9_EX1.Enums;
using CSharpBasic_G2_L9_EX1.Exceptions;

namespace CSharpBasic_G2_L9_EX1.Entities
{
    public class Movie
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Rating { get; set; }

        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if (rating > 5 || rating < 1)
            {
                throw new InvalidRatingException($"The rating {rating} for movie {title} has to be between 1 and 5");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }
    }
}
