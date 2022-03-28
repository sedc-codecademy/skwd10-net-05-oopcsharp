using System;

namespace InheritnaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject[] subjects = new Subject[2];
            subjects[0] = new Subject("C# Basic", 40);
            subjects[1] = new Subject("C# Advance", 60);

            //Student s1 = new Student() { };
            //Student s2 = new Student(subjects);
            //Student s3 = new Student("Petko", "Petkovski", "070123456", "petko@gmail", subjects);

            WebDeveloperStudent david = new WebDeveloperStudent("David", "Pavlovski", "070123333", "david@gmail.com", subjects, new[] { "Java", "C#" });

            Console.WriteLine(david.GetInfo());

            Trainer risto = new Trainer()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Email = "risto@gmail.com",
                PhoneNumber = "070111222",
                YearsOfExperience = 8
            };

            Console.WriteLine(risto.GetInfo());
        }
    }
}
