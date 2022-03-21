using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_G2_OOP_L5.Entities
{
    public class Vehicle
    {
        public string Name;

        public string Color;

        public int NumberOfDoors;

        public void TurnOnEngine()
        {
            Console.WriteLine("Brm brm brm");
        }
    }
}
