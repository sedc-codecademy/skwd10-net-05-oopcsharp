using System;

namespace BranchingExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an option 1 -3");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("You've got a new car");
                    break;
                case 2:
                    Console.WriteLine("You've got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You've got a new bike");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
