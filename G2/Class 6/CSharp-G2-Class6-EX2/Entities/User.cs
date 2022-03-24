using System;

namespace CSharp_G2_Class6_EX2.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    
        public string[] Messages { get; set; }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }

        public void PrintMessages()
        {
            foreach (string message in Messages)
            {
                Console.WriteLine(message);
            }
        }

        public string GetIdAndUsername()
        {
            return $"{Id} {Username}";
        }
    }
}
