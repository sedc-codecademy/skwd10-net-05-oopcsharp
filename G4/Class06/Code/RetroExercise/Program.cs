using System;
using RetroExercise.Models;

namespace RetroExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Tanja", "SEDC", "G4");

            Student[] students = new Student[]
            {
                new Student("Tanja", "SEDC", "G4"),
                new Student("Bojan", "Web programming", "G2"),
                new Student("Radmila", "Graphic Design", "G3"),
                new Student("Stefan", "QA", "G5"),
                new Student("JOvana", "Web programming", "G2")
            };

            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            //the type of the variable which keeps the result, must be te same as the return type of the method!!!
            Student foundStudent = FindStudent(name, students);
            if (foundStudent == null)
            {
                //scenario line 49
                Console.WriteLine($"Student with name {name} was not found!");
            }
            else
            {
                //scenario line 45
                Console.WriteLine($"Student {foundStudent.Name}, studies {foundStudent.Academy} in {foundStudent.Group} group.");
            }

        }

        static Student FindStudent(string name, Student[] studentsArray)
        {
            foreach (Student student in studentsArray)
            {
                //if (String.Equals(name, student.Name, StringComparison.InvariantCultureIgnoreCase))
                //{

                //}
                if (name.ToLower() == student.Name.ToLower())
                {
                    return student;
                }
            }

            return null;
        }


        static int GetNumber()
        {
            return 5;
        }
    }
}
