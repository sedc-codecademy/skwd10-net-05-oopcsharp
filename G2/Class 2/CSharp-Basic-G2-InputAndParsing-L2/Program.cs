using System;

namespace CSharp_Basic_G2_InputAndParsing_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number...");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            string numberThree = Console.ReadLine();

            int numberOneParsed = int.Parse(numberOne);
            Console.WriteLine("The first entered number parsed");
            Console.WriteLine(numberOneParsed);

            Console.WriteLine("The Sum of the first two entered numbers parsed");
            int numberTwoParsed = Convert.ToInt32(numberTwo);
            Console.WriteLine(numberOneParsed + numberTwoParsed);

            bool parsingResult = int.TryParse(numberThree, out int numberThreeParsed);

            Console.WriteLine("Did the parsing succeed? " + parsingResult);
            Console.WriteLine("The third entered number parsed");
            Console.WriteLine(numberThreeParsed);
          
        }
    }
}
