using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = RoleEnum.Manager;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        //Manager has specific implementation for the GetSalary method
        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
