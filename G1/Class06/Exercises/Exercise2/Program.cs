using Exercise2.Classes;
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUI(StaticDb());
        }

        static User[] StaticDb()
        {
            User[] users = new User[3];
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

            return users;
        }

        static void GenerateText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void MyUI(User[] users)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose\n1.)Log in\n2.)Register\n3.)Exit");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);

                if (!isNumber)
                {
                    GenerateText("Invalid input, try again...", ConsoleColor.Red);
                    continue;
                }

                if (choice == 1)
                {
                    Console.Clear();
                    GenerateText("Enter username", ConsoleColor.Blue);
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        GenerateText("You must enter a username!", ConsoleColor.Red);
                        Console.Read();
                        continue;
                    }

                    GenerateText("Enter password", ConsoleColor.Blue);
                    string password = Console.ReadLine();

                    if (string.IsNullOrEmpty(password))
                    {
                        GenerateText("You must enter a password.", ConsoleColor.Red);
                        Console.Read();
                        continue;
                    }

                    Login(users, username, password);
                    Console.Read();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    GenerateText("Enter new ID:", ConsoleColor.Blue);
                    int id;

                    if (!int.TryParse(Console.ReadLine(), out id))
                    {
                        GenerateText("Please enter a number.", ConsoleColor.Red);
                        Console.Read();
                        continue;
                    }

                    GenerateText("Enter new username:", ConsoleColor.Blue);
                    string newUsername = Console.ReadLine();

                    if (string.IsNullOrEmpty(newUsername))
                    {
                        GenerateText("You must enter a username.", ConsoleColor.Red);
                        Console.Read();
                        continue;
                    }

                    GenerateText("Enter new password:", ConsoleColor.Blue);
                    string newPassword = Console.ReadLine();

                    if (string.IsNullOrEmpty(newPassword))
                    {
                        GenerateText("You must enter a password.", ConsoleColor.Red);
                        Console.Read();
                        continue;
                    }

                    Register(users, newUsername, newPassword, id);
                    Console.Read();
                }
                else if (choice == 3)
                {
                    GenerateText("Goodbye", ConsoleColor.Yellow);
                    Console.Read();
                    break;
                }
                else
                {
                    GenerateText("Please enter 1,2 or 3.", ConsoleColor.Red);
                    Console.Read();
                    continue;
                }
            }
        }

        static User FindUser(User[] users, string username, string password = null)
        {
            if (!string.IsNullOrEmpty(password))
            {
                foreach (User user in users)
                {
                    if (user.Username.ToLower() == username.ToLower() && user.Password == password)
                        return user;
                }
            }

            return null;
        }

        static void Login(User[] users, string username, string password)
        {
            Console.Clear();
            User user = FindUser(users, username, password);

            if (user == null)
            {
                GenerateText("User not found.", ConsoleColor.Red);
                Console.Read();
                return;
            }

            GenerateText("==================================", ConsoleColor.Green);
            GenerateText($"Welcome {user.Username} !!!", ConsoleColor.Green);
            GenerateText("Your messages:", ConsoleColor.Green);
            foreach (string message in user.Messages)
            {
                GenerateText(message, ConsoleColor.Green);
            }
            GenerateText("==================================", ConsoleColor.Green);
        }

        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username);

            if (user != null)
            {
                GenerateText("User already exists.", ConsoleColor.Red);
                Console.Read();
                return;
            }

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };

            GenerateText("Successfully registered new User!", ConsoleColor.Green);
            GenerateText("Users so far:", ConsoleColor.Yellow);

            foreach (User u in users)
            {
                GenerateText($"ID: {u.Id} - {u.Username}", ConsoleColor.Yellow);
            }
        }
    }
}
