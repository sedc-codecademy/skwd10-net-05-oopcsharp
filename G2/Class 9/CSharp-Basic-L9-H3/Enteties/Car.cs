using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basic_L9_H3.Enteties
{
    public class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }

        public Car Race(Car otherCar)
        {
            return CalculateSpeed() > otherCar.CalculateSpeed() ? this : otherCar;
        }
    }
}
