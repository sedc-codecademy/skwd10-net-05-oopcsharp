using System;

namespace CSharp_G2_C7_Inheritance.Entities
{
    public class Manager : Employee
    {
        public Manager(int id, string firstName, string lastName, DayOfWeek workingDay) : base(id, firstName, lastName, workingDay)
        {
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
