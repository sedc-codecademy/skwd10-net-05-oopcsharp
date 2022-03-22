using Exercise2.Classes;
using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete ime na kuceto:");
            string name = Console.ReadLine();

            Console.WriteLine("Vnesete rasa na kuceto:");
            string race = Console.ReadLine();

            Console.WriteLine("Vnesete boja na kuceto:");
            string color = Console.ReadLine();

            Dog dog = new Dog(name, race, color);

            while(true)
            {
                Console.WriteLine("Vnesete \n 1) Eat \n 2) Play \n 3) Chase Tail");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.WriteLine(dog.Eat());
                        break;
                    case "2":
                        Console.WriteLine(dog.Play());
                        break;
                    case "3":
                        Console.WriteLine(dog.ChaseTail());
                        break;
                    default:
                        Console.WriteLine("Pogresen vnese!");
                        break;
                }
            }
        }
    }
}
