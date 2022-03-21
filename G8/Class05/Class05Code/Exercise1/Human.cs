using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            //string stats = $"{FirstName} {LastName}, age {Age}";
            //return stats;
            return $"{FirstName} {LastName}, age {Age}";
        }
    }
}
