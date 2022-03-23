using Exercise3.Classes;
using System;

namespace Exercise3
{
    class Program
    {
        static Customer FindCustomer(Customer[] customers, string cardNumber)
        {
            foreach(Customer customer in customers)
            {
                if(customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }

            return null;
        }
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
                new Customer("Bob","Bobsky","1234123412341234",1234,750),
                new Customer("Jill","Wayne","1234123412341232",1244,1750),
                new Customer("John","Smith","1234123412341222",1334,2750),
                new Customer("Anne","May","1234123412341555",1234,250)
            };

            Console.WriteLine("Welcome to our ATM");
            Console.WriteLine("Enter card number");

            string cardNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("You must enter the card number");
            }
            else
            {
                Customer customer = FindCustomer(customers, cardNumber);

                if(customer == null)
                {
                    Console.WriteLine("Customer not found");
                    return;
                }
                Console.WriteLine("Enter pin");
                bool success = int.TryParse(Console.ReadLine(), out int pin);
                if (success)
                {
                    if (customer.CheckPin(pin))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin");
                        return;
                    }
                }
            }
        }
    }
}
