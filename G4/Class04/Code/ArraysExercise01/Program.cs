using System;

namespace ArraysExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integersArray = new int[5];

            for (int i = 0; i < integersArray.Length; i++)
            {
                Console.WriteLine($"Enter a value for index: {i}");
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (!success)
                {
                    throw new Exception($"Invalid input for index: {i}");
                }

                integersArray[i] = number;
            }

            int sum = 0;
            foreach (int item in integersArray)
            {
                sum += item;
            }

            Console.WriteLine($"THe sum is: {sum}");
        }
    }
}
