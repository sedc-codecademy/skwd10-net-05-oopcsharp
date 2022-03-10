using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");


            Console.WriteLine("Enter a whole number");
            string input = Console.ReadLine();


            //1.
            int parsedInt = int.Parse(input);
            Console.WriteLine(parsedInt);

            //2.
            string secondInput = "15";
            string anotherInput = "HEllo";

            int secondParsedInt = Convert.ToInt32(secondInput);
            Console.WriteLine(secondParsedInt);

            //int anotherParsedInput = Convert.ToInt32(anotherInput);
            //Console.WriteLine(anotherParsedInput);

           // Console.WriteLine(int.Parse(null));
            Console.WriteLine(Convert.ToInt32(null));




            //3.
            string firstInput = "45";
            string secondIn = "hello";

            int parsedResult;
            bool success = int.TryParse(firstInput, out parsedResult);
            Console.WriteLine(success);

            int anotherParsedResult;
            bool secondSuccess = int.TryParse(secondIn, out anotherParsedResult);
            Console.WriteLine(secondSuccess);

            Console.WriteLine("Enter a number for parsing..");
            bool thirdSuccess = int.TryParse(Console.ReadLine(), out anotherParsedResult);

            Console.ReadLine();
        }
    }
}
