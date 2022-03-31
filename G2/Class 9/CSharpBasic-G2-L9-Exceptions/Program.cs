using System;

namespace CSharpBasic_G2_L9_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "1", "2", "3" };

            int integer = 0;

            try
            {
                integer = int.Parse(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine("The input was not a number");
                Console.WriteLine("Setting default value to integer to 5");
                integer = 5;
            }
            finally
            {
                Console.WriteLine($"The number is {integer}");
            }
        }
    }
}
