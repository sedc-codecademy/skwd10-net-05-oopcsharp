using System;

namespace CSharp_Basic_G2_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable
            int a;
            // Initialize/assign the declared variable
            a = 2;
            
            // Declare and assign the variable
            double averageScore = 0.5;

            char chosenLetter = 'a';
            string helloWorld = "Hello World";

            bool isActive = true;
            bool isBusy = false;

            // Create a new date object
            DateTime datum = new DateTime(2022, 3, 10, 18, 12, 15);

            Console.WriteLine(a);
            Console.WriteLine(averageScore);
            Console.WriteLine(datum);
            Console.WriteLine(chosenLetter);
            Console.WriteLine(helloWorld);
        }
    }
}