using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj od 1-3");
            string input = Console.ReadLine(); //"1", "2", "3" 

            switch(input)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Wrong number!");
                    break;
            }
        }
    }
}
