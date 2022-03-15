using System;

namespace BranchingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            if (number > 10)
            {
                Console.WriteLine("Larger than 10");
            }
            else
            {
                Console.WriteLine("Smaller or equal to 10");
            }

            if (number > 10)
            {
                Console.WriteLine("Larger than 10");
            }
            else if (number < 10)
            {
                Console.WriteLine("Smaller than 10");
            }
            else
            {
                Console.WriteLine("Number is equal to 10");
            }

            string input1 = "";

            //bool success = int.TryParse(input1, out int number1);

            //if(!success)
            //{
            //    number1 = 15;
            //}

            if (!int.TryParse(input1, out int number1))
            {
                number1 = 15;
            }

            Console.WriteLine("Vrednosta na number1 =" + number1);

            //Switch
            int day = 3;

            switch (day)
            {
                case 0:
                    Console.WriteLine("Ponedelnik");
                    break;
                case 1:
                    Console.WriteLine("Vtornik");
                    break;
                case 2:
                    Console.WriteLine("Sreda");
                    break;
                case 3:
                    Console.WriteLine("Cetvrtok");
                    break;
                case 4:
                    Console.WriteLine("Petok");
                    break;
                case 5:
                    Console.WriteLine("Sabota");
                    break;
                case 6:
                    Console.WriteLine("Nedela");
                    break;
                default:
                    Console.WriteLine("Nevaliden den od nedelata");
                    break;
            }

            Console.WriteLine("Vi blagodarime!");
        }
    }
}
