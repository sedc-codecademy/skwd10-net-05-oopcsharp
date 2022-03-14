using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string academyName = "SEDC";
            string academy = "Web programming";

            //concatenation
            string concatenatedAcademy = academyName + ", academy for " + academy;
            //interpolation
            string interpolatedAcademy = $"{academyName}, academy for {academy}";
            //format
            string formattedString = String.Format("{0}, academy for {1}", academyName, academy);


            //ESCAPING
            Console.WriteLine(concatenatedAcademy);
            Console.WriteLine(interpolatedAcademy);
            Console.WriteLine(formattedString);

            //escape the escape character
            Console.WriteLine("Check your c:\\drive");
            //escape the quotes
            Console.WriteLine("We are going to have \"fair\" elections");
            Console.WriteLine($"I am going to check the c:\\drive in {academyName}");

            Console.WriteLine("I have 5$");

            //escape everything that is a special character
            Console.WriteLine(@"I am going to ""check"" the c:\drive");

            Console.WriteLine(@$"I am going to check the c:\drive in {academyName}");


            //FORMAT
            string percent = String.Format("This is {0:P}", 123.4);
            Console.WriteLine(percent);

            string number = String.Format("This is {0:N}", 125000);
            Console.WriteLine(number);

            string phoneNumber = String.Format("{0:0##-###-###}", 078955734);
            Console.WriteLine(phoneNumber);

            string ourString = "We are from SEDC";
            //convert all characters to upper case
            Console.WriteLine(ourString.ToUpper());
            //convert all characters to lower case
            Console.WriteLine(ourString.ToLower());

            string message = "We are learning C# and it is FUN and EASY. Okay maybe just FUN";
            //split the string in smaller chunks wherever it has space
            string[] splittedStrings = message.Split(' ');
            foreach (string item in splittedStrings)
            {
                Console.WriteLine(item);
            }

            int index = message.IndexOf("learning");
            Console.WriteLine(index);

            Console.WriteLine($"message length: {message.Length}");

            //substring, returning a smaller piece of a string
            string subString = message.Substring(7); //starting index 7, till end
            string subString2 = message.Substring(7, 10); //starting index 7, take 10
            Console.WriteLine(subString);
            Console.WriteLine(subString2);
        }
    }
}
