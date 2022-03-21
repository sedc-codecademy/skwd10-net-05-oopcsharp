using Exercise3.Classes;
using System;

namespace Exercise3
{
    class Program
    {
        static Student FindStudent(string name, Student[] studentsArray)
        {
            foreach(Student student in studentsArray)
            {
                if(student.Name.ToLower() == name.ToLower())
                {
                    return student;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            Student  darko = new Student("Darko", "G8", "Web Development");
            Student antonio = new Student();

            //Exercise 3
            Student[] students = new Student[]
            {
                new Student("Ivan", "G8", "Web Development"),
                new Student("Stefani", "G2", "Web Design"),
                new Student("Gorjan", "G4", "QA"),
                new Student("Martina", "G1", "Networks"),
                new Student("Irena", "G3", "Web Development")
            };

            Console.WriteLine("Enter name to find a student:");
            string name = Console.ReadLine();

            Student foundStudent = FindStudent(name, students);
            if(foundStudent == null)
            {
                Console.WriteLine("The student was not found");
            }
            else
            {
                Console.WriteLine($"We found the student: {foundStudent.Name} {foundStudent.Academy}");
            }


            Console.ReadLine();
        }
    }
}
