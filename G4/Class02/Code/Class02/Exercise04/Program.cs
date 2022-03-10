using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCredits = 102;
            int smsCredits = 5;
            int numberOfMessages = totalCredits / smsCredits;

            int remainingCredits = totalCredits % smsCredits;

            Console.WriteLine($"You can send {numberOfMessages} messages, and there will be {remainingCredits} remaining credits");
        }
    }
}
