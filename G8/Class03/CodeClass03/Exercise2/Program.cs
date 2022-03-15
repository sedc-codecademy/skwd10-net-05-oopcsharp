using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int firstInputNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= firstInputNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Enter another number:");
            int secondInputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= secondInputNumber; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
