using System;
using System.Collections.Generic;
using System.Text;

namespace InheritnaceExample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public virtual string GetInfo()
        {
            return $"{FullName} [tel: {PhoneNumber}] - [email: {Email}]";
        }
    }
}
