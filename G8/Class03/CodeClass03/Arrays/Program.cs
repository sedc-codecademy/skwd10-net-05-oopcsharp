using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //empty integer array with lenght 3
            int[] emptyIntegerArray = new int[3];
            emptyIntegerArray[0] = 5;
            emptyIntegerArray[1] = 7;
            emptyIntegerArray[2] = 33;

            Console.WriteLine(emptyIntegerArray[1]);
            // emptyIntegerArray[3] = 55; - error, out of range boundaries

            string[] stringArray = { "Filip", "Aleksandar", "Stefani" };
            Console.WriteLine(stringArray[2]);

            Console.WriteLine($"StringArray length: {stringArray.Length}");

            //double[] doubleArray = { 2, 33.3, 44.6, 7, true }; - mixed arrays are not allowed
            double[] doubleArray = { 2, 33.3, 44.6, 7, 68 };
            // doubleArray[5] = 55.9; -exception

            doubleArray[3] = 44;

            //RESIZE
            Array.Resize(ref doubleArray, 7);
            doubleArray[5] = 55.9;

            //INDEX OF
            int indexFound = Array.IndexOf(doubleArray, 44.6);
            Console.WriteLine("Index of 44.6:");
            Console.WriteLine(indexFound);

            int indexNotFound = Array.IndexOf(doubleArray, 5);
            Console.WriteLine("Index of 5:");
            Console.WriteLine(indexNotFound);

            //REVERSE
            Console.WriteLine("===REVERSE===");
            Console.WriteLine(doubleArray[0]);
            Array.Reverse(doubleArray);
            Console.WriteLine(doubleArray[0]);

            string[] names = { "Elena", "Antonio", "Gjorgji", "Jovana", "Bojan" };
            // iterates each member - similar to for-of in JS
            foreach(string name in names)
            {
                Console.WriteLine(name);
                if (name == "Jovana")
                    break;
            }

            Console.ReadLine();
        }
    }
}
