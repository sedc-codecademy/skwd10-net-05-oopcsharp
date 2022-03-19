using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Models
{
    public class Dog
    {
        private string _name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        //extra method
        public void SetName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Parameter null has no value");
            }
            _name = name;
        }

        public string Play()
        {
            return $"The dog {_name}, from race {Race} is playing";
        }

        public string Eat(string food)
        {
            return $"The dog {_name}, from race {Race} is eating {food}";
        }

        public string ChaseTail()
        {
            return $"The dog {_name}, from race {Race}, with color {Color} is chasing tail";
        }
    }
}
