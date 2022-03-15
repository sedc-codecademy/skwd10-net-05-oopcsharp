using System;

namespace ConversionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type.Parse
            string input = "10";

            int number = int.Parse(input); //Int32.Parse();
            //decimal.Parse()
            //long.Parse()           

            number++;

            Console.WriteLine("Vrednosta na number = " + number);

            //Convert.ToType
            string input2 = "159999999999999";

            //int number2 = Convert.ToInt32(input2); -> Throws exception

            long number2 = Convert.ToInt64(input2);

            number2--;

            Console.WriteLine("Vrednosta na number2 = " + number2);

            string input3 = "3.2";

            decimal decimalNumber = Convert.ToDecimal(input3);

            decimalNumber += 0.5M;

            Console.WriteLine("Vrednosta na decimalNumber = " + decimalNumber);

            //Type.TryParse
            string input4 = "10";
            int number4;

            bool success = int.TryParse(input4, out number4);

            number4++;
            Console.WriteLine("Vrednosta na number4 = " + number4);
        }
    }
}
