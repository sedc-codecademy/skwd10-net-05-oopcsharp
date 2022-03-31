using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Models
{
    internal class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        //public int TicketPrice => 5 * Rating;
        //private int TicketPrice { get; set; }
        public int TicketPrice { get; private set; }

        public Movie(string title, Genre genre, int rating)
        {
            if (title == null || title == string.Empty)
                throw new ArgumentNullException("Title is required");

            if(rating < 1 || rating > 5)
                throw new ArgumentException("Rating should be between 1 - 5");

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = Rating * 5;
        }

        //public int GetTicketPrice()
        //{
        //    return TicketPrice;
        //}
    }
}
