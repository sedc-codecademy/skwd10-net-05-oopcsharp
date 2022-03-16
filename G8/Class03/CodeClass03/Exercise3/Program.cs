using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (success)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0)
                        continue;
                    if (i == 100)
                    {
                        Console.WriteLine("The limit is reached!");
                        break;
                    }
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
