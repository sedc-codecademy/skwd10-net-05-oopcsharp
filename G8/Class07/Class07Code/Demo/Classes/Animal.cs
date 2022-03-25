using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Classes
{
    public class Animal
    {
        // protected members can be accessed in the class  or in the inherired classes
        protected int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        // private member can only be accessed in the class it is defined in
        private string _privateProperty { get; set; }

        public Animal()
        {
            Id = new Random().Next(1, 9999999);
            Console.WriteLine("Parameterless constructor called!");
        }

        public Animal(string name, string color)
        {
            Id = new Random().Next(1, 9999999);
            Name = name;
            Color = color;
            Console.WriteLine("Constructor with parameters was called!");
        }

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Id: {Id}, Name {Name}, Color: {Color}");
        }
        public virtual void Eat(string food)
        {
            Console.WriteLine($"The animal {Name} eats {food}");
        }
    }
}
