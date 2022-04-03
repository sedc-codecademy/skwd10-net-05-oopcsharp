using LinqSpecialEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSpecialEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("John", "Doe", 22, "G1", 'M', new List<string>(){"C#", "SQL"}),
                new Student("Anna", "Bakers", 31, "G3", 'F', new List<string>(){"Javascript", "Docker"}),
                new Student("Tanya", "Walters", 24, "G2", 'F', new List<string>(){"Java", "Docker"}),
                new Student("Tim", "Yung", 26, "G1", 'M', new List<string>(){"React", "CSS"}),
                new Student("Kathy", "Donovan", 19, "G4", 'F', new List<string>(){"C#", "SQL"}),
                new Student("James", "Hughs", 36, "G3", 'M', new List<string>(){"C#", "React", "SQL", "Vue"}),
                new Student("Trey", "Anders", 27, "G2", 'M', new List<string>(){"Javascript", "CSS"}),
                new Student("Diana", "Jones", 30, "G4", 'F', new List<string>(){"CSS", "HTML"}),
                new Student("Eric", "White", 20, "G1", 'M', new List<string>(){"SQL", "React"}),
                new Student("Angela", "Johnson", 28, "G2", 'F', new List<string>(){"React", "Javascript", "CSS", "Vue"}),
                new Student("Chris", "Peterson", 25, "G1", 'M', new List<string>(){"C#", "SQL", "Docker"}),
            };

            // METHOD SYNTAX OF WRITING LINQ
            // Task 01 - find Age of youngest and oldest student
            Console.WriteLine("=========== MAN / MIN ===========");

            int youngestAge = students
                                    .Select(x => x.Age)
                                    .Min();

            var oldestAge = students
                                    .Select(x => x.Age)
                                    .Max();

            Console.WriteLine("Age of youngest student is {0} and of oldest is {1}", youngestAge, oldestAge);

            // get the whole Student object with nested linq method
            Student youngest = students
                                    .Where(x => x.Age == students.Select(x => x.Age).Min())
                                    .FirstOrDefault();
            Console.WriteLine("Name of youngest is {0}", youngest.FirstName);

            // even fancier
            Student youngest02 = students
                                        .FirstOrDefault(x => x.Age == students.Select(x => x.Age).Min());

            Console.WriteLine("Really, the Name of the youngest is {0}", youngest02.FirstName);


            // Task 02 - find SUM of all ages of all students
            Console.WriteLine("=========== SUM ===========");

            int sumOfAges = students
                                    .Select(x => x.Age)
                                    .Sum();
            Console.WriteLine($"Sum of all ages of all students is {sumOfAges}");

            // Task 03  - find AVERAGE of all ages of all students
            Console.WriteLine("=========== AVERAGE ===========");
            double averageAge = students
                                    .Select(x => x.Age)
                                    .Average();

            Console.WriteLine($"Average age of the students is {averageAge}");

            // Task 04 - order students by name in ascending order / descending order
            Console.WriteLine("=========== ORDER BY (ASCENDING) ===========");

            List<Student> ascendingOrder = students
                                        .OrderBy(x => x.FirstName)
                                        .ToList();

            ascendingOrder.ForEach(x => Console.WriteLine(x.FirstName));

            Console.WriteLine("=========== ORDER BY (DESCENDING) ===========");
            List<Student> descendingOrder = students
                                    .OrderByDescending(x => x.FirstName)
                                    .ToList();

            descendingOrder.ForEach(x => Console.WriteLine(x.FirstName));

            // Task 05 - group elements by group
            Console.WriteLine("=========== GROUP BY ===========");
            // { "G1": List<Student> { st1, st2,...}.ToList() } //IGrouping
            // { "G2": List<Student> { st1, st2,...} }
            // { "G3": ... }
            Dictionary<string, List<Student>> studentDictionary = new Dictionary<string, List<Student>>();

            var groupedStudents = students
                                        .OrderBy(x => x.Group)
                                        .GroupBy(x => x.Group);

            foreach(var item in groupedStudents)
            {
                studentDictionary.Add(item.Key, item.ToList());
            }

            Console.WriteLine("-------- Dictionary of groups --------");
            // see dictionary
            foreach(var item in studentDictionary)
            {
                Console.WriteLine($"Group: {item.Key} has {item.Value.Count}");
            }

            List<Student> g4 = null;
            bool areThereAnyStudentsInG4 = studentDictionary.TryGetValue("G4", out g4);

            if(areThereAnyStudentsInG4 == false)
            {
                Console.WriteLine("No students in G4!");
            }
            else
            {
                Console.WriteLine($"Number of students in G4 is {g4.Count}");
            }

            // this is same as
            Console.WriteLine(areThereAnyStudentsInG4 == false ? "No students in G4!" : $"Number of students in G4 is {g4.Count}");
            // event better
            Console.WriteLine(areThereAnyStudentsInG4 ? $"Number of students in G4 is {g4.Count}" : "No students in G4!");
            Console.WriteLine(!areThereAnyStudentsInG4 ? "No students in G4!" : $"Number of students in G4 is {g4.Count}");

            // Task 06 - find person with most skills
            Console.WriteLine("===========  FIRSTORDERDEFAULT / SINGLEORDERDEFAULT ===========");
            int mostSkills = students
                                    .Select(st => st.Skills.Count)
                                    .Max();

            Student mostSkilledStudent01 = students
                                            .Where(x => x.Skills.Count == mostSkills)
                                            .FirstOrDefault();
            Student mostSkilledStudent02 = students
                                            .Where(x => x.Skills.Count == students.Select(y => y.Skills.Count).Max())
                                            .FirstOrDefault();
            Student mostSkilledStudent03 = students
                                            .FirstOrDefault(x => x.Skills.Count == students.Select(y => y.Skills.Count).Max());

            Console.WriteLine($"Name of most skilled student is: {mostSkilledStudent01.FirstName}");

            // .FirstOrDefault() returns a first item of potentially multiple (or default - null if none exist)
            // .SingleOrDefault() assumes that is a single item and returns it (or default - null if none exist)
            //Student mostSkilledStudent04 = students
            //                               .SingleOrDefault(x => x.Skills.Count == students.Select(y => y.Skills.Count).Max());




            // QUERY SYNTAX OF WRITING
            var mostSkilledQuerry = from st in students
                                    where st.Skills.Count == mostSkills
                                    select st.FirstName;

            // same with Method Syntax
            List<string> studentsWithTopSkills = students
                                            .Where(x => x.Skills.Count == mostSkills)
                                            .Select(x => x.FirstName)
                                            .ToList();

            var youngerThan30 = from student in students
                                where student.Age < 30
                                select student.FirstName;

            Console.ReadLine();
        }
    }
}
