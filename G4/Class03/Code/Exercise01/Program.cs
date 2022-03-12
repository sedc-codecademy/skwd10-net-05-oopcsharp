using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            bool success = int.TryParse(Console.ReadLine(), out int number);

            if (success)
            {
                Console.WriteLine("Counting from 1");
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Counting to 1");

                for (int i = number; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
