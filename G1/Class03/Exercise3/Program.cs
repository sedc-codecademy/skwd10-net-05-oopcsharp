using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Ve molime vnesete broj:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    //nevaliden broj
                    Console.WriteLine("Vnesovte vrednost koja ne e broj!");
                    continue;
                }

                break;
            }

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }

                counter++;

                if (counter > 100)
                {
                    Console.WriteLine("Limit reached");
                    break;
                }

                Console.WriteLine("Poraka br: " + counter + " Vrednost: " + i);
            }
        }
    }
}
