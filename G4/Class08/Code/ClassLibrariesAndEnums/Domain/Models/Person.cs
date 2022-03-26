using System;
using Domain.Enums;

namespace Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public DaysOfWeekEnum DayOfBirth { get; set; }

        public Person()
        {
            DayOfBirth = DaysOfWeekEnum.Sunday;
        }

        public Person(string firstName, string lastName, int age, DaysOfWeekEnum day)
        {
            Id = new Random().Next(1, 9999);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DayOfBirth = day;
        }
        
    }
}
