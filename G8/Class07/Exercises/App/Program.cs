using Domain.Classes;
using Domain.Enums;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Ed",
                LastName = "Sheeran",
                Role = RoleEnum.Manager
            };
            Console.WriteLine(employee.GetInfo());

            int enumToInt = (int)employee.Role;
            Console.WriteLine(enumToInt);

            SalesPerson salesPerson = new SalesPerson("Zara", "Larsson");
            salesPerson.AddSuccessRevenue(400);
            Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Tom", "Cruise", 1200);
            Console.WriteLine(manager.GetSalary());
            manager.AddBonnus(250);
            Console.WriteLine(manager.GetSalary());

            Console.ReadLine();
        }
    }
}
