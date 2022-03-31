using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data for LINQ manipulation
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

            // All dogs with name starting with S
            List<Dog> nameStartsWithS = dogs
                                    //.Where(x => x.Name.ToCharArray()[0] == 'S')
                                    .Where(x => x.Name.StartsWith("S"))
                                    .ToList();
            //nameStartsWithS.ForEach(x => Console.WriteLine(x.Name));

            // First dog that is of age 1 and has a name that starts with B
            Dog dogAge1NameB = dogs
                                //.Where(x => x.Age == 1)
                                //.Where(x => x.Name.StartsWith("B"))
                                //.First();
                              .FirstOrDefault(x => x.Age == 1 && x.Name.StartsWith("B"));
            // FirstOrDefault returns null if it doesn't find any result from quering

            //Console.WriteLine(dogAge1NameB.Name);

            // All names of dogs
            List<string> namesOfDogs = dogs
                                .Select(x => x.Name)
                                .ToList();
            //namesOfDogs.ForEach(name => Console.WriteLine(name));

            // All dogs ages
            List<int> agesOfDogs = dogs
                        .Select(x => x.Age)
                        .ToList();
            //agesOfDogs.ForEach(x => Console.WriteLine(x));

            //All names of dogs of age 2
            List<string> namesOfDogsAge2 = dogs
                                    .Where(x => x.Age == 2)
                                    .Select(x => x.Name)
                                    .ToList();

            namesOfDogsAge2.ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }
    }
}
