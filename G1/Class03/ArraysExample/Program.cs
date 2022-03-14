using System;

namespace ArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            //numbers = new int[2];
            numbers[0] = 5;
            numbers[1] = 7;

            int[] numbersArray = new int[2] { 2, -10};

            float[] koeficienti = new float[] {1.5F, 2.50F, 3.2F, 1.7F, 4};

            Console.WriteLine(koeficienti[2]);

            string[] names = new string[5] {"Risto", "Dejan", "Test", "Dejan", "R"};
            Console.WriteLine(names[0]);
            int index = Array.LastIndexOf(names, "Darko");
            string lastElement = names[names.Length - 1];
            Console.WriteLine(index);
            //Console.WriteLine(names[5]); - throws exception

            Console.WriteLine(names.Length);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Array.Reverse(names);

            string[] cars = new string[] { "Toyota", "Renault", "Peugeot" };
            string[] carsCopy = new string[3];
            cars.CopyTo(carsCopy, 0);

            cars[0] = "bmw";
            int increase = 5;

            Array.Resize(ref cars, cars.Length + increase);
            
            string s = cars[3];

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
