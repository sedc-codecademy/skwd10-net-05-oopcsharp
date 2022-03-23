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

            Console.WriteLine("Please enter card number");
            string enteredNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(enteredNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Customer selectedCustomer = null;

            foreach(Customer customer in customers)
            {
                if (customer.CardNumber == enteredNumber)
                {
                    selectedCustomer = customer;
                }
            }

            if (selectedCustomer == null)
            {
                return;
            }

            Console.WriteLine("Please enter pin number");
            string readPin = Console.ReadLine();

            if (!selectedCustomer.CheckPin(readPin))
            {
                return;
            }
        }
    }
}
