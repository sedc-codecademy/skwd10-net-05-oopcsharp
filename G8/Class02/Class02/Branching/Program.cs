using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching");
            Console.WriteLine("=============================");

            // IF / ELSE
            int firstNumber = 5;
            int secondNumber = 2;

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("First number is larger");
            }
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine("Second number is larger");
            }
            else
            {
                Console.WriteLine("They are equal");
            }

            // Switch

            int dayOfWeek = 3;

            //switch(dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("Working day");
            //        break;
            //    case 2:
            //        Console.WriteLine("Working day");
            //        break;
            //    case 3:
            //        Console.WriteLine("Working day");
            //        break;
            //    case 4:
            //        Console.WriteLine("Working day");
            //        break;
            //    case 5:
            //        Console.WriteLine("Working day");
            //        break;
            //    case 6:
            //        Console.WriteLine("Hooray! Weekend!");
            //        break;
            //    case 7:
            //        Console.WriteLine("Hooray! Weekend!");
            //        break;
            //    default:
            //        Console.WriteLine("No such day");
            //        break;
            //}
            Console.WriteLine("=============================");

            switch(dayOfWeek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Hooray! Weekend!");
                    break;
                default:
                    Console.WriteLine("No such day");
                    break;
            }

            #region Exercises
            Console.WriteLine("=============================");
            // Exercise 05

            Console.WriteLine("Enter number of trees");
            int trees;
            bool ifSuccess = int.TryParse(Console.ReadLine(), out trees);

            int branchesOnTree = 12;
            int appleOnBranch = 8;
            int appleInBasket = 5;
            int resultBaskets = 0;

            int treeApples;

            if(ifSuccess)
            {
                treeApples = trees * branchesOnTree * appleOnBranch;
                if(treeApples % appleInBasket == 0)
                {
                    resultBaskets = treeApples / appleInBasket;
                }
                else
                {
                    resultBaskets = treeApples / appleInBasket + 1;
                }
                Console.WriteLine("You whould need " + resultBaskets + " baskets.");
            }
            else
            {
                Console.WriteLine("Enter a valid input number");
            }

            Console.WriteLine("===========================");

            // Exercise 06

            Console.WriteLine("Enter number from 1 - 3");
            bool isUserNumberSueccess = int.TryParse(Console.ReadLine(), out int userChoice);
            if (isUserNumberSueccess)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane!");
                        break;
                    case 3:
                        Console.WriteLine("You got a new bike!");
                        break;
                    default:
                        Console.WriteLine("You didn't get any reward :(");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number!!!");
            }

            #endregion


            Console.ReadLine();
        }
    }
}
