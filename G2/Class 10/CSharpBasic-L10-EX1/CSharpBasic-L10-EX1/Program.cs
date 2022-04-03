using Enteties;
using System;
using System.Collections.Generic;

namespace CSharpBasic_L10_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(2, "Ivan", "Djikovski", DayOfWeek.Saturday);
            Worker worker = new Worker(3, "Miki", "Dimovski", DayOfWeek.Monday);
            Director director = new Director(4, "Petko", "Petkovski", DayOfWeek.Thursday);
            Manager manager = new Manager(6, "FirstName", "LastName", DayOfWeek.Monday, "HR");
            Contractor contractor = new Contractor(5, "Stanko", "Stankovski", DayOfWeek.Wednesday, 40, 10, manager);

            employee.DoWork();
            worker.DoWork();
            director.DoWork();

            Console.WriteLine($"The salary of {contractor.FirstName} is {contractor.GetSalary()}");

            List<Employee> company = new List<Employee>() {  new Contractor(1, "Dragan", "Draganovski", DayOfWeek.Friday, 12.5, 5, manager),
                                                             new Contractor(7, "Perica", "Dautovski", DayOfWeek.Monday, 10.5, 5, manager),
                                                             new Manager(8, "Peter", "Griffin", DayOfWeek.Saturday, "HR"),
                                                             new Manager(9, "Nikola", "G", DayOfWeek.Sunday, "HR")
                                                            };

            CEO ceo = new CEO(10, "Bill", "Gates", DayOfWeek.Monday, 100, 1000, company);

            Console.WriteLine($"The CEO is : {ceo}");
            ceo.PrintEmployees();
            Console.WriteLine(ceo.GetSalary());    
        }
    }
}
