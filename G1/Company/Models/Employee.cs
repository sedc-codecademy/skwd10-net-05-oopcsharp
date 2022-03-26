using System;

namespace Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual string GetInfo()
        {
            //return $"{FullName} {Role} [{GetSalary().ToString("C")}]";
            return $"{FullName} {Role} [{GetSalary():C}]";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
