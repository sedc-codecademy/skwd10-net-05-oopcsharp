

using System;

namespace Inheritance.Models
{
    public class Animal
    {
        //protected members can be accessed in base class (Animal) and  in the inherited classes (Cat, Dog) 
        protected int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        //this property belongs ONLY to Animal, and ONLY Animal knows about it
        private int _privateProperty { get; set; }

        public Animal()
        {
            Id = new Random().Next(1, 9999);
            Console.WriteLine("Default ctor of Animal is called");
        }

        public Animal(string name, string color)
        {
            Id = new Random().Next(1, 9999);
            Name = name;
            Color = color;
            Console.WriteLine("Ctor with params of Animal is called");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Id} {Name} {Color} {_privateProperty}");
        }

        public virtual void Eat(string food)
        {
            Console.WriteLine($"The animal {Name} eats {food}");
        }
    }
}
