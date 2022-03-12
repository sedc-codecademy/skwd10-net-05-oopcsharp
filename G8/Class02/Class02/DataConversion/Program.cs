using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data entry & conversion");
            Console.WriteLine("=============================");
            #region DataEntry
            //Console.WriteLine("Write your name: ");
            //// ReadLine waits for a user input and saves that input in the name variable
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("Write a number: ");
            //string number = Console.ReadLine();
            //Console.WriteLine(number.GetType());
            #endregion

            #region Conversion
            string numberString = "22";
            string doubleString = "12.7";
            string userInput = "a";
            Console.WriteLine("=============================");
            // Conversion with Parse

            //int parseInt = int.Parse(numberString);
            //Console.WriteLine(parseInt.GetType());

            //double parseDouble = double.Parse(doubleString);
            //Console.WriteLine(parseDouble.GetType());

            ////int parseUserInput = int.Parse(userInput);
            ////// this throws an exception because it can't convert "a" to integer
            ////Console.WriteLine(parseUserInput.GetType());

            Console.WriteLine("=============================");
            // Conversion with Convert
            //int convertedInt = Convert.ToInt32(numberString);
            //Console.WriteLine("Converted to int " + convertedInt.GetType());
            //double convertedDouble = Convert.ToDouble(doubleString);
            //Console.WriteLine("Converted to double " + convertedDouble.GetType());
            //int convetedUserInput = Convert.ToInt32(userInput);
            //Console.WriteLine("Converted to int - userInput " + convertedDouble.GetType() +" - "+ convetedUserInput);

            // Conversion with TryParse
            int parseResult;
            bool ifParsingSuccessful = int.TryParse(numberString, out parseResult);
            Console.WriteLine("Was it successful? " + ifParsingSuccessful);
            Console.WriteLine(parseResult);

            Console.WriteLine("=============================");
            bool ifParsingInputSuccessful = int.TryParse(userInput, out int parseInputResult);
            Console.WriteLine("Was it successful? " + ifParsingInputSuccessful);
            Console.WriteLine(parseInputResult);

            Console.WriteLine("Enter age:");
            bool ifAnotherParsingSuccessful = int.TryParse(Console.ReadLine(), out int userResult);
            Console.WriteLine("Was it successful? " + ifAnotherParsingSuccessful);
            Console.WriteLine(userResult);

            #endregion

            Console.ReadLine();
        }
    }
}
