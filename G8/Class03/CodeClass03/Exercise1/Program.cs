using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            bool success = int.TryParse(Console.ReadLine(), out int counter);
            if (success)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Enter another number:");
                int anotherCounter = int.Parse(Console.ReadLine());
                for(int i = anotherCounter; i != 0; i--)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
    }
}
