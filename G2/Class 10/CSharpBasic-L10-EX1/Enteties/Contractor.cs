using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager ResponsibleManager { get; set; }

        public Contractor(int id, string firstName, string lastName, DayOfWeek workingDay, double workHours, int payPerHour, Manager responsibleManager) : base(id, firstName, lastName, workingDay)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            ResponsibleManager = responsibleManager;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return WorkHours * PayPerHour;
        }

        public string CurrentPosition()
        {
            return ResponsibleManager.Department;
        }
    }
}
