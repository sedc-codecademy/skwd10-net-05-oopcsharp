using System;

namespace CSharp_Basic_G2_Branching_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete dva brooja");
            string firstNumberString = Console.ReadLine();
            string secondNumberString = Console.ReadLine();

            int firstValue = int.Parse(firstNumberString);
            int secondValue = int.Parse(secondNumberString);
            
            // Check if the second value is greater than the first value
            if (secondValue > firstValue)
            {
                Console.WriteLine($"{secondValue} e pogolem od {firstValue}");
            }
            // If the case above is not satisfied, check if the first value is greater
            // than the second
            else if (firstValue > secondValue)
            {
                Console.WriteLine($"{firstValue} e pogolem od {secondValue}");
            }
            // If both cases are not satisfied, execute the else block
            else
            {
                Console.WriteLine("Dvata broja se ednakvi");
            }

            string input;
            input = Console.ReadLine();

            // Switch statement based on the given input
            switch (input)
            {
                // If the value is equal to "a" or "b", print the line below
                case "a":
                case "b":
                {
                    Console.WriteLine("Vnesena e bukvata a ili b");
                }
                // Exit from the switch
                break;
                // If the value is equal to "c", print the line below
                case "c":
                {
                    Console.WriteLine("Vnesena e bukvata c");
                }
                break;
                // If none of the cases above are satisfied, execute the default block
                default:
                {
                    Console.WriteLine("Default block");
                }
                break;
            }
        }
    }
}
