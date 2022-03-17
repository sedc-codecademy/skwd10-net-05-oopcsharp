using System;

namespace CSharpBasic_G2_DatesAndStrings_L4
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteNumberMessage();

            /*int number = ReadANumber();
            Console.WriteLine($"The number you have entered is {number}");

            for (int i=0; i<number; i++)
            {
                if (IsEvenNumber(i))
                    Console.WriteLine(i);
            }*/

            Console.WriteLine("Enter + or -");

            string operation = Console.ReadLine();

            if (operation!="+" && operation != "-")
            {
                Console.WriteLine("Wrong input");
                return;
            }

            int first = ReadANumber();
            int second = ReadANumber();

            if (operation == "+")
            {
                int sum = Sum(first, second);
                Console.WriteLine($"The sum of the numbers is {sum}");
            }
            else
            {
                int diff = Subtract(first, second);
                Console.WriteLine($"The difference is {diff}");
            }
        }

        static int ReadANumber()
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);

            return parsedNumber;
        }



        static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static void WriteNumberMessage()
        {
            Console.WriteLine("Please enter a number");
        }

        static bool IsEvenNumber(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
