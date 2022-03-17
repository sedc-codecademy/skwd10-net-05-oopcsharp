using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            int firstNumber;
            int secondNumber;
            string calculatorOperator;

            while(true)
            {
                Console.WriteLine("Please enter first number:");
                string input = Console.ReadLine();

                if(int.TryParse(input, out firstNumber))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter second number:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out secondNumber))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter an operator (+, -, *):");
                calculatorOperator = Console.ReadLine();

                if (calculatorOperator == "+" || 
                    calculatorOperator == "-" || 
                    calculatorOperator == "*")
                {
                    break;
                }
            }

            Console.WriteLine("The result is: ");
            switch (calculatorOperator)
            {
                case "+":
                    Console.WriteLine(Sum(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine(Subtract(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine(Multiply(firstNumber, secondNumber));
                    break;
            }


            //int result = 0;
            //switch(calculatorOperator)
            //{
            //    case "+":
            //        result = Sum(firstNumber, secondNumber);
            //        break;
            //    case "-":
            //        result = Subtract(firstNumber, secondNumber);
            //        break;
            //}

            //Console.WriteLine(result);
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

    }
}
