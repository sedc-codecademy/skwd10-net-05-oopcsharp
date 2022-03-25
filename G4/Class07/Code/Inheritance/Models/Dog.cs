
using System;

namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        //specific ONLY for class Dog
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking..");
        }

        public override void Eat(string food)
        {
            base.Eat(food); //Animal.Eat(food)
            Console.WriteLine($"The dog {Name} is eating {food}");
        }
    }
}
