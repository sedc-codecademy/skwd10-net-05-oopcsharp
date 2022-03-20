using CSharp_G2_OOP_Exercises_L5.Entities;
using System;

namespace CSharp_G2_OOP_Exercises_L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");

            string numberOfStudents = Console.ReadLine();
            bool isValidInput = int.TryParse(numberOfStudents, out int numberOfStudentsParsed);

            if (!isValidInput || numberOfStudentsParsed <= 0)
            {
                Console.WriteLine("Invalid number of students");
                return;
            }

            Student[] students = new Student[numberOfStudentsParsed];
            for (int counter = 0; counter < numberOfStudentsParsed; counter++)
            {
                Console.WriteLine("Enter student name");
                string studentName = Console.ReadLine();

                Console.WriteLine("Enter student academy");
                string studentAcademy = Console.ReadLine();

                Console.WriteLine("Enter student group");
                string studentGroup = Console.ReadLine();

                Student student = new Student(studentName, studentAcademy, studentGroup);
                students[counter] = student;
            }

            Console.WriteLine("Enter a name of the student that you want to search");
            string name = Console.ReadLine();

            bool studentExists = false;
            foreach (Student student in students)
            {
                if (student.Name.ToLower() == name.ToLower())
                {
                    student.PrintStudentInfo();
                    studentExists = true;

                    break;
                }
            }

            if (!studentExists)
            {
                Console.WriteLine($"Student with name {name} does not exist");
            }
        }
    }
}
