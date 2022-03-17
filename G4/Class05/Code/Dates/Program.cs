using System;
using System.Runtime.InteropServices;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
           //empty (default) date
           DateTime dateTime = new DateTime();
           Console.WriteLine(dateTime);

           //get the date and time from the server (local)
           DateTime currentDateTime = DateTime.Now;
           Console.WriteLine(currentDateTime);

           //get the Universal Date and Time
           DateTime universalDateTime = DateTime.UtcNow;
           Console.WriteLine(universalDateTime);

           DateTime currentDate = DateTime.Today;
           Console.WriteLine(currentDate);

           Console.WriteLine(currentDateTime.Date);

           DateTime customDateTime = new DateTime(1999, 11, 3);
           Console.WriteLine(customDateTime);

           DateTime twoDaysAgo = currentDateTime.AddDays(-2);
           Console.WriteLine(twoDaysAgo);

           DateTime threeHoursAfter = currentDateTime.AddHours(3);
           Console.WriteLine(threeHoursAfter);

           string stringDate = "8/13/2023";
           DateTime parsedDateTime = DateTime.Parse(stringDate);
           Console.WriteLine(parsedDateTime);

           Console.WriteLine(currentDateTime.Month);
           Console.WriteLine(currentDateTime.Year);
           Console.WriteLine(currentDateTime.Day);

           string currentDateString = currentDateTime.ToString("dd/MM/yyyy");
           string anotherDateString = currentDateTime.ToString("dddd MMMM yy");
           string anotherOne = currentDateTime.ToString("MM-dd-yyyy HH:mm:ss");

           Console.WriteLine(currentDateString);
           Console.WriteLine(anotherDateString);
           Console.WriteLine(anotherOne);

           string formattedDate = String.Format("{0:dd-MMMM-yyyy}", currentDateTime);

           DateTime newDate = DateTime.Now.AddDays(2).AddMonths(3);

           DateTime anotherDate = DateTime.Now.AddDays(2);
           DateTime finalDate = anotherDate.AddMonths(3);

        }
    }
}
