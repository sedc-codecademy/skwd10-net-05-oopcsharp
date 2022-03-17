using SEDC.Oop.Class05.Classes.Models;
using System;

namespace SEDC.Oop.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 33;
            person.Name = "Trajan";

            person.Talk("Hello World!");

            Person person1 = new Person()
            {
                Age = 22,
                Name = "Vlatko"
            };

            person1.Talk("Hello Students!");

            Person person2 = new Person("Bob", 23);
            person2.Talk("Bob is my name");


            Human human = new Human("Trajan", "Stevkovski", 33);
            HumanInfoResult result = human.GetHumanInfo();

            Console.WriteLine(string.Format("{0} {1}", result.FullName, result.Age));
            Console.WriteLine(result.DateOfBirth);

            //Human h = null;
            //h.Age = 12;

            //if(h == null)
            //{

            //}

            var anonymousObject = new
            {
                Name = "Anonymous Object",
                Quantity = 33
            };


            Console.ReadLine();
        }
    }
}
