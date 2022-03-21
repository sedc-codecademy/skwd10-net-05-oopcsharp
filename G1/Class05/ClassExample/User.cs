using System;
using System.Globalization;

namespace ClassExample
{
    internal class User
    {
        //Properties
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } //XX.XX.XXXX 12:00:00 AM
        public string Email { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public User(string firstName, string lastName, DateTime dateOfBirth, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }

        //Methods
        public string GetDetails()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("mk-MK");

            return $"{FirstName} {LastName} {DateOfBirth.ToString("dd MMMM yyyy", culture)}";
        }

        public bool IsAdult()
        {
            return DateOfBirth.AddYears(18) <= DateTime.Today; 
        }
    }
}
