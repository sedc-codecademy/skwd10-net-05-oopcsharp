using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                { "Bob", 70993241 },
                { "Will", 71234232 },
                { "Meg", 72778900 },
                { "Jill", 71562110 },
                { "Buck", 71119804 }
            };

            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            SearchPhoneBook(phoneBook, name);
        }

        static void SearchPhoneBook(Dictionary<string, long> phoneBook, string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s phone number is: {phoneBook[name]}");
            }
            else
            {
                Console.WriteLine($"There is no record for {name} in the phone book.");
            }
        }
    }
}
