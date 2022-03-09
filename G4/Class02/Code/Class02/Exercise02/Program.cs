using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";

            string concatenationResult = firstString + " " + secondString;
            Console.WriteLine(concatenationResult);

            string interpolationResult = $"{firstString} {secondString}";
            Console.WriteLine(interpolationResult);

            string firstStringNumber = "9";
            string secondStringNumber = "3";

            string stringNumbersConcatenation = firstStringNumber + secondStringNumber;
            Console.WriteLine(stringNumbersConcatenation);
        }
    }
}
