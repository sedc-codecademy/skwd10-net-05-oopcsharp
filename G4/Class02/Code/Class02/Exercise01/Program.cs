using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstDouble = 2;
            double secondDouble = 5;
            double firstResult = firstDouble / secondDouble;

            Console.WriteLine($"First result: {firstResult}");

            int firstInt = 2;
            int secondInt = 5;
            double secondResult = firstInt / secondInt;

            Console.WriteLine($"Second result: {secondResult}");
        }
    }
}
