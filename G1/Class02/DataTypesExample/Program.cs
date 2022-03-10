using System;

namespace DataTypesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 02...");

            int x = 7, y = 8;
            int a = 5;
            a = 8;

            Console.Write("This is Console.Write function");
            Console.WriteLine("Vrednosta na a = " + a);

            short u = 4;
            Console.WriteLine("Vrednosta na u = " + u);

            long l = 66;
            Console.WriteLine("Vrednosta na l = " + l);

            float pi = 3.14F;

            float f = 6.5F;
            Console.WriteLine("Vrednosta na f = " + f);

            double d = 6.5D;
            Console.WriteLine("Vrednosta na d = " + d);

            decimal e = 6.5M;
            Console.WriteLine("Vrednosta na e = " + e);

            char c = 't';
            Console.WriteLine("Vrednosta na c = " + c);

            string name = "Risto";
            Console.WriteLine("Vrednosta na name = " + name);

            bool b = true;
            bool n = false;
            Console.WriteLine("Vrednosta na b = " + b + ", a vrednosta na n = " + n);

            DateTime newYear = new DateTime(2022, 1, 1, 0, 0, 0);
            Console.WriteLine("Vrednosta na newYear = " + newYear);
            Console.WriteLine("Vrednosta na newYear = " + newYear.ToString("dd.MMMM.yyyy hh:mm:ss"));

            object person = new
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                DateOfBirth = new DateTime(1989, 07, 20)
            };

            Console.WriteLine("Vrednosta na person = " + person);
        }
    }
}
