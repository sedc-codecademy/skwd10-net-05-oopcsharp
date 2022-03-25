using System;
using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            animal.Name = "Sparky";
            //Console.WriteLine(animal.Id); -> PROTECTED
            //Console.WriteLine(animal._privateProperty); -> PRIVATE

            Animal secondAnimal = new Animal("Barnie", "Black");

            animal.PrintInfo();

            Cat cat = new Cat();
            cat.Name = "OurCat";
            cat.Food = "fish";
            cat.PrintInfo();

            AngorCat angorCat = new AngorCat();
            angorCat.Name = "OurAngorCat";
            angorCat.PrintInfo();

            //animal.Eat("meat");
           // cat.Eat("milk");

            Dog dog = new Dog();
            dog.Name = "OurDog";
            dog.Eat("meat");
        }
    }
}
