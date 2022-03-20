namespace CSharp_G2_OOP_AccessModifiers_L5.Entities
{
    public class Person
    {
        public Name Name { get; set; }

        public int Age { get; set; }

        public Person(Name name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
