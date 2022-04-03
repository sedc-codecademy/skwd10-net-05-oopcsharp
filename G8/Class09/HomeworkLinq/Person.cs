using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkLinq
{
    public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
		}
	}
}
