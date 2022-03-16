using System;

namespace CSharpBasic_G2_Loops_E2_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // For even numbers
            string numberOne = Console.ReadLine();

            bool isNumberOneParsed = int.TryParse(numberOne, out int numberOneParsed);

            if (isNumberOneParsed)
            {
                // Unoptimal way to run this code
                //for (int counter = 2; counter <= numberOneParsed; counter++)
                //{
                //    if (counter % 2 == 0)
                //    {
                //        Console.WriteLine(counter);
                //    }
                //}

                // Optimal way to run this code
                for (int counter = 2; counter <= numberOneParsed; counter += 2)
                {
                    Console.WriteLine(counter);
                }
            }

            // For odd numbers
            string numberTwo = Console.ReadLine();

            bool isNumberTwoParsed = int.TryParse(numberTwo, out int numberTwoParsed);

            if (isNumberTwoParsed)
            {
                for (int counter = 1; counter <= numberTwoParsed; counter += 2)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
