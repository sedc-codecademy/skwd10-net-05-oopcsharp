using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Greet();
            GreetSomeone("Tanja");

            string greeting = GetGreeting("Radmila");
            Console.WriteLine($"greeting: {greeting}");

            int sum = Sum(5, 2);
            Console.WriteLine($"The sum is: {sum}");
        }


        //no return, no parameters
        static void Greet()
        {
            Console.WriteLine("Hello from SEDC");
        }

        static void GreetSomeone(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static string GetGreeting(string name)
        {
            return $"Hello dear {name}";
        }

        static int Sum(int num1, int num2)
        {
            Console.WriteLine($"Calculating sum of {num1} and {num2}");
            return num1 + num2;

           // Console.ReadLine(); - UNREACHABLE!!!
        }
    }
}
