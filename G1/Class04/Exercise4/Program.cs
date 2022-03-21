using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime threeDaysAfter = now.AddDays(3);
            Console.WriteLine($"Three days after: {threeDaysAfter}");
            Console.WriteLine($"Three days after: {threeDaysAfter.ToString("dd.MM.yyyy")}");
            DateTime oneMonthAfter = DateTime.Now.AddMonths(1);
            DateTime oneMonthAndThreeDaysAfter = DateTime.Now.AddMonths(1).AddDays(3);
            DateTime today = DateTime.Today;
            DateTime oneYearAndTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
            Console.WriteLine($"Today's month: {today.Month}");
            Console.WriteLine($"Today's year: {today.Year}");
            Console.WriteLine($"Today's day: {today.DayOfYear}");
            Console.WriteLine($"Today's month: {today.ToString("MMMM")}");
        }
    }
}
