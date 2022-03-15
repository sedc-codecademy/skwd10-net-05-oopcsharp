using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a number");
           int number = int.Parse(Console.ReadLine());

           for (int i = 1; i <= number; i++)
           {
               if (i % 3 == 0 || i % 7 == 0)
               {
                   continue;
               }

               if (i == 100)
               {
                   Console.WriteLine("You reached the limit!");
                   break;
               }
               Console.WriteLine(i);
           }
        }
    }
}
