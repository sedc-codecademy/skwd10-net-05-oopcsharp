using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }
        public Movie(string title, Genre genre, int rating)
        {
            if(rating < 1 || rating > 5)
            {
                throw new Exception("Rating muset be between 1 and 5");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("You must enter a title");
            }

            // if exception is not throw
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }
    }
}
