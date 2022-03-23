using CSharp_G2_Class6_EX2.Entities;
using System;

namespace CSharp_G2_Class6_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users =
            {
                new User(1, "mikid", "mikid", new string[] { "Hello Miki.", "How are you?" }),
                new User(2, "ivandz", "ivandz", new string[] { "Hello Ivan.", "How are you?" }),
                new User(3, "acekn", "acekn", new string[] { "Hello Ace.", "How are you?" })
            };

            Console.WriteLine("Do you want to (L)og In or (R)egister?");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "l":
                    LogIn(users);
                    break;
                case "r":
                    Register(users);
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }       
        }

        private static void Register(User[] users)
        {
            Console.WriteLine("Enter your id (only numbers allowed): ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int id);

            if (!isValidInput)
            {
                Console.WriteLine("The entered ID is not valid!");
                return;
            }

            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            if (string.IsNullOrEmpty(username)) // null, ""
            {
                Console.WriteLine("Invalid username. Username cannot be empty!");
                return;
            }

            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(password)) // null, ""
            {
                Console.WriteLine("Invalid password, Password cannot be empty!");
                return;
            }

            User user = FindUserByUserName(username, users);

            if (user != null)
            {
                Console.WriteLine($"{user.Username} is taken.");
                return;
            }

            user = new User(id, username, password, new string[] { });

            Array.Resize(ref users, users.Length + 1);

            users[users.Length - 1] = user;

            Console.WriteLine($"Registation of user {user.Username} was successful!");

            PrintUsers(users);
        }

        private static void PrintUsers(User[] users)
        {
            foreach (User user in users)
            {
                string userInfo = user.GetIdAndUsername();
                Console.WriteLine(userInfo);
            }
        }

        private static void LogIn(User[] users)
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            if (string.IsNullOrEmpty(username)) // null, ""
            {
                Console.WriteLine("Invalid username. Username cannot be empty!");
                return;
            }

            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(password)) // null, ""
            {
                Console.WriteLine("Invalid password, Password cannot be empty!");
                return;
            }

            User user = FindUserByUserName(username, users);

            if (user == null || !(user.Password == password))
            {
                Console.WriteLine("Invalid username or password!");
                return;
            }

            Console.WriteLine($"Welcome {user.Username}. Here are your messages: ");
            user.PrintMessages();
        }

        private static User FindUserByUserName(string username, User[] users)
        {
            User foundUser = null;

            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    foundUser = user;
                    break;
                }
            }

            return foundUser;
        }
    }
}
