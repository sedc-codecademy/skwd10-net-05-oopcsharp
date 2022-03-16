using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Classes.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        public Person()
        {
            SSN = GenerateSSN();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();
        }

        public Person(int age)
        {
            Age = age;
            SSN = GenerateSSN();
            Name = "Jill";
        }

        private long GenerateSSN()
        {
            Random rand = new Random();
            long ssn = rand.Next(100000, 999999);
            return ssn;
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The human named {Name}(SSN:{SSN}) is saying: {text}");
        }
    }
}
