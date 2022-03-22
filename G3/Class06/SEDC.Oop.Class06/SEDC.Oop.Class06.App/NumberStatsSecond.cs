using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.App
{
    public class NumberStatsSecond
    {
        public double Number { get; set; }
        public bool IsEven { get; set; }
        public bool IsNegative { get; set; }
        public bool IsDecimal { get; set; }

        public NumberStatsSecond(double number)
        {
            GenerateInformation(number);
        }

        private void GenerateInformation(double number)
        {
            CheckIsEven(number);
        }

        private void CheckIsEven(double number)
        {
            IsEven = number % 2 == 0;
        }
    }
}
