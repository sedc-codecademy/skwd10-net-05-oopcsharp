using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of 5 whole numbers
            int[] integerArray = new int[5];
            integerArray[0] = 5;
            integerArray[1] = 7;
            integerArray[2] = 3;
            integerArray[3] = 6;
            integerArray[4] = 8;

            string[] stringsArray = { "Ana", "Marko", "Stefan" };

            Console.WriteLine("integerArray:");
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }
        }
    }
}
