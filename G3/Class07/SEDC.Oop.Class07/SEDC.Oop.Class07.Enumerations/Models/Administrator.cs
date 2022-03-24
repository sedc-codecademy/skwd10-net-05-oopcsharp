using SEDC.Oop.Class07.Enumerations.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Enumerations.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; }

        public Administrator(string name)
        {
            Id = 1;
            Name = name;
            Role = Roles.Admin;
        }
    }
}
