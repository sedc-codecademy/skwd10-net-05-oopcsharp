using System;
using System.Collections.Generic;

namespace Enteties
{
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; }

        public int Shares { get; set; }

        private double _sharesPrice;

        public CEO(int id, string firstName, string lastName, DayOfWeek workingDay,
                   int shares, double sharesPrice, List<Employee> employees) : base(id, firstName, lastName, workingDay)
        {
            Shares = shares;
            Employees = employees;
            _sharesPrice = sharesPrice;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            Employees.ForEach(Console.WriteLine);
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Shares * _sharesPrice;
        }
    }
}
