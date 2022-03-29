using CSharp_G2_EX3.Enteties;
using System;

namespace CSharp_G2_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
                new Customer("Ivan", "Dzikovski", "1111-1111-1111-1111", "1234", 12345),
                new Customer("Petko", "Petkovski", "2222-2222-2222-2222", "1111", 132345),
                new Customer("Mihajlo", "Dimovski", "3333-3333-3333-3333", "3333", 164345)
            };

            
            while (!MainUi())
            {
                Customer selectedCustomer = Login(customers);

                if (selectedCustomer == null)
                {
                    break;
                }

                Console.WriteLine("Please enter pin number");
                string readPin = Console.ReadLine();

                if (!selectedCustomer.CheckPin(readPin))
                {
                    break;
                }

                while (!OfferActions(selectedCustomer))
                {
                    Console.WriteLine("Would you like to continue? (Y/N)");
                    string continueInput = Console.ReadLine();
                    if (continueInput.ToLower() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static bool OfferActions(Customer selectedCustomer)
        {
        Console.WriteLine("Please choose action:");
        Console.WriteLine("a) Check Balance");
        Console.WriteLine("b) Cash Withdrawl");
        Console.WriteLine("c) Cash Deposit");

        string chosenAction = Console.ReadLine().ToLower();

        switch (chosenAction)
        {
            case "a":
                Console.WriteLine($"Your balance is: {selectedCustomer.GetBalance()}");
                break;
            case "b":
                Console.WriteLine("Enter amount");
                bool isValid = int.TryParse(Console.ReadLine(), out var parsedAmount);
                if (isValid)
                {
                    selectedCustomer.WithrawMoney(parsedAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount entered");
                }
                break;
            case "c":
                Console.WriteLine("Enter amount");
                bool isValidDeposid = int.TryParse(Console.ReadLine(), out var parsedDepositAmount);
                if (isValidDeposid)
                {
                    selectedCustomer.Deposit(parsedDepositAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount entered");
                }
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
            };

            return false;
        }

        public static Customer Login(Customer[] customers)
        {
            Console.WriteLine("Please enter card number");
            string enteredNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(enteredNumber))
            {
                Console.WriteLine("Wrong input");
                return null;
            }

            Customer selectedCustomer = null;

            foreach (Customer customer in customers)
            {
                if (customer.CardNumber == enteredNumber)
                {
                    selectedCustomer = customer;
                }
            }

            if (selectedCustomer == null)
            {
                return null;
            }

            return selectedCustomer;
        }

        public static bool MainUi()
        {
            Console.WriteLine("Would you like to login or exit? (L/X)");

            string continueLogin = Console.ReadLine();

            if (continueLogin.ToLower() == "L")
            {
                return true;
            }

            return false;
        }
    }
}
