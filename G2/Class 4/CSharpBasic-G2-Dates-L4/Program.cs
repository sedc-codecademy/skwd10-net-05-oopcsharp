using System;

namespace CSharpBasic_G2_Dates_L4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today);

            // Arithmetics with Date
            DateTime threeDaysLater = today.AddDays(3);
            Console.WriteLine(threeDaysLater);

            DateTime threeHoursLater = today.AddHours(3);
            Console.WriteLine(threeHoursLater);

            DateTime threeMonthsLater = today.AddMonths(3);
            Console.WriteLine(threeMonthsLater);

            DateTime threeYearsEarlier = today.AddYears(-3);
            Console.WriteLine(threeYearsEarlier);

            DateTime twoDaysAndThreeMonthsLater = today.AddDays(2)
                                                       .AddMonths(3);
            Console.WriteLine(twoDaysAndThreeMonthsLater);

            DateTime myBirthday = new DateTime(1996, 11, 21, 8, 15, 0);
            Console.WriteLine(myBirthday);

            // Arithmetics With Time
            DateTime twoHoursLater = today.AddHours(2);
            Console.WriteLine(twoHoursLater);

            DateTime twoMintesLater = today.AddMinutes(2);
            Console.WriteLine(twoMintesLater);

            // Extracting specific properties from DateTime
            Console.WriteLine(today.Year);
            Console.WriteLine(today.Month);
            Console.WriteLine(today.Day);

            // Comparations
            bool isSameDate = myBirthday != today;
            Console.WriteLine(isSameDate);

            // Formats
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToShortTimeString());
            Console.WriteLine(today.DayOfYear);
            Console.WriteLine(today.DayOfWeek);
            Console.WriteLine(today.IsDaylightSavingTime());

            // Input : 25
            // Output : Year of Birth (+- 1 year)

            string myAge = Console.ReadLine();
            bool isValidNumber = int.TryParse(myAge, out int myAgeParsed);
            
            if (!isValidNumber)
            {
                Console.WriteLine("Invalid age!");
            }
            
            int yearOfBirth = (DateTime.Now.AddYears(-myAgeParsed).Year);

            Console.WriteLine(yearOfBirth);
        }
    }
}
