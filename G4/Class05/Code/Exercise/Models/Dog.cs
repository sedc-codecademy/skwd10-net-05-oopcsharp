

using System;

namespace Exercise.Models
{
    public class Dog
    {
        private string _name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        //We use this public method in order to add additional logic and protect our private property _name.
        //If we can access _name directly from Program we risk to initialize it to invalid value without validations.
        //This way, before setting a value we do a validation.
        public void SetName(string name)
        {
            //check if name is null or name == ""
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name must have a value!!!");
            }
            _name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"The dog {_name} is eating...");
        }
    }
}
