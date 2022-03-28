using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                {"Risto",  "070123456"},
                {"Bojan", "071123456" },
                {"Darko", "078123456" },
                {"Zubush", "075123456" },
                {"David", "072123456" }
            };

            Console.WriteLine("Ve molime vnesete ime:");
            string input = Console.ReadLine();

            //if (phoneBook.ContainsKey(input))
            //{
            //    Console.WriteLine($"{input}: tel. {phoneBook[input]}");
            //} else
            //{
            //    Console.WriteLine($"{input} does not exist");
            //}

            //if(phoneBook.Any(x => x.Key.Equals(input, StringComparison.OrdinalIgnoreCase)))
            //{

            //}
            //if (phoneBook.Any(x => x.Key.ToLower() == input.ToLower()))
            //{

            //}

            KeyValuePair<string, string> phone = phoneBook.FirstOrDefault(x => x.Key.ToLower() == input.ToLower());

            if (phone.Value != null)
                Console.WriteLine($"{input}: tel. {phone.Value.ToUpper()}");
            else
                Console.WriteLine($"{input} does not exist");
        }
    }
}
