using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_G2_EX3.Enteties
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        private string pin;
        private int balance;

        public Customer(string firstName, string lastName, string cardNumber, string pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public int GetBalance()
        {
            return balance;
        }

        public bool CheckPin(string enteredPin)
        {
            return enteredPin == pin;
        }

        public void WithrawMoney(int ammount)
        {
            if (ammount > balance)
            {
                Console.WriteLine("You don't have enough money");
                return;
            }

            balance = balance - ammount;
            Console.WriteLine($"You have withdrawn {ammount}");
            Console.WriteLine($"You have {balance} left");
        }

        public void Deposit(int ammount)
        {
            balance = balance + ammount;
            Console.WriteLine($"You have deposite {ammount}");
            Console.WriteLine($"Your new balance is {balance}");
        }
    }
}
