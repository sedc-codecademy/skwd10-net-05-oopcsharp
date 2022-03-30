using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        public static void PrintPhone(Dictionary<string, long> phoneBook, string name)
        {
            if (!phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
                return;
            }
            Console.WriteLine($"{name}'s phone is: 00{phoneBook[name]}");
        }
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Gjorgji", 0987678 },
                {"Irena", 5678214 },
                {"Jovana", 8761235 },
                {"Vase", 8349876 },
                {"Elena", 2346345 }
            };
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            PrintPhone(phoneBook, name);

            Console.ReadLine();
        }
    }
}
