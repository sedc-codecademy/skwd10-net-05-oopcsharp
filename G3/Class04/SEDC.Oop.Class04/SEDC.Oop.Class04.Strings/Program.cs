using System;

namespace SEDC.Oop.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Trajan";

            string hello1 = "Hello " + name;
            string hello2 = string.Format("Hello {0}", name); // Hello Trajan
            string hello3 = $"Hello {name}";

            Console.WriteLine("Hello1: " + hello1);
            Console.WriteLine(string.Format("Hello2: {0}", hello2));
            Console.WriteLine($"Hello3: {hello3}");

            string path = "Check your c:\\ drive";
            string a = "We will have \"fair\" elections";
            string b = "The \\n sign means: new line";

            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string aa = @"We will have ""fair"" elections";
            string bb = @"The \n sign means: new line";

            Console.WriteLine(path1);
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            string filePath = @"system\windows";
            string cc = $@"Check your c:\{filePath} drive";
            Console.WriteLine(cc);

            Console.WriteLine("=======================================================");

            string myStringCurrency = string.Format("{0:C}", 105.5);
            Console.WriteLine(myStringCurrency);

            int phoneNumber = 077132123;
            //077-132-123
            string formatedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formatedNumber);

            string formatWithMultipleStrings = string
                .Format("{0} {1} {2} {3} {4} {5}", "Hello", "my", "name", "is", "Trajan", ".");
            Console.WriteLine(formatWithMultipleStrings);

            Console.WriteLine("=======================================================");

            string ourString = "          We are learing c# and it is FUN and EASY, Okay maybe just FUN.         ";

            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);
            string upperLetters = ourString.ToUpper();
            Console.WriteLine(upperLetters);

            string[] splited = ourString.Trim().Split(' ');
            Console.WriteLine("The lenght is: " + splited.Length);
            foreach (string word in splited)
            {
                Console.WriteLine(word);
            }

            string substring = ourString.Substring(25, 50);
            Console.WriteLine(substring);

            Console.ReadLine();
        }
    }
}
