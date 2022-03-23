using System;

namespace CSharp_G2_Class6_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            do
            {
                double enteredValue = ReadNumber();

                if (enteredValue == 0)
                {
                    Console.WriteLine("Entered value is not a number");
                    continue;
                }

                NumberStats(enteredValue);

                Console.WriteLine("Enter x to exit, or any key to continue");

                string enteredKey = Console.ReadLine();
                if (enteredKey.ToLower() != "y" && enteredKey.ToLower() != "x")
                {
                    break;
                }

                shouldContinue = enteredKey.ToLower() == "y";
            }
            while (shouldContinue);
        }

        static double ReadNumber()
        {
            Console.WriteLine("Please enter a number");

            string enteredNumber = Console.ReadLine();

            bool isParsed = double.TryParse(enteredNumber, out double paresdNumber);

            if (isParsed)
            {
                return paresdNumber;
            }
            else
            {
                return 0;
            }
        }

        static void NumberStats(double number)
        {
            bool isPositive = number > 0 ? true : false;
            bool isOdd = number % 2 != 0 ? true : false;
            bool hasDecimals = number % 1 !=0 ? true : false;

            Console.WriteLine(string.Format("The number is {0}", isPositive ? "Positive" : "Negative"));
            Console.WriteLine(string.Format("The number is {0}", isOdd ? "Odd" : "Even"));
            Console.WriteLine(string.Format("The number is {0}", hasDecimals ? "Decimal" : "Integer"));
        }
    }
}
