using System;
using System.Security;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourInteger = 4;
            string ourString = "Our number";

            string numberString = "10";


            //The type of the result of concatenation is always string!!!
            string firstResult = ourInteger + ourString;
            Console.WriteLine(firstResult);

            string secondResult = ourInteger + numberString;
            Console.WriteLine(secondResult);

            bool ourBool = true;
            string thirdResult = ourBool + ourString;
            Console.WriteLine(thirdResult);
        }
    }
}
