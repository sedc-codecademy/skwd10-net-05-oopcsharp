using System;

namespace CSharp_G2_OOP_Exercises_L5.Entities
{
    public class Student
    {
        public string Name;

        public string Academy;

        public string Group;

        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Academy {Academy}, Group {Group}");
        }
    }
}
