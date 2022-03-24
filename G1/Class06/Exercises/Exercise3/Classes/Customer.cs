namespace Exercise3.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        private int _pin { get; set; }
        private double _accountBalance { get; set; }

        public Customer(string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            _pin = pin;
            _accountBalance = balance;
        }

        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        public bool CheckPin(int pin)
        {
            return _pin == pin;
        }

        public void MakeDeposit(int amount)
        {
            _accountBalance += amount;
        }

        public bool MakeWithdrawal(int amount)
        {
            if(amount > _accountBalance)
                return false;

            _accountBalance -= amount;
            return true;
        }
    }
}
