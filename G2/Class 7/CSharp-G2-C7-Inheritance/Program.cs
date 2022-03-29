using CSharp_G2_C7_Inheritance.Entities;
using System;

namespace CSharp_G2_C7_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape("Red");

            //Console.WriteLine($"{shape.Color} is the color of the shape");

            //Circle circle = new Circle(1.5m, "Blue");

            //Console.WriteLine($"{circle.Radius} is the radius of the circle, and the color is {circle.Color}");

            Worker worker = new Worker(1, "Mihajlo", "Dimovski", DayOfWeek.Monday);

            worker.DoWork();
            worker.WriteReport();

            Manager manager = new Manager(2, "Ivan", "Dzikovski", DayOfWeek.Tuesday);
            manager.DoWork();
            manager.ReadReports();
            manager.ModifyWorkingHours();

            Director director = new Director(3, "Dragan", "Ivanov", DayOfWeek.Wednesday);
            director.DoWork();
            director.FireEmployee(manager);
        }
    }
}
