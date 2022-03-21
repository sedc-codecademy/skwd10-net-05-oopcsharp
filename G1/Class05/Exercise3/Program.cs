using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Anita", "Nikolovska", "Web programiranje", "G1");
            students[1] = new Student("Darko", "Angelovski", "Mrezi", "G1");
            students[2] = new Student("David", "Pavlovski", "Web programiranje", "G6");
            students[3] = new Student("Kristijan", "Poposki", "Mrezi", "G4");
            students[4] = new Student("Martina", "Jovanova", "Design", "G7");

            //foreach(Student student in students)
            //{
            //    Console.WriteLine(student.GetInfo());
            //}

            Console.WriteLine("Search by name/surname:");
            string input = Console.ReadLine();

            Console.WriteLine("Results:");
            foreach(Student student in students)
            {
                //if(student.FirstName.ToLower().Contains(input.ToLower()) ||
                //    student.LastName.ToLower().Contains(input.ToLower()))
                //{
                //    Console.WriteLine(student.GetInfo());
                //}

                if (student.FullName.ToLower().Contains(input.ToLower()))
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }
    }
}
