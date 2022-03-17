using System;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime newYear = new DateTime(2022, 1, 1, 13, 50, 20);

            DateTime newDate = newYear.AddDays(-100);

            DateTime now = DateTime.Now;

            while(true)
            {
                Console.WriteLine(DateTime.UtcNow);
            }
        }
    }
}
