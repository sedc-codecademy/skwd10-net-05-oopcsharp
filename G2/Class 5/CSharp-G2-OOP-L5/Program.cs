using CSharp_G2_OOP_L5.Entities;
using System;

namespace CSharp_G2_OOP_L5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program program = new Program();

            //Program.SayHelloStatic();

            //program.SayHello();

            //Dog dogOne = new Dog()
            //{ 
            //    Name = "Sharko",
            //    Age = 3,
            //    Weight = 30
            //};

            //Console.WriteLine(dogOne.Name);

            bool age;

            Vehicle asdfg = new Vehicle()
            {
                Name = "Volvo",
                Color = "Red",
                NumberOfDoors = 6
            };



            //Dog dogTwo = new Dog { Name = "Bala", Age = 4, Weight = 12 };

            //Console.WriteLine(dogTwo.Name);

            //Console.WriteLine(asdfg.Name);
            //asdfg.TurnOnEngine();

            /*Dog dogThree = new Dog("Sharko");
            Console.WriteLine(dogThree.Name);

            Dog dogFour = new Dog("Dog four", 10, 15);
            Console.WriteLine($"Name: {dogFour.Name} \nAge: {dogFour.Age} \nWeight: {dogFour.Weight}");

            dogFour.ChaseTail();*/


            Console.WriteLine("Please enter a dog name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter a dog race");
            string race = Console.ReadLine();

            Console.WriteLine("Please enter a dog color");
            string color = Console.ReadLine();

            Dog usersDog = new Dog(name, race, color);

            Console.WriteLine("Please enter action (eat, play or chase)");
            string action = Console.ReadLine();

            switch (action.ToLower())
            {
                case "eat":
                    usersDog.Eat();
                    break;
                case "play":
                    usersDog.Play();
                    break;
                case "chase":
                    usersDog.ChaseTail();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

        //static void SayHelloStatic()
        //{
        //    Console.WriteLine("Hello Static");
        //}

        //void SayHello()
        //{
        //    Console.WriteLine("Hello");
        //}
    }
}
