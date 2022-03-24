using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = Enums.RoleEnum.Manager;
        }
        public void AddBonnus(double bonus)
        {
            _bonus = bonus;
        }
        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
