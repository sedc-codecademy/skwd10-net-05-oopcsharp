using System;
using Models;

namespace InheritnaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sharko", "Siva", "Aw aw", 10, 4, "Sharplaninec");
            Cat cat = new Cat("Beti", "Bela", "Mjau mjau", 12);
            Shark shark = new Shark()
            {
                Name = "Shark",
                AverageAge = 30,
                Fins = 4,
                Color = "Siva",
                Sound = "Glu Glu"
            };

            Dog c = null;

            Console.WriteLine(c.Name);
        }
    }
}
