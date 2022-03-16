

using System;

namespace Classes.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private int _ssn { get; set; }

        //default constructor
        public Person()
        {
            _ssn = 555;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = GenerateSSN();
        }

        public string GetDescription()
        {
            return $"{FirstName} {LastName} is {Age} years old, with SSN: {_ssn}";
        }

        private int GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }
    }
}
