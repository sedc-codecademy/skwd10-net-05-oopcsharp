using System;

namespace Enteties
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DayOfWeek WorkingDay { get; set; }

        protected double Salary;

        public Employee(int id, string firstName, string lastName, DayOfWeek workingDay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            WorkingDay = workingDay;
        }

        public void SetSalary(double salary)
        {
            Salary = salary;
        }

        public virtual void DoWork()
        {
            Console.WriteLine($"{FirstName} {LastName} is doing work");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}
