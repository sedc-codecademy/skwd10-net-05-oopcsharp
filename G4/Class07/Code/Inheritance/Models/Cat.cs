

using System;

namespace Inheritance.Models
{
    public class Cat : Animal
    {
        public string Food { get; set; } //specific for Cat
        //public void PrintInfo()
        //{
        //    Console.WriteLine($"{Id} {Name} {Color}");
        //    //Console.WriteLine($"{_privateProperty}"); - ERROR, private for Animal
        //}

        //Default constructor of Animal will be called (initializes the property Id to a random number)
        public Cat()
        {
            Id = 10;
            Console.WriteLine("Default ctor of Cat is called");
        }

        //The constructor with params of Animal -> (base(name, color))
        //It initializes Id, Name and Color
        public Cat(string name, string color, string food) : base(name, color)
        {
            Food = food;
            Console.WriteLine("Ctor with params of Cat is called");
        }

        public override void Eat(string food)
        {
            Console.WriteLine($"Favourite food of {Name} is {Food}");
            Console.WriteLine($"But now, it is eating {food}");
        }
    }
}
