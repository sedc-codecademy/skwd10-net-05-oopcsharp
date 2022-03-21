using System;
using Task03.Models;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            //User user = new User();
            //user.Id = 1;
            //user.Username = "test";

            users[0] = new User()
            {
                Id = 1,
                Username = "Bob23",
                Password = "mysuperpass",
                Messages = new string[] { "Hey bob! Nice shirt.", "Call me pls!"
                }
            };
            users[1] = new User()
            {
                Id = 2,
                Username = "Paul26",
                Password = "Paul26Paul",
                Messages = new string[] { "Hey Paul!", "How are you?"
                }
            };
            users[2] = new User()
            {
                Id = 3,
                Username = "Ana13",
                Password = "AnaBanana",
                Messages = new string[] { "Hey Ana! Nice hat.", "See you later."
                }
            };

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            User foundUser = FindUser(users, username, password);
            if (foundUser == null)
            {
                Console.WriteLine($"Invalid credentials!");
            }
            else
            {
                Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");
                foreach (string message in foundUser.Messages)
                {
                    Console.WriteLine(message);
                }
            }
        }

        static User FindUser(User[] usersArray, string userName, string password)
        {
            foreach (User user in usersArray)
            {
                if (String.Equals(userName, user.Username, StringComparison.InvariantCultureIgnoreCase) &&
                    String.Equals(password, user.Password))
                {
                    return user;
                }
            }

            return null;
        }
    }
}
