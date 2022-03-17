using System;

namespace Exercise1
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ent4er an operation ( + or -): ");
            string operation = Console.ReadLine();
            if(operation != "+" && operation != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
                return; 
            }
            Console.WriteLine("Enter first number:");
            bool res = int.TryParse(Console.ReadLine(), out int firstNumber);
            if (!res) return;
            Console.WriteLine("Enter second number:");
            res = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (!res) return;
            if (operation == "+") Console.WriteLine(Sum(firstNumber, secondNumber));
            if (operation == "-") Console.WriteLine(Subtract(firstNumber, secondNumber));

            Console.ReadLine();
        }
    }
}
