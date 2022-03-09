using System;

namespace SEDC.Oop.Class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC!");

            // brojki
            int number = 3;
            // number = 123456789012345; // cannot put big number into an 32 bit integer
            long bigNumber = 123456789012345;
            short shortNumber = 12000;
            byte smallNumber = 255;

            double doublePrecisionNumber = 12.093213;
            float singlePrecisionNumber = 123.1f;

            string str = "Trajan Stevkovski";
            char character = 'a';

            bool isSomethingTrue = false;
            DateTime currentDate = new DateTime();

            int module = 10;
            module %= 3;
            Console.WriteLine(module);

            // var a = 123456789012345;
            // a = 123456789012345;

            //Console.WriteLine("==================DATA ENTRY==================");

            //string input = Console.ReadLine();

            //Console.WriteLine("This is the input value: " + input);

            //int parsedToInteger = int.Parse(input);
            //Console.WriteLine("This is the parsed input value: " + parsedToInteger);

            //bool parsedToBoolean = Convert.ToBoolean(input);
            //int parsedToBoolean = Convert.ToInt32(input);
            //Console.WriteLine("This is the parsed input value: " + parsedToBoolean);

            //long parsedToLong = 0;
            //bool isValidInput = long.TryParse(input, out parsedToLong);

            //bool isValidInput1 = long.TryParse(input, out long parsedToLong1);

            //Console.WriteLine("Is parsing valid: " + isValidInput);
            //Console.WriteLine("This is the parsed input value: " + parsedToLong);

            //string parsedToString = parsedToLong.ToString();

            Console.WriteLine("==================BRANCHING===================");

            string input = Console.ReadLine();

            bool isValidInteger = int.TryParse(input, out int parsedInput);

            if(isValidInteger)
            {
                Console.WriteLine("The parsed number is: " + parsedInput);
            } 
            else
            {
                Console.WriteLine("Not valid input!");
            }

            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int fourtNumber = 20;

            if (firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("THe if statement is TRUE");
            } 
            else if(thirdNumber < fourtNumber || secondNumber > fourtNumber)
            {
                Console.WriteLine("The first else if statement is TRUE");
            } 
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine("The second else if statement is TRUE");
            } 
            else if(!(firstNumber < secondNumber))
            {
                Console.WriteLine("The third else if statement is TRUE");
            }
            else
            {
                Console.WriteLine("we are in else");
            }

            Console.WriteLine("===============SWITCH====================");

            int someNumber = 3;

            switch (someNumber)
            {
                case 1:
                    Console.WriteLine("We are at case 1");
                    break;
                //case 'a': // this is valid
                //    break;
                //case "Something": // this is not valid
                //    break;
                case 2:
                    Console.WriteLine("We are at case 2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("We are at case 3,4,5");
                    break;
                default:
                    Console.WriteLine("If non of the cases is exceuted im always executed");
                    break;
            }

            Console.ReadLine();
        }
    }
}
