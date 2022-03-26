using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.CSharpCollections
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }

    public enum Category
    {
        ItEquipment,
        LapTop,
        PC,
        TV
    }
}
