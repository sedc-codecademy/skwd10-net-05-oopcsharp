using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Director : Employee
    {
        public Director(int id, string firstName, string lastName, DayOfWeek workingDay) : base(id, firstName, lastName, workingDay)
        {
        }

        public void FireEmployee(Employee employee)
        {
            Console.WriteLine($"The director {FirstName} {LastName} has fired {employee.FirstName} {employee.LastName}");
        }

        public void GiveOrder()
        {
            Console.WriteLine($"The director {FirstName} has given an order");
        }

        public override void DoWork()
        {
            Console.WriteLine("I am the director");
            base.DoWork();
        }
    }
}
