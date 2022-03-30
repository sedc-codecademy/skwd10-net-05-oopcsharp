using System;
using System.Collections.Generic;
using System.Text;

namespace InheritnaceExample
{
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }

        //public override string GetInfo()
        //{
        //    return $"{FullName} [tel: {PhoneNumber}] - [{Email}] ({YearsOfExperience})";
        //}

        public override string GetInfo()
        {
            return $"{base.GetInfo()} ({YearsOfExperience})";
        }
    }
}
