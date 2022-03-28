using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

            //All dogs whose name is longer than 3 characters
            List<Dog> dogsWithNameLongerThanThree = dogs.Where(d => d.Name.Length > 3).ToList();
            Console.WriteLine("Name longer than 3 characters:");
            foreach (Dog dog in dogsWithNameLongerThanThree)
            {
                Console.WriteLine(dog.Name);
            }

            Console.WriteLine(dogs.Count);
            Console.WriteLine(dogsWithNameLongerThanThree.Count);

            //All dogs whose name starts with "B" and whose age is 1
            //1.
            List<Dog> dogsAgedOne = dogs.Where(d => d.Name.StartsWith('B')) //All dogs whose name starts with "B"
                .Where(d => d.Age == 1).ToList();
            Console.WriteLine("dogsAgedOne:");
            foreach (Dog dog in dogsAgedOne)
            {
                Console.WriteLine(dog.Name);
            }

            //2.
            List<Dog> dogsStartingWithB = dogs.Where(d => d.Name.StartsWith('B')).ToList();
            List<Dog> dogsAgedOneStartingWithB = dogsStartingWithB.Where(d => d.Age == 1).ToList();
            Console.WriteLine("dogsAgedOneStartingWithB:");
            foreach (Dog dog in dogsAgedOneStartingWithB)
            {
                Console.WriteLine(dog.Name);
            }

            //3.
            List<Dog> dogsAgedOneStartingWithCapitalB = dogs.Where(d => d.Name.StartsWith('B') && d.Age == 1).ToList();
            Console.WriteLine("dogsAgedOneStartingWithCapitalB:");
            foreach (Dog dog in dogsAgedOneStartingWithCapitalB)
            {
                Console.WriteLine(dog.Name);
            }

            //SELECT
            //Get all dogs' names
            List<string> dogsNames = dogs.Select(d => d.Name).ToList();
            Console.WriteLine("Dogs' names:");
            foreach (string name in dogsNames)
            {
                Console.WriteLine(name);
            }

            //get description for all dogs aged 1
            List<string> dogsAgedOneDescriptions =
                dogs.Where(d => d.Age == 1).Select(d => $"{d.Name} {d.Age}").ToList();
            Console.WriteLine("dogsAgedOneDescriptions");
            foreach (string desc in dogsAgedOneDescriptions)
            {
                Console.WriteLine(desc);
            }

            //FIRST/ FIRST OR DEFAULT
            //Dog dogAgedFive = dogs.First(d => d.Age == 5); ERROR
            Dog dogAgedFive = dogs.FirstOrDefault(d => d.Age == 5);
        }
    }
}
