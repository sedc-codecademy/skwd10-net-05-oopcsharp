using System;
using System.Collections.Generic;
using System.Text;

namespace InheritnaceExample
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }

        public Subject(string name, int numberOfClasses)
        {
            Name = name;
            NumberOfClasses = numberOfClasses;
        }
    }
}
