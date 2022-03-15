using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operator + or -");
            string operation = Console.ReadLine();

            if (operation != "-" && operation != "+")
            {
                Console.WriteLine("Invalid operator");
                return;
            }
            Console.WriteLine("Enter the first number");
            bool firstParsingResult = int.TryParse(Console.ReadLine(), out int firstNum);

            Console.WriteLine("Enter the second number");
            bool secondParsingResult = int.TryParse(Console.ReadLine(), out int secondNum);

            if (!firstParsingResult || !secondParsingResult)
            {
                Console.WriteLine("Invalid inputs for numbers");
                return;
            }

            if (operation == "+")
            {
                int result = Sum(firstNum, secondNum);
                Console.WriteLine($"Sum: {result}");
            }
            else
            {
                int result = Subtract(firstNum, secondNum);
                Console.WriteLine($"Result of subtract call: {result}");


            }

            char op = operation[0];

            bool success = char.TryParse(operation, out char oper);

            char operationn = Convert.ToChar(operation);

            double num = (double)7;
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
