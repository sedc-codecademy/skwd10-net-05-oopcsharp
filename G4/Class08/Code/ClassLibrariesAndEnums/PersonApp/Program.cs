using System;
using Domain.Enums;
using Domain.Models;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Billsky", 30, DaysOfWeekEnum.Friday);
            Person kate = new Person("Kate", "Katesky", 25, DaysOfWeekEnum.Wednesday);
            Person bob = new Person("Bob", "Bobsky", 28, DaysOfWeekEnum.Friday);

            Person[] people = new Person[]
            {
                bill,
                kate,
                bob
            };

            Person[] foundPeople = FindPeopleBornOnFriday(people);

            Console.WriteLine("People born on Friday:");
            foreach (Person person in foundPeople)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        //gets an array as parameter, to search in that array
        //returns array of Person, that array contains Person objects where DayOFBirth == Friday
        static Person[] FindPeopleBornOnFriday(Person[] peopleArray)
        {
            Person[] peopleBornOnFriday = new Person[0];
            int index = 0;

            //bool existsBornOnFriday = false;

            foreach (Person person in peopleArray)
            {
                if (person.DayOfBirth == DaysOfWeekEnum.Friday)
                {
                    Array.Resize(ref peopleBornOnFriday, peopleBornOnFriday.Length + 1);
                    peopleBornOnFriday[index] = person;
                    //peopleBornOnFriday[peopleBornOnFriday.Length - 1] = person;
                    index++;

                    //existsBornOnFriday = true;
                    //break;
                }
            }

            //if (existsBornOnFriday)
            //{
            //    //code
            //}

            return peopleBornOnFriday;
        }
    }
}
