using System;

namespace SEDC.Oop.Class03.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[4] = 5;

            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[4]);

            // numbers[5] = 10;

            string[] names = new string[] 
            {
                "Trajan",
                "Vlatko",
                "Stefan",
                "Aneta"
            };

            // names[4] = "Bob";

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            bool[] booleans = new[] { true, false, true };

            double[] doubles = { 1.1, 1.2, 1.3 };


            string[] names1 = new string[]
            {
                "Trajan",
                "Vlatko",
                "Stefan",
                "Aneta"
            };

            int lenghtOfArray = names1.Length;

            for(int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            int indexOnVlatko = Array.IndexOf(names1, "Vlatko");
            Console.WriteLine("The index is: " + indexOnVlatko);
            Console.WriteLine("The value is: " + names1[indexOnVlatko]);

            Array.Resize(ref names1, names1.Length + 2);

            names1[4] = "Bob";
            names1[5] = "Jill";

            Array.Sort(names1);

            for (int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            string[] strs = new string[2];
            Console.WriteLine("aaaa " + strs[0]);

            foreach(string element in names1)
            {
                Console.WriteLine("Foreach with names: " + element);
            }

            foreach(string name in names1)
            {
                if(name == "Aneta")
                {
                    continue;
                }

                if(name == "Trajan")
                {
                    break;
                }
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
