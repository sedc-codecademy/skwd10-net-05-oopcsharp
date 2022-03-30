using System;

namespace Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public int AverageAge { get; set; }

        public Animal() { }

        public Animal(string name, string color, string sound, int averageAge)
        {
            Name = name;
            Color = color;
            Sound = sound;
            AverageAge = averageAge;
        }
    }
}
