using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    public class AngorCat : Cat
    {
        public string GetInfo()
        {
            return $"{Id} {Name} {Color} {Food}";
        }

        public AngorCat()
        {
            Console.WriteLine("Default ctor of AngorCat is called");
        }
    }
}
