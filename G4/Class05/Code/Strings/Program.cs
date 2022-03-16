using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello from SEDC CodeAcademy 2022";
            Console.WriteLine("Enter number of characters for the substring:");

            int numberOfCharacters = int.Parse(Console.ReadLine());

            string substring = message.Substring(0, numberOfCharacters);
            Console.WriteLine($"Substring: {substring}");


            int index = message.IndexOf("SEDC");
            Console.WriteLine($"Index: {index}");

            int notFound = message.IndexOf("goodbye");
            Console.WriteLine($"Not found: {notFound}");

            bool startsWithHello = message.StartsWith("Hello");
            Console.WriteLine(startsWithHello);

            string secondMessage = "    We are learning C#     ";
            Console.WriteLine(secondMessage);

            //removes spaces at the beginning and at the end
            string trimmedMessage = secondMessage.Trim();
            Console.WriteLine(trimmedMessage);

            char[] charArray = trimmedMessage.ToCharArray();
            Console.WriteLine($"charArray[3]: {charArray[3]}");

            string joinedString = String.Join('-', charArray);
            Console.WriteLine(joinedString);

            if (secondMessage == trimmedMessage)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }

            Console.WriteLine(secondMessage.Equals(trimmedMessage));
            //compares values of two strings, ignoring lower and upper case
            Console.WriteLine("secondMessage".Equals("SECONDMESSAGE", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
