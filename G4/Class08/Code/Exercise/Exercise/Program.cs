using System;
using Domain.Enums;
using Domain.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Marko",
                LastName = "Markovski",
                Role = RoleEnum.Other
            };
            employee.PrintInfo();

            SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            salesPerson.AddSuccessRevenue(300);
            //GetSalary from SalesPerson is called
            Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Bill", "Billsky", 700);
            //GetSalary from Manager is called
            Console.WriteLine(manager.GetSalary());
            manager.AddBonus(200);
            manager.AddBonus(100);
            //GetSalary from Manager is called
            Console.WriteLine(manager.GetSalary());

        }
    }
}
