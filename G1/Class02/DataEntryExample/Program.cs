using System;

namespace DataEntryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string input = Console.ReadLine();
            //Console.WriteLine("You have entered: " + input);

            Console.WriteLine("Vnesi ime: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Vnesi prezime: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Zdravo " + firstName + " " + lastName + "!");
        }
    }
}
