using System;

namespace CSharpBasic_G2_Loops_E3_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isNumberParsed = int.TryParse(input, out int parsedNumber);

            if (isNumberParsed)
            {
                for (int counter = 1; counter <= parsedNumber; counter++)
                {
                    if (counter % 3 == 0 || counter % 7 == 0)
                    {
                        continue;
                    }

                    if (counter >= 100)
                    {
                        Console.WriteLine("The limit of 100 has been reached. Exiting;");
                        break;
                    }

                    Console.WriteLine(counter);
                }
            }
        }
    }
}
