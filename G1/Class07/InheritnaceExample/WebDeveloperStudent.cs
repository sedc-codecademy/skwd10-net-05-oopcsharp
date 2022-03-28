using System;
using System.Collections.Generic;
using System.Text;

namespace InheritnaceExample
{
    public class WebDeveloperStudent : Student
    {
        public string[] FavoriteLanguages { get; set; }

        public WebDeveloperStudent() { }

        public WebDeveloperStudent(string firstName, string lastName, string phoneNumber, string email, Subject[] subjects, string[] favoriteLanguages)
            : base(firstName, lastName, phoneNumber, email, subjects)
        {
            FavoriteLanguages = favoriteLanguages;
        }
    }
}
