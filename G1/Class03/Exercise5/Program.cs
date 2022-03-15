using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.WriteLine("Vnesete go " + (i + 1) + " broj:");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Vnesovte nevaliden broj!");
                        continue;
                    }

                    numbers[i] = number;
                    break;
                }
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sumata na vnesenite broevi e: " + sum);

            //Without array
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Vnesete go " + (i + 1) + " broj:");
            //        string input = Console.ReadLine();

            //        if (!int.TryParse(input, out int number))
            //        {
            //            Console.WriteLine("Vnesovte nevaliden broj!");
            //            continue;
            //        }

            //        sum += number;
            //        break;
            //    }
            //}

            //Console.WriteLine("Sumata na vnesenite broevi e: " + sum);
        }
    }
}
