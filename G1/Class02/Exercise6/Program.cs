using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete prv broj");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number1))
            {
                Console.WriteLine("Vnesovte nevaliden broj!");
                return;
            }

            Console.WriteLine("Vnesete vtor broj");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input2, out int number2))
            {
                Console.WriteLine("Vnesovte nevaliden broj!");
                return;
            }

            if (number1 > number2)
            {
                Console.WriteLine("Prviot broj e pogolem od vtoriot");
            }
            else if (number2 > number1)
            {
                Console.WriteLine("Vtoriot broj e pogolem od prviot");
            }
            else
            {
                Console.WriteLine("Broevite se isti");
            }

            if (number1 % 2 == 0)
            {
                Console.WriteLine("Prviot broj e paren broj");
            }
            else
            {
                Console.WriteLine("Prviot broj e neparen broj");
            }

            Console.WriteLine(number2 % 2 == 0 
                ? "Vtoriot broj e paren broj" 
                : "Vtoriot broj e neparen broj");
        }
    }
}
