using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Classes
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public void PrintName()
        {
            Console.WriteLine($"{Name}"); //public 
        }

        public void PrintId()
        {
            Console.WriteLine($"{Id}"); // protected
        }

        //public void PrintPrivateProperty()
        //{
        //    Console.WriteLine($"{_privateProperty}"); // not alloews -> private
        //}

        public Dog()
        {
            Console.WriteLine("Dog's parameterless constructor");
        }

        public void Eat()
        {
            Console.WriteLine("The dogs love to eat");
        }

        public override void Eat(string food)
        {
            //base.Eat(food); -> Animal.Eat
            Console.WriteLine($"The dog {Name} eats {food}");
        }

        public Dog(string name, string color, string race) : base(name, color)
        {
            Race = race;
            Console.WriteLine("Dog's constructor with parameters was called!");
        }
    }
}
