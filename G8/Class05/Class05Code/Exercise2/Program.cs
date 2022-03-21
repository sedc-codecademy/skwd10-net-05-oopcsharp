using Exercise2.Models;
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter race: ");
            string race = Console.ReadLine();

            //default constructor
            Dog dog = new Dog()
            {
                Color = color,
                Race = race
            };

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            dog.SetName(name);

            Console.WriteLine("Enter option: 1) Eat, 2) Play, 3) Chase tail");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            switch (option)
            {
                case 1:
                    Console.WriteLine(dog.Eat("meet"));
                    break;
                case 2:
                    Console.WriteLine(dog.Play());
                    break;
                case 3:
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;

            }

            Console.ReadLine();
        }
    }
}
