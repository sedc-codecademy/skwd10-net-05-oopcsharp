using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Classes
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        //specific method for Cat
        public void Talk()
        {
            Console.WriteLine($"The cat {Name} is talking");
        }
        //We override the default constructor
        //The default constructor of the base class will be called
        public Cat()
        {
            Console.WriteLine("Cat's parameterles constructor");
        }
        public override void Eat(string food)
        {
            //base.Eat(food); -> Animal.Eat
            Console.WriteLine($"The cat {Name} eats {food}");
        }
    }
}
