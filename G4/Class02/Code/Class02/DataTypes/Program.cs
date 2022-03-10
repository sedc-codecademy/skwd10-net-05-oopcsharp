using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourFirstInteger; //declaration
            ourFirstInteger = 10; //initialization
           // ourFirstInteger = "test"; -> error, different data type

           int ourSecondInteger = 7; //declaration and initialization

           Console.WriteLine("Our first integer:");
           Console.WriteLine(ourFirstInteger);

           Console.WriteLine("Our second integer:");
           Console.WriteLine(ourSecondInteger);

           float ourFirstFloat = 2.5F;
           float ourSecondFloat = 5.678F;

           Console.WriteLine("Our first float:");
           Console.WriteLine(ourFirstFloat);

           double ourFirstDouble = 2.5;
           Console.WriteLine("Our first double:");
           Console.WriteLine(ourFirstDouble);

           bool ourFirstBoolean = true;
           bool ourSecondBoolean = false;

           Console.WriteLine("Our first bool:");
           Console.WriteLine(ourFirstBoolean);
           Console.WriteLine("Our second bool:");
           Console.WriteLine(ourSecondBoolean);

           //char is always used with single quotes
           char ourFirstChar = 'a';
           char ourDollarSign = '$';

           Console.WriteLine("Our first char:");
           Console.WriteLine(ourFirstChar);

           Console.WriteLine("Our second char:");
           Console.WriteLine(ourDollarSign);

            Console.WriteLine($"Our first integer {ourFirstInteger}");
            Console.WriteLine($"{ourFirstBoolean} {ourSecondFloat}");

            Console.WriteLine("😊");

            //string is always used with double quotes
            string helloGreeting = "Hello SEDC";

            //concatenation of strings
            //The type of the result of concatenation is always string!!!!!!
            string name = "SEDC";
            string greeting = "Hello";

            Console.WriteLine(greeting + " from " + name + "!");

            //interpolation
            Console.WriteLine($"{greeting} {name}!");

            double result = ourFirstInteger / ourSecondInteger;
            Console.WriteLine($"Result: {result}");

            double doubleResult = ourFirstInteger / (double)ourSecondInteger;
            Console.WriteLine($"Double result: {doubleResult}");

            int defaultInt = default; //0
            Console.WriteLine($"default int: {defaultInt}");

            long defaultLong = default; //0
            Console.WriteLine($"default long: {defaultLong}");


            double defaultDouble = default; //0
            Console.WriteLine($"default double: {defaultDouble}");

            bool defaultBool = default; //false
            Console.WriteLine($"default bool: {defaultBool}");

            char defaultChar = default; //null 
            Console.WriteLine($"default char: {defaultChar}");

            string defaultString = default; //null
            Console.WriteLine($"default string: {defaultString}");


            //.....
            defaultString = "Goodbye from SEDC!";
            Console.WriteLine($"default string: {defaultString}");

            bool firstBool = true;
            bool secondBool = false;

            bool andResult = firstBool && secondBool; //false

            bool orResult = firstBool || secondBool;  //true

            bool negation = !secondBool; //true

            int sum = ourFirstInteger + ourSecondInteger;

            ourFirstInteger = ourFirstInteger + ourSecondInteger;
            ourFirstInteger += ourSecondInteger;

            ourSecondInteger++; //ourSecondInteger = ourSecondInteger + 1;

            bool comparison = ourSecondFloat == ourDollarSign;
        }
    }
}
