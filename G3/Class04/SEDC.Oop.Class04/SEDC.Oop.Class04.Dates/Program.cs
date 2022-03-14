using System;

namespace SEDC.Oop.Class04.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);

            DateTime customeDate = new DateTime(1992, 10, 15);
            Console.WriteLine(customeDate);

            string date1 = "12.15.2012";
            string date2 = "12/15/2012";
            string date3 = "12/15/12";
            string date4 = "dec.15.12";
            string date5 = "12-15-2012";

            DateTime convertedDate = DateTime.Parse(date1);
            DateTime convertedDate1 = DateTime.Parse(date2);
            DateTime convertedDate2 = DateTime.Parse(date3);
            DateTime convertedDate3 = DateTime.Parse(date4);
            DateTime convertedDate4 = DateTime.Parse(date5);
            //Console.WriteLine(convertedDate);
            //Console.WriteLine(convertedDate1);
            //Console.WriteLine(convertedDate2);
            //Console.WriteLine(convertedDate3);
            //Console.WriteLine(convertedDate4);

            DateTime currentDay = DateTime.Today;
            Console.WriteLine(currentDay);

            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            DateTime addedDays = currentDateAndTime.AddDays(5);
            DateTime removedDays = currentDateAndTime.AddDays(-10);
            DateTime addMonth = currentDateAndTime.AddMonths(5);
            DateTime addYear = currentDateAndTime.AddYears(3);
            DateTime addHours = currentDateAndTime.AddHours(3);

            int year = currentDateAndTime.Year;
            int dat = currentDateAndTime.Day;
            int month = currentDateAndTime.Month;


            //DateTime currentDate = DateTime.Today.Date;


            string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            string dateFormat2 = currentDateAndTime.ToString("dddd,dd MMMM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:dddd}", currentDateAndTime);
            string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDateAndTime);

            string dateFormat5 = currentDateAndTime.ToShortTimeString();

            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);


            Console.ReadLine();
        }
    }
}
