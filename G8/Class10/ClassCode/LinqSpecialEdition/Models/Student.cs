using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSpecialEdition.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public char Gender { get; set; }
        public List<string> Skills { get; set; }

        public Student()
        {

        }

        public Student(string fname, string lname, int age, string group, char gender, List<string> skills)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            Group = group;
            Gender = gender;
            Skills = skills;
        }
    }
}
