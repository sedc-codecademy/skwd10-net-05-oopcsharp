using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // get current Date and Time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            // get current Universal Date and Time
            DateTime utcDateTime = DateTime.UtcNow;
            Console.WriteLine(utcDateTime);

            //create empty Date with default values
            DateTime emptyDatetime = new DateTime();
            Console.WriteLine(emptyDatetime);

            DateTime customDate = new DateTime(1999, 11, 5);
            Console.WriteLine(customDate);

            string stringDate = "19-03-2022";
            //create DateTime from string
            DateTime convertDate = DateTime.Parse(stringDate);
            Console.WriteLine(convertDate);

            //get current date
            DateTime currentDate = DateTime.Today;
            Console.WriteLine(currentDate);

            //add two days to the given datetime
            DateTime twoDaysFromToday = currentDate.AddDays(2);
            Console.WriteLine(twoDaysFromToday);

            //go one month back from the given datetime
            DateTime oneMonthBack = currentDate.AddMonths(-1);
            Console.WriteLine(oneMonthBack);

            DateTime oneMinuteBack = currentDateTime.AddMinutes(-1);
            Console.WriteLine(oneMinuteBack);

            Console.WriteLine(currentDateTime.Month);
            Console.WriteLine(currentDateTime.Year);
            Console.WriteLine(currentDateTime.Date);
            Console.WriteLine(currentDateTime.Day);

            string stringFirstDateFormat = currentDateTime.ToString("MM/dd/yyyy");
            Console.WriteLine(stringFirstDateFormat);
            string secondDateFormat = currentDateTime.ToString("dddd MMMM yyyy");
            Console.WriteLine(secondDateFormat);
            string thirdDateFormat = currentDateTime.ToString("MM-dd-yyyy HH:mm:ss");
            Console.WriteLine(thirdDateFormat);

            string formatedDate = String.Format("Today is {0:dd-MMMM-yyyy}", currentDateTime);
            Console.WriteLine(formatedDate);


            Console.ReadLine();
        }
    }
}
