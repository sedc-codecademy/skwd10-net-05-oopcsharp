using Models;
using System;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("John", "Johnsky", Role.Other, 300);
            SalesPerson s = new SalesPerson("Bob", "Bobsky");
            Manager m = new Manager("Petko", "Petkovski", 2000);


            s.AddSuccessRevenue(200);
            s.AddSuccessRevenue(800);
            s.AddSuccessRevenue(1200);

            m.AddBonus(1000);

            //Console.WriteLine($"{e.FullName}: {e.GetSalary()}");
            //Console.WriteLine($"{s.FullName}: {s.GetSalary()}");
            //Console.WriteLine($"{m.FullName}: {m.GetSalary()}");

            Console.WriteLine($"{e.GetInfo()}");
            Console.WriteLine($"{s.GetInfo()}");
            Console.WriteLine($"{m.GetInfo()}");
        }
    }
}
