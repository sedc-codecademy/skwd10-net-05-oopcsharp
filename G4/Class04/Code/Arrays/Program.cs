using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doublesArray = { 33.2, 2, 44.4, 78, 9, 6 };
            Console.WriteLine(doublesArray[1]);
            //Console.WriteLine(doublesArray[6]); -> index out of bounds

            //RESIZE
            Array.Resize(ref doublesArray, 7);
            doublesArray[6] = 66.6;
            Console.WriteLine(doublesArray[6]);

            //INDEX OF - returns index of a found element, returns -1 if the element is not found
            int indexOfTwo = Array.IndexOf(doublesArray, 2);
            Console.WriteLine($"Index of two in doublesArray: {indexOfTwo}");

            int indexOfEighty = Array.IndexOf(doublesArray, 80);
            Console.WriteLine($"Index of eighty : {indexOfEighty}");

            //REVERSE
            Console.WriteLine(doublesArray[0]);
            Array.Reverse(doublesArray);
            Console.WriteLine(doublesArray[0]);

            for (int i = 0; i < doublesArray.Length; i++)
            {
                Console.WriteLine($"doublesArray[{i}] : {doublesArray[i]}");
            }

            //FOREACH
            Console.WriteLine("===for each====");
            foreach (double item in doublesArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===for each with break====");
            foreach (double item in doublesArray)
            {
                if (item == 44.4)
                {
                    break;
                }
                Console.WriteLine(item);
            }
        }
    }
}
