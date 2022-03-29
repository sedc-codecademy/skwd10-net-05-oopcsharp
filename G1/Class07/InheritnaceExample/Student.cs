using System;
using System.Collections.Generic;
using System.Text;

namespace InheritnaceExample
{
    public class Student : Person
    {
        public Subject[] Subjects { get; set; }

        public Student() { }

        public Student(Subject[] subjects)
        {
            Subjects = subjects;
        }

        public Student(string firstName, string lastName, string phoneNumber, string email, Subject[] subjects) 
            : base(firstName, lastName, phoneNumber, email)
        {
            Subjects = subjects;
        }
    }
}
