using System;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //new -> constructor is called
            Person person = new Person();
            //Age is public
            person.Age = 27;
            person.FirstName = "Tanja";
            person.LastName = "Stojanovska";

            //_ssn is private and is not visible outside the Person class
            //person._ssn = 425235;

            string description = person.GetDescription();
            //prints the namespace + class name
            Console.WriteLine(person);
            Console.WriteLine(description);


            Person secondPerson = new Person();
            secondPerson.Age = 30;


            Person anotherPerson = new Person("Petko", "Petkovski", 30);
            Console.WriteLine(anotherPerson.GetDescription());

            //anotherPerson.GenerateSSN(); -> PRIVATE

            Product firstProduct = new Product("Bread", 111, 37);
            firstProduct.Buy(40);
        }
    }
}
