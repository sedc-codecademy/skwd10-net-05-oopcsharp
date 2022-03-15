using System;

namespace BranchingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter the second number:");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int secondNumber);

            int largerNumber;

            if (parsingResult1 && parsingResult2)
            {
                if (firstNumber >= secondNumber)
                {
                    largerNumber = firstNumber;
                }
                else
                {
                    largerNumber = secondNumber;
                }

                Console.WriteLine($"The larger number is {largerNumber}");

                if (largerNumber == 0)
                {
                    Console.WriteLine("The larger number is zero. Can not determine even/odd");
                }
                else
                {
                    if (largerNumber % 2 == 0)
                    {
                        Console.WriteLine($"The number {largerNumber} is even");
                    }
                    else
                    {
                        Console.WriteLine($"The number {largerNumber} is odd");
                    }
                }
            }
            else
            {
                Console.WriteLine("At least one of the inputs was not correct!");
            }
        }
    }
}
