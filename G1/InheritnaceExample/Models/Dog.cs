namespace Models
{
    public class Dog : Animal
    {
        public int Feet { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string color, string sound, int averageAge, int feet, string breed)
            :base(name, color, sound, averageAge)
        {
            Feet = feet;
            Breed = breed;
        }
    }
}
