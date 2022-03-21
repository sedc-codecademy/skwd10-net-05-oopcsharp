using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Academy { get; set; }
        public Student()
        {

        }
        public Student(string name, string group, string academy)
        {
            Academy = academy;
            Name = name;
            Group = group;
        }
    }
}
