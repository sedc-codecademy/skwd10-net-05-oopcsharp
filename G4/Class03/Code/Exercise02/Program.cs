using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            bool success = int.TryParse(Console.ReadLine(), out int firstNumber);

            if (success)
            {
                Console.WriteLine("Even numbers");
                for (int i = 2; i <= firstNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("Even numbers");

                for (int i = 2; i <= firstNumber; i = i + 2)
                {
                    
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid first number");
            }

            Console.WriteLine("Enter a number");
            bool parsingResult = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (parsingResult)
            {
                Console.WriteLine("Odd numbers");
                for (int i = 1; i <= secondNumber; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("Odd numbers");
                for (int i = 1; i <= secondNumber; i = i + 2)
                {

                    Console.WriteLine(i);
                }

                Console.WriteLine("Odd numbers");
                for (int i = 1; i <= secondNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

            }
        }
    }
}
