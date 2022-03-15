using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolku drva ima vo nivata?");
            string input = Console.ReadLine();

            //int numberOfTrees;

            //bool success = int.TryParse(input, out numberOfTrees);

            //if (!success)
            //{
            //    Console.WriteLine("Vnesovte nevaliden broj na drva!");
            //    return;
            //}

            if (!int.TryParse(input, out int numberOfTrees))
            {
                Console.WriteLine("Vnesovte nevaliden broj na drva!");
                return;
            }
            
            int branches = 12;
            int apples = 8;
            int applesPerBasket = 5;

            int totalNumberOfAplese = numberOfTrees * branches * apples;
            int numberOfBaskets = totalNumberOfAplese / applesPerBasket;

            if (totalNumberOfAplese % applesPerBasket > 0)
            {
                numberOfBaskets++;
            }

            Console.WriteLine("Vi se potrebni " + numberOfBaskets + " gajbi");
        }
    }
}
