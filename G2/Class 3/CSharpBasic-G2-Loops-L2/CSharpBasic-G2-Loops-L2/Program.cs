using System;
using System.Threading;

namespace CSharpBasic_G2_Loops_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop
            for (int counter = 6; counter > 0; counter--)
            {
                if (counter == 3)
                {
                    continue;
                }

                Console.WriteLine(counter);
            }

            // While loop
            int counterWhile = 6;
            while (counterWhile > 0)
            {
                Console.WriteLine(counterWhile);

                counterWhile--;
            }

            // Do while
            int counterDoWhile = 6;
            do
            {
                Console.WriteLine(counterDoWhile);

                counterDoWhile--;
            }
            while (counterDoWhile > 0);

            string number = Console.ReadLine();

            int parsedNumber;
            bool isNumberParsed = int.TryParse(number, out parsedNumber);

            if (isNumberParsed)
            {
                for (int counter = 1; counter <= parsedNumber; counter++)
                {
                    Console.WriteLine(counter);
                }
            }

            string numberReverse = Console.ReadLine();
            bool isReverseNumberParsed = int.TryParse(numberReverse, out int parsedNumberReverse);

            if (isReverseNumberParsed)
            {
                for (int counter = parsedNumberReverse; counter >= 1; counter--)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
