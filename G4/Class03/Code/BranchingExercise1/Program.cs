using System;

namespace BranchingExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBranches = 12;
            int numOfApplesOnABranch = 8;
            int numOfApplesInBasket = 5;

            Console.WriteLine("Enter number of trees:");
            int numOfTrees;
            bool success = int.TryParse(Console.ReadLine(), out numOfTrees);

            if (success)
            {
                int totalNumOfApples = numOfTrees * numOfBranches * numOfApplesOnABranch;
                int result;
                if (totalNumOfApples % numOfApplesInBasket == 0)
                {
                    result = totalNumOfApples / numOfApplesInBasket;
                }
                else
                {
                    result = totalNumOfApples / numOfApplesInBasket + 1;
                }

                Console.WriteLine($"You need {result} baskets!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
