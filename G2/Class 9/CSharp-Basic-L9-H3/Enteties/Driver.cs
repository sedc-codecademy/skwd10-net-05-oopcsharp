using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basic_L9_H3.Enteties
{
    public class Driver
    {
        public string Name { get; set; }

        public int Skill { get; set; }

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}
