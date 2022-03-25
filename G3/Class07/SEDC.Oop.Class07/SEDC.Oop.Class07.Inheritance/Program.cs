using SEDC.Oop.Class07.Inheritance.Models;
using System;

namespace SEDC.Oop.Class07.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Name = "Dambo", Id = 5, Type = "Elephant", Race = "WhiteOnes" };
            animal.Eat();
            Console.WriteLine();


            Dog dog = new Dog() { Name = "Sparky", Id = 2, Type = "Dog", Race = "Striter", IsPlayfull = true };
            dog.Eat();
            //dog.DogEat();
            Console.WriteLine();


            Cat cat = new Cat() { Name = "Garfield", Id = 1, Race = "Cat", Type = "YellowCat", IsLazy = true };
            cat.Eat();
            Console.WriteLine();

            //Dog dog2 = new Dog("Sparky2", "Dog");

            //Cat cat2 = new Cat("Cat2", "Cat", "NoRace", true);


            Console.ReadLine();
        }
    }
}
