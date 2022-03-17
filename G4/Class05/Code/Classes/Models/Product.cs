

using System;

namespace Classes.Models
{
    public class Product
    {
        //write prop -> tab
        public string Name { get; set; }
        public int Code { get; set; }
        public double Price { get; set; }

        public Product(string name, int code, double price)
        {
            Name = name;
            Code = code;
            Price = price;
        }

        public void Buy(double amount)
        {
            if (Price > amount)
            {
                Console.WriteLine($"You can not buy the product {Name}. The price is {Price}");
            }
            else
            {
                Console.WriteLine($"You can buy the product {Name}. The price is {Price}");
            }
        }

    }
}
