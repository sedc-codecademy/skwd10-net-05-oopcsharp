using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.App
{
    public class NumberStats
    {
        public double Number { get; set; }
        public bool IsEven { get; set; }
        public bool IsNegative { get; set; }
        public bool IsDecimal { get; set; }

        public void PrintInfo()
        {
            string str = string.Format(
                @"Stats for number: {0}
                    {1}
                    {2}
                    {3}",
                Number,
                IsNegative ? "Negative" : "Positive",
                IsDecimal ? "Decimal" : "Integer",
                IsEven ? "Even" : "Odd"
                );
            Console.WriteLine(str);
        }
    }
}
