using System;

namespace OperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine("A =" + a);
            Console.WriteLine("B =" + b);

            int sum = a + b;
            Console.WriteLine("Suma =" + sum);
            //a = a + b;
            a += b;
            Console.WriteLine("A =" + a);

            // Ostatok pri delenje na 7 so 12 = 7
            int ostatokPriDelenje = b % a;
            Console.WriteLine("Ostatok pri delenje = " + ostatokPriDelenje);

            a = a + 1;
            a++;
            b = b - 1;
            b--;

            // Ostatok pri delenje na 7 so 5 = 2
            int c = 5;
            int d = 7;
            int ostatokPriDelenje2 = d % c;
            Console.WriteLine("Ostatok pri delenje 2 = " + ostatokPriDelenje2);

            int result = d / c;
            Console.WriteLine("Vrednosta na result = " + result);

            float decimalResult = d / (float) c;
            Console.WriteLine("Vrednosta na decimalResult = " + decimalResult);

            int num1 = 10;
            decimal num2 = 3;
            decimal res = num1 / num2;
            Console.WriteLine("Vrednosta na res = " + res);

            //Exercise 2
            string name = "Risto";
            string lastName = "Panchevski";
            string fullName = name + " " + lastName;
            Console.WriteLine("Vrednosta na fullName = " + fullName);

            string firstNumber = "9";
            string secondNumber = "3";
            string sumResult = firstNumber + secondNumber;
            Console.WriteLine("Vrednosta na sumResult = " + sumResult);

            //Exercise 3
            int n = 100;
            string text = "10";
            string r = n + text;
            Console.WriteLine("Vrednosta na r = " + r);
        }
    }
}
