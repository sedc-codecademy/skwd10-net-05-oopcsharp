using System;
using Exercise.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            //dog._name = null;
            //dog.Name = "";

            dog.Color = "brown";
            dog.Breed = "Labrador";

            //dog.SetName(""); -> THROWS EXCEPTION
            dog.SetName("Sparkie");
        }
    }
}
