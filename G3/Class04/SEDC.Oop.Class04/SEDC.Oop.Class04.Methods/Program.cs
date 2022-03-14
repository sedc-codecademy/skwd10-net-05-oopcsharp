using System;

namespace SEDC.Oop.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            int result = Sum(1, 2);
            Console.WriteLine(result);

            string strResult = WelcomeUser("Trajan", 33, true);
            Console.WriteLine(strResult);


            Console.ReadLine();
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello SEDC!");
        }

        private static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        internal static string WelcomeUser(string userName, int age, bool shouldBeColored)
        {
            if(shouldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            string str = string.Empty;

            if(age > 30)
            {
                str = "Welcome mr." + userName;
            }
            else
            {
                str = "Welcome " + userName;
            }


            return str;
        }
    }
}
