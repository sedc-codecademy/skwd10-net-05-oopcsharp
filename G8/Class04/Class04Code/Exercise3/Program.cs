using System;

namespace Exercise3
{
    class Program
    {
        // you can try this with Void
        static bool Substrings()
        {
            string message = "Hello from SEDC Codecademy 2021";
            Console.WriteLine("Please enter a number");
            int numOfCharacters;

            if(int.TryParse(Console.ReadLine(), out numOfCharacters) != true)
            {
                Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
                return false;
                // return;
            }
            if(numOfCharacters > message.Length)
            {
                Console.WriteLine("You have entered an incorrect number,\nPress any key to try again");
                return false;
                // return;
            }
            string result = message.Substring(0, numOfCharacters);
            Console.WriteLine(result + " " + "\nlength of new string is " + result.Length);
            return true;
            // return;
        }
        static void Main(string[] args)
        {
            Substrings();
            Console.ReadLine();
        }
    }
}
