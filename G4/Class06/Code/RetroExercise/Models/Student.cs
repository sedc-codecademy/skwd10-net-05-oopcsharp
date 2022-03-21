

using System;

namespace RetroExercise.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name must not be empty!");
            }
            if (String.IsNullOrEmpty(academy))
            {
                throw new Exception("Academy must not be empty!");
            }
            if (String.IsNullOrEmpty(group))
            {
                throw new Exception("Group must not be empty!");
            }
            Name = name;
            Academy = academy;
            Group = group;
        }
    }
}
