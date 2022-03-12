using System;
using System.Diagnostics.Tracing;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===for loop ======");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (;;)
            {
                Console.WriteLine("Enter input. Enter x or X to end.");
                string input = Console.ReadLine();

                if (input == "X" || input == "x")
                {
                    break;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            Console.WriteLine("====While=====");

            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            while (Console.ReadLine() != "no")
            {
                Console.WriteLine("Another execution");
            }


            int anotherCounter = 1;
            while (anotherCounter <= 10)
            {
                if (anotherCounter == 5)
                {
                    break;
                }

                if (anotherCounter == 3)
                {
                    anotherCounter++;
                    continue;
                }

                Console.WriteLine(anotherCounter);
                anotherCounter++;
            }



            //Do WHILE
            do
            {
                Console.WriteLine("Some message");
            } while (false);
        }
    }
}
