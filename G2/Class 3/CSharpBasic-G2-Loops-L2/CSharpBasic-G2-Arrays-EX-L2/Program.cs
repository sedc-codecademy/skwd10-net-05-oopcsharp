using System;

namespace CSharpBasic_G2_Arrays_EX_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            string[] words = new string[] { "one", "two", "three", "four", "five" };
            decimal[] decimalNumbers = new decimal[5];
            decimalNumbers[0] = 2.4m;
            decimalNumbers[1] = 3.4m;
            decimalNumbers[2] = 6.7m;
            decimalNumbers[3] = 5.4m;
            decimalNumbers[4] = 0.1m;

            bool[] booleanArray = { true, true, false, false, true };

            char[] charArray = { 'q', 'w', 'e', 'r', 't' };

            int[][] arrayOfArrays =
            {
                new int[] {1,0},
                new int[] {3,6},
                new int[] {4,8},
                new int[] {10,20},
                new int[] {4,9}
            };

            foreach (int[] array in arrayOfArrays)
            {
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            //Ex 2

            int[] niza = new int[5];

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Enter number {i}");
                string number = Console.ReadLine();
                int.TryParse(number, out int parsedNumber);
                niza[i] = parsedNumber;
            }

            int sum = 0;
            foreach(int number in niza)
            {
                sum += number;
            }

            Console.WriteLine($"The sum of all values in the array is {sum}");
        }
    }
}
