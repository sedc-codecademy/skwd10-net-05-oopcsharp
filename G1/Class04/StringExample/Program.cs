using System;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \ escape character
            string example1 = "Check your c:\\drive";
            Console.WriteLine(example1);
            string example2 = "We will have \"fair\" elections";
            Console.WriteLine(example2);
            string example3 = "The \n sign means: new line";
            string example4 = "The \t sign means: tab";
            Console.WriteLine(example3);
            Console.WriteLine(example4);


            string example1_1 = @"Check your c:\drive \n asdasd";
            string path = @"C:\SEDC\Materials\2021-2022\[4] C# Basic";
            Console.WriteLine(example1_1);
            Console.WriteLine(path);

            string example5 = @"We will have ""fair"" elections";
            Console.WriteLine(example5);

            string example6 = "test 'a' a";
            Console.WriteLine(example6);

            //The result is: 6, and 7
            int number = 6;
            int number2 = 7;
            string result1 = "The result is: " + number + ", and " + number2;
            Console.WriteLine(result1);
            string result2 = string.Format("The result is: {0}, and {1}", number, number2);
            Console.WriteLine(result2);
            string result3 = $"The result is: {number}, and {number2}";
            Console.WriteLine(result3);

            string path1 = @$"C:\SEDC\Materials\2021-2022\[4] C# Basic {number}";
            Console.WriteLine(path1);

            int price = 1500;
            //Console.WriteLine($"Price: {price}$");
            Console.WriteLine(string.Format("Price: {0:C}", price));
            Console.WriteLine($"Price: {price:C}");

            float percent = 1.5F;
            Console.WriteLine(string.Format("Percent: {0:P}", percent));
            Console.WriteLine($"Percent: {percent:P}");

            int phone = 70654321;
            Console.WriteLine(string.Format("{0:+386 ##-###-###}", phone));
            Console.WriteLine($"{phone:0##-###-###}");

            string[] names = new string[]{"Risto", "Aleksandaraaaa", "Ivo"};

            Console.WriteLine($"Id, Name");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"|{i, -3}|{names[i], -15}|");
            }


            string s = "   Welcome in SEDC 2022 ";

            string toUpper = s.ToUpper();
            string toLower = s.ToLower();
            string trimmed = s.Trim();

            int length = s.Length;
            bool startsWith = trimmed.StartsWith("Welcome");
            int indexOf = s.IndexOf("ina");
            char[] array = s.ToCharArray();
            string substring = s.Substring(11, 2);

            string[] splitString = trimmed.Split(" ");

            string namesTotal = string.Join(", ", names);
        }
    }
}
