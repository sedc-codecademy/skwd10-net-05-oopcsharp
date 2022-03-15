using System;

namespace NumbersExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Ve molime vnesete broj (Primer 1):");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out int number))
                {
                    //nevaliden broj
                    Console.WriteLine("Vnesovte vrednost koja ne e broj!");
                    continue;
                }

                //validen broj
                for(int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Ve molime vnesete broj (Primer 2):");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    //nevaliden broj
                    Console.WriteLine("Vnesovte vrednost koja ne e broj!");
                    continue;
                }

                //validen broj
                for (int i = number; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                break;
            }
        }
    }
}
