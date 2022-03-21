using System;

namespace SEDC.Oop.Class06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 1, 11, 1.3, -22.3, -11, 43235.2, 3123, 0.5 };

            foreach (double number in numbers)
            {
                NumberStats numberStats = NumberStats(number);
                numberStats.PrintInfo();
            }

            Console.ReadLine();
        }

        public static NumberStats NumberStats(double number)
        {
            NumberStats stats = new NumberStats()
            {
                Number = number
            };
            stats.IsEven = number % 2 == 0;
            stats.IsDecimal = number % 1 != 0;
            stats.IsNegative = number < 0;
            return stats;
        }
    }
}
