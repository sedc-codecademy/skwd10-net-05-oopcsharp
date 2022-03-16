using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[10];
            // for homework you can extend the solution with Resize
            for(int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                namesArray[i] = Console.ReadLine();

                Console.WriteLine("Do you want to enter another name(Y / N)");
                string userChoise = Console.ReadLine();
                if (userChoise.ToUpper() == "N") 
                    break;

            }
            foreach(string name in namesArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}
