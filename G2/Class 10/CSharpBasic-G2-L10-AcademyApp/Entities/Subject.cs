using Entities.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class Subject
    {
        public string Name { get; set; }

        public List<int> Grades { get; set; }

        public Subject(string name, List<int> grades)
        {
            Name = name;
            Grades = grades;
        }
    }
}