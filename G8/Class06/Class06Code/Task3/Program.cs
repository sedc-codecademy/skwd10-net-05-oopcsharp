using System;
using Task3.Classes;

namespace Task3
{
    class Program
    {
        static bool ChooseOption(Customer customer)
        {
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Cash Withdrawal");
            Console.WriteLine("3) Cash Deposit");
            Console.WriteLine("4) Exit");
            int choice;
            bool isChoiceNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isChoiceNumber)
            {
                Console.WriteLine("That was not a number. Please try again.");
                return false;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine(string.Format("Your balance is: {0:C}", customer.GetAccountBalance()));
                    break;
                case 2:
                    Console.WriteLine("How much would you like to withdraw?");
                    int amount = 0;
                    bool isAmountWNumber = int.TryParse(Console.ReadLine(), out amount);
                    if (!isAmountWNumber)
                    {
                        Console.WriteLine("Input was not correct. The balance was not changed.");
                        break;
                    }
                    bool withdrawl = customer.MakeWithdrawal(amount);
                    if (!withdrawl)
                    {
                        Console.WriteLine("You don't have enough money on your account!");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("You withdrawed {0:C}. You have {1:C} left on your account.", amount, customer.GetAccountBalance()));
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter amount of deposit:");
                    int amountD = 0;
                    bool isAmountDNumber = int.TryParse(Console.ReadLine(), out amountD);
                    if (!isAmountDNumber)
                    {
                        Console.WriteLine("Input was not correct. The balance was not changed.");
                        break;
                    }
                    customer.MakeDeposit(amountD);
                    Console.WriteLine(string.Format("You deposited {0:C}. You have {1:C} on your account.", amountD, customer.GetAccountBalance()));
                    break;
                case 4:

                    return true;
                default:
                    Console.WriteLine("The number should be one of the options. Please try again.");
                    return false;
            }
            Console.WriteLine("Enter anything for another action or X to exit... ");
            if (Console.ReadLine().ToUpper() != "X")
                return false;
            return true;
        }
        static Customer FindCustomer(Customer[] customers, long cardNumber)
        {
            foreach (Customer customer in customers)
            {
                if (customer.CardNumber == cardNumber) return customer;
            }
            return null;
        }
        static long FormatCardNumber(string stringNumber)
        {
            string[] numbers = stringNumber.Split('-');
            if (numbers.Length != 4) return -1;
            long number = -1;
            bool isNumber = long.TryParse(numbers[0] + numbers[1] + numbers[2] + numbers[3], out number);
            //bool isNumber = long.TryParse(stringNumber, out number);
            if (!isNumber) return -1;
            return number;
        }
        static bool InitATM(Customer[] customers)
        {
            Console.WriteLine("Welcome to the ATM App");
            Console.WriteLine("Please enter your card number");
            long cardNumber = FormatCardNumber(Console.ReadLine());
            if (cardNumber == -1)
            {
                Console.WriteLine("Your card number is incorrect. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }
            Customer customer = FindCustomer(customers, cardNumber);
            if (customer == null)
            {
                Console.WriteLine("That customer does not exist. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("Please enter your PIN:");
            short pin = 0;
            bool isPinNumber = short.TryParse(Console.ReadLine(), out pin);
            if (!isPinNumber)
            {
                Console.WriteLine("Pin must be a number. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }
            if (!customer.CheckPin(pin))
            {
                Console.WriteLine("The pin was not correct. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");
            while (!ChooseOption(customer))
                Console.Clear();
            Console.WriteLine("Enter X to exit the application or anything to login as another user.");
            if (Console.ReadLine().ToUpper() == "X")
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[] {
                new Customer("Bob","Bobsky", 1234123412341234, 1234, 750),
                new Customer("Jill","Wayne", 8235823582358235, 9000, 1200),
                new Customer("Rayan","Dawn", 0090119122923393, 2500, 500),
                new Customer("Anne","May", 0000220311012203, 0000, 400)
            };
            while (!InitATM(customers)) Console.Clear();
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
