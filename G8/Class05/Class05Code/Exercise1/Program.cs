using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine("Enter human first name:");
            human.FirstName = Console.ReadLine();
            Console.WriteLine("Enter human last name:");
            human.LastName = Console.ReadLine();
            Console.WriteLine("Enter human age:");
            human.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(human.GetPersonStats());

            Console.ReadLine();
        }
    }
}
