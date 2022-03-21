using System;
using System.Text;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            User user1 = new User();
            user1.LastName = "Panchevski";
            user1.Email = "r@gmail.com";
            user1.DateOfBirth = new DateTime(1989, 7, 20);
            user1.FirstName = "Risto";

            User user3 = new User()
            {
                FirstName = "Bojan",
                LastName = "Damcevski",
                DateOfBirth = DateTime.Today.AddYears(-20),
                Email = "bojan@gmail.com"
            };

            Console.WriteLine("Vnesete ime:");
            string input = Console.ReadLine();
            User user2 = new User(input, "Panchevski", new DateTime(1989, 7, 20), "risto@gmail.com");

            Console.WriteLine($"{user2.FirstName} {user2.LastName}");
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user3);
            Console.WriteLine(user3.ToString());
        }
    }
}
