using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[5];
            int sumNumbers = 0;

            for(int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                userArray[i] = int.Parse(Console.ReadLine());
                sumNumbers += userArray[i];
            }

            Console.WriteLine("Sum of all numbers is " + sumNumbers);
        }
    }
}
