using System;

namespace MethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password: ");
            string password = Console.ReadLine();

            string result = Login(username, password);
            Console.WriteLine(result);

            SignOut();
        }

        public static string Login(string username, string password)
        {
            string correctPassword = "test123";

            if(password != correctPassword)
            {
                return "Wrong password";
            }

            return "Welcom " + username + "!";
        }

        private static void SignOut()
        {
            Console.WriteLine("Sign out!");
        }
    }
}
