using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello", "Hi", "Wow", "Words", "Dinosaur" };
            double[] decimals = new double[] { 2.4, 5.4474, 0.00009, 18.9, 999.0002 };
            char[] characters = new char[] { 'b', 'c', '0', '#', '}' };
            bool[] booleans = new bool[] { true, false, false, true, false };
            int[][] arraysOfInts = new int[][] {
                new int[] {2, 4 },
                new int[] {-6, 12},
                new int[] {0, 99, 3},
                new int[] {32, 27},
                new int[] {9999, 50}
            };
            Console.WriteLine("Words: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Decimals: ");
            foreach (double dec in decimals)
            {
                Console.WriteLine(dec);
            }
            Console.WriteLine("Characters: ");
            foreach (double character in characters)
            {
                Console.WriteLine(character);
            }
            Console.WriteLine("Booleans: ");
            foreach (bool boolean in booleans)
            {
                Console.WriteLine(boolean);
            }
            Console.WriteLine("Integers: ");
            foreach (int[] arrayInteger in arraysOfInts)
            {
                foreach (int integer in arrayInteger)
                {
                    Console.WriteLine(integer);
                }
            }

            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        }
    }
}
