using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(int id, string firstName, string lastName, DayOfWeek workingDay, string departmet) : base(id, firstName, lastName, workingDay)
        {
            Department = departmet;
        }

        public void ReadReports()
        {
            Console.WriteLine($"The manager {FirstName} is reading reports");
        }

        public void ModifyWorkingHours()
        {
            Console.WriteLine($"The manager {FirstName} is modifying the working hours");
        }
    }
}
