using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===For loop===");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //for(; ; )
            //{
            //    Console.WriteLine("Hello!");
            //}

            for(; ; )
            {
                Console.WriteLine("Enter input");
                string input = Console.ReadLine();
                //if(input.ToLower() == "x")

                if (input == "X" || input == "x")                
                {
                    break;
                }
            }

            for(int i = 0; i <= 10; i++)
            {
                if(i == 5)
                {
                    Console.WriteLine("Breaking...");
                    break;
                }

                if(i == 3)
                {
                    Console.WriteLine("Skipping...");
                    continue;
                }
            }

            Console.WriteLine("==while===");

            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            while (true)
            {
                Console.WriteLine("Enter input");
                string input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    break;
                }
            }

            int anotherCounter = 0;
            while(anotherCounter <= 10)
            {
                if(anotherCounter == 3)
                {
                    Console.WriteLine("Skipping in while...");
                    anotherCounter++;
                    continue;
                }
                if(anotherCounter == 5)
                {
                    Console.WriteLine("Breaking in while...");
                    break;
                }
                Console.WriteLine(anotherCounter);
                anotherCounter++;
            }

            Console.WriteLine("=== Do while ===");
            int thirdCounter = 0;
            do
            {
                Console.WriteLine(thirdCounter);
                thirdCounter++;
            }
            while (thirdCounter <= 3);

            do
            {
                Console.WriteLine("This message will be written!");
            }
            while (false);

            Console.ReadLine();
        }
    }
}
