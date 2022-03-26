using System;
using Domain.Enums;

namespace Domain.Models
{
    public class Employee
    {
        protected double Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Salary}$.");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
