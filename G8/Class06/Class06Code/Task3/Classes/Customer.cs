using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int _pin { get; set; }
        private int _accountBalance { get; set; }
        public Customer(string firstName, string lastName, long cardNumber, int pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            _pin = pin;
            _accountBalance = balance;
        }
        public bool CheckPin(int pin)
        {
            if (_pin == pin) return true;
            return false;
        }
        public int GetAccountBalance()
        {
            return _accountBalance;
        }
        public bool MakeWithdrawal(int amount)
        {
            if (amount > _accountBalance)
                return false;
            _accountBalance -= amount;
            return true;
        }
        public void MakeDeposit(int amount)
        {
            _accountBalance += amount;
        }

    }
}
