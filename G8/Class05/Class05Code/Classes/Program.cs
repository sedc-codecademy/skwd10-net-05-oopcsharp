using Classes.Models;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor -> new
            Person personPaul = new Person();
            Console.WriteLine(personPaul.FirstName); //null
            //private
            //Console.WriteLine(personPaul._ssn);
            //set
            personPaul.Age = 20;
            //set
            personPaul.FirstName = "Paul";
            Console.WriteLine(personPaul.FirstName);
            //set
            personPaul.LastName = "Fischer";
            //personPaul.GenerateSSN(); ->private
            string descriptionPaul = personPaul.GetDescription();
            Console.WriteLine($"Description for Pauls: {descriptionPaul}");

            //  constructor with parameters
            Person bob = new Person("Bob", "Peterson", 25);
            //bob.FirstName = "Gill";
            Console.WriteLine($"Description for Bob: {bob.GetDescription()}");

            //default constructor
            Product car = new Product();
            car.Name = "BMW";
            car.Price = 45566.8;
            car.Code = 123;

            Product pizza = new Product()
            {
                Code = 354,
                Price = 300,
                Name = "Margarita"
            };
            pizza.Buy(200);

            Console.ReadLine();
        }
    }
}
