using System;

namespace Task1
{
    class Program
    {
        static void NumberStats(double number)
        {
            bool isNegative = number < 0;
            bool isDecimal = number % 1 > 0;
            string type = isDecimal ? "Decimal" : "Integer";
            bool isEven = number % 2 == 0;
            Console.WriteLine($"Stats for number: {number}");
            Console.WriteLine($"{number} is negative: {isNegative}.");
            Console.WriteLine($"{number} is {type}");
            Console.WriteLine($"{number} is Even: {isEven}");
        }

        static bool UserInterface()
        {
            Console.WriteLine("Enter a number:");
            double number;
            bool isNumber = double.TryParse(Console.ReadLine(), out number);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Please try again!");
                return false;
            }
            NumberStats(number);
            Console.WriteLine("Press any key to try again or X to exit.");
            if (Console.ReadLine().Equals("X", StringComparison.InvariantCultureIgnoreCase))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            //NumberStats(5);
            while (!UserInterface()) ;
            Console.ReadLine();
        }
    }
}
