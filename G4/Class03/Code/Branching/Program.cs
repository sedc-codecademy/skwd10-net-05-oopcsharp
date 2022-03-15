using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            string input = Console.ReadLine();

            int enteredNumber;
            bool parsingResult = int.TryParse(input, out enteredNumber);

            if (parsingResult)
            {
                if (enteredNumber > 0)
                {
                    Console.WriteLine("You entered a positive number!");
                }
                else if (enteredNumber < 0)
                {
                    Console.WriteLine("You entered a negative number!");
                }
                else
                {
                    Console.WriteLine("You entered the number zero!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Can not be parsed into whole number!");
            }


            //SWITCH
            Console.WriteLine("=======Switch==========");
            Console.WriteLine("Enter a number from 1 to 7");
            //string dayInput = Console.ReadLine();
            //int day = int.Parse(dayInput);
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                //case 1:
                //    Console.WriteLine("Monday");
                //    break;
                //case 2:
                //    Console.WriteLine("Tuesday");
                //    break;

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day!");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid input! Valid values 1 - 7");
                    break;
            }

        }
    }
}
