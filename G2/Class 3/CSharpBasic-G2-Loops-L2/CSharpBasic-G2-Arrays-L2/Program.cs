using System;

namespace CSharpBasic_G2_Arrays_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3] { 1, 3, 4};
            int[] intArray2 =  { 1, 3, 4 };


            //intArray[0] = 1;
            //intArray[1] = 2;
            //intArray[2] = 3;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray);

            Array.Reverse(intArray);

            for (int i = 0; i<intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            string[] stringArray = { "One", "Two", "Three", "Four", "One" };

            int indexOfTwo = Array.IndexOf(stringArray, "Two");
            Console.WriteLine($"First appearence of two is in index {indexOfTwo}");

            int indexOfSix = Array.IndexOf(stringArray, "Six");
            Console.WriteLine($"Index of six is {indexOfSix}");

            bool[] boolArray = new bool[3];

            boolArray[0] = true;
            boolArray[1] = true;
            boolArray[2] = false;

            Array.Resize(ref boolArray, 6);

            boolArray[3] = false;

            Console.WriteLine(boolArray[3]);

            string[] workDaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            foreach (string day in workDaysOfWeek)
            {
                Console.WriteLine(Array.IndexOf(workDaysOfWeek, day));
                Console.WriteLine(day);
            }
        }
    }
}
