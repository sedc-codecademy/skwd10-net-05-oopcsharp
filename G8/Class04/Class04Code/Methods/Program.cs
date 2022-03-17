using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeet();
            GreetSomeone("");
            GreetSomeone("Petre");

            string greeting = GetGreeting("SEDC");
            Console.WriteLine($"Greeting: {greeting}");
            Console.WriteLine(GetGreeting("Angel"));

            Console.WriteLine(GetNumber());

            Program program = new Program();
            program.nonStaticMethod();

            Console.ReadLine();
        }

        // no return
        static void Greeet()
        {
            Console.WriteLine("Hello from our first method!");
            Console.ReadLine();
        }

        // paratemers
        static void GreetSomeone(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("We can not greet the person");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }            

            Console.ReadLine();
        }

        // with return type
        static string GetGreeting(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return $"We can not greet the person";
            }
            return $"Hello {name}";
        }

        // return type is int, the data that is returned is of type int
        static int GetNumber()
        {
            return 3 + 6;
        }

        // non static
        void nonStaticMethod()
        {
            Console.WriteLine("Hello from our non static method!");
        }
    }
}
