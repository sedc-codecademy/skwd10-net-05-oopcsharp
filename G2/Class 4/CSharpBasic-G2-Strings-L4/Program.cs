using System;

namespace CSharpBasic_G2_Strings_L4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello" + "World";
            int classNumber = 4;
            string secondString = $"This is class number {classNumber}";
            string thirdString = string.Format("Parameter entered {1}. Second param: {0}", 34, classNumber);

            //Console.WriteLine("Nov tekst {0} {1} {2}", firstString, secondString, thirdString);
            //Console.WriteLine(secondString);
            //Console.WriteLine(thirdString);

            //Console.WriteLine("Check your c:\\ drive");
            //Console.WriteLine("We will have \"fair\" elections");
            //Console.WriteLine("The \\n sign means: new line");

            //Console.WriteLine(@$"Check your c:\ drive We will have ""fair"" {classNumber} elections The \n sign means: new line");

            /*decimal decimalNumber = 3.45353m;
            Console.WriteLine(string.Format("{0:N2}", decimalNumber));

            decimal price = 99.23m;
            Console.WriteLine(string.Format("The price is {0:C}", price));

            decimal discount = 0.5m;
            Console.WriteLine(string.Format("The discount is {0:P}", discount));

            Console.WriteLine(string.Format("Phone number: {0:###-###-###}", 070123456));*/

            string text = "This Is C#BASIC, Class Number 4";

            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());

            //Console.Write(text.Trim());
            //Console.Write(text.Length);

            bool startsWith = text.StartsWith("Th1234");

            int indexOfCl = text.IndexOf("Cl");

            //Console.WriteLine(text[0]);

            string courseTitle = text.Substring(7);
            //Console.WriteLine(courseTitle);

            string[] words = text.Split(' ');

            /*foreach (string word in words)
            {
                Console.WriteLine(word);
            }*/

            Substring();
        }

        static void Substring()
        {
            string text = "Hello from SEDC Codecademy 2021";

            Console.WriteLine("Please enter a number");
            bool succesful = int.TryParse(Console.ReadLine(), out int number);

            if (!succesful)
            {
                Console.WriteLine("Entered text is not a number");
                return;
            }

            if (number > text.Length)
            {
                Console.WriteLine("The entered number is bigger than the text");
                return;
            }

            string substring = text.Substring(0, number);
            Console.WriteLine($"Substring is: {substring}");
            Console.WriteLine($"Substring length is {substring.Length}");
        }
    }
}
