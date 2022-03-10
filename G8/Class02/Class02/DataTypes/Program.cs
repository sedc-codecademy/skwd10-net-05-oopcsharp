using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello G8!");
            #region DataTypes
            // declaration
            int integerVariable1;
            // initialization
            integerVariable1 = 5;
            // declaration & initialization
            int integerVariable2 = 15;

            float floatVariable = 23.4F;
            double doubleVariable = 566785967897897.678;

            // strings have to be in double quotes
            string name = "Petre";
            name = "Angel";
            char operatorVariable = '*';

            bool boolVariable = true;
            long longInteger = 6708657607;

            Console.WriteLine("------------- DataTypes -------------");
            Console.WriteLine(integerVariable1);
            Console.WriteLine(integerVariable2);
            Console.WriteLine(floatVariable);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(name);
            Console.WriteLine(operatorVariable);
            Console.WriteLine(boolVariable);
            Console.WriteLine(longInteger);
            #endregion

            #region Operators

            Console.WriteLine("------------- Operators -------------");

            // + operator sums two sides if they're numbers
            int sumOfTwoNumbers = 7 + 8;
            Console.WriteLine(sumOfTwoNumbers);
            // + operator concatanates two strings
            Console.WriteLine("4" + "8");

            int moduleOperator = 10 % 3;           
            Console.WriteLine(moduleOperator);

            sumOfTwoNumbers += 10;
            //sumOfTwoNumbers = sumOfTwoNumbers + 10
            Console.WriteLine("Sum again: " + sumOfTwoNumbers);

            Console.WriteLine(true || false); //true
            Console.WriteLine(false ^ true); //false

            // asigning new values with logical operators
            bool myBooleanVariable = true;
            myBooleanVariable &= false;
            // myBooleanVariable = myBooleanVariable && false
            Console.WriteLine(myBooleanVariable);

            int someNumber = 9;
            //someNumber = "Angel"; // you cannot change the type, even with var

            #endregion

            #region Exercises
            Console.WriteLine("------------- Exercises -------------");
            // Exercise 01

            double firstDouble = 34534523.56;
            double secondDouble = 45.78;
            double divisionDouble = firstDouble / secondDouble;

            int firstInteger = 678;
            int secondInteger = 59;
            int divisionInteger = firstInteger / secondInteger;

            Console.WriteLine(divisionDouble);
            Console.WriteLine(divisionInteger);

            // Exercise 02

            string bookString01 = "Zoki";
            string bookString02 = "Poki";
            string  sumBookString = bookString01 + " " + bookString02;
            Console.WriteLine(sumBookString);

            string numString01 = "9";
            string numString02 = "3";
            string sumNumString = numString01 + numString02;
            Console.WriteLine(sumNumString);
            // you can check the type of the variable with GetType() method
            Console.WriteLine(sumNumString.GetType());

            // Exercise 03

            string randomString = "Random number";
            int randomNumber = 42;
            string resultRandom = randomString + randomNumber;
            Console.WriteLine(resultRandom);


            // Exercise 04
            int phoneCredit = 102;
            int priceMessage = 5;
            int howManyMessages = phoneCredit / priceMessage;
            Console.WriteLine("I can send " + howManyMessages + " messages.");

            #endregion

            Console.ReadLine();
        }
    }
}
