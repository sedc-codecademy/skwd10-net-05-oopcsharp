using System;

namespace CSharp_G2_OOP_L5.Entities
{
    public class Dog
    {
        public string Name;

        public string Race;

        public string Color;

        public Dog()
        {

        }

        public Dog(string dogName)
        {
            Name = dogName;
        }

        public Dog(string dogName, string dogRace, string dogColor)
        {
            Name = dogName;
            Race = dogRace;
            Color = dogColor;
        }

        public void Eat()
        {
            Console.WriteLine("Dog is now eating");
        }

        public void Play()
        {
            Console.WriteLine("The dog is playing");
        }

        public void ChaseTail()
        {
           Console.WriteLine("Dog is chasing its tail");
        }
    }
}
