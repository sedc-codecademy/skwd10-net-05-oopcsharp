using Demo.Classes;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            //Console.WriteLine(animal.Id);
            //Console.WriteLine(animal._privateProperty);

            Dog dog = new Dog("Barnie", "Brown", "Labrador");
            Console.WriteLine(dog.Name);
            //Name property is public, inherited from Animal, also belongs to Dog
            dog.Name = "Sparkie";
            Console.WriteLine(dog.Name);
            //Console.WriteLine(dog._privateproperty); -> private property
            //Console.WriteLine(dog.Id); -> protected property

            dog.PrintId();
            // inherited method from Animal
            dog.PrintBasicInfo();
            dog.Eat("Meat");
            dog.Eat();

            Cat cat = new Cat()
            {
                Name = "Garfield",
                Color = "Orange",
                IsLazy = true
            };

            cat.PrintBasicInfo();
            cat.Eat("Fish");

            Console.ReadLine();
        }
    }
}
