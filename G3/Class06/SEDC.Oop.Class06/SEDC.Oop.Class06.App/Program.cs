using SEDC.Oop.Class06.App.Models;
using SEDC.Oop.Class06.App.Services;
using SEDC.Oop.Class06.App.Task03;
using System;

namespace SEDC.Oop.Class06.App
{
    class Program
    {

        static void Main(string[] args)
        {
            // task 2
            User[] users = new User[3];
            UserService userService = new UserService();

            while(true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. login");
                Console.WriteLine("2. register");
                // validation logic
                int selection = 1;
                switch(selection)
                {
                    case 1:
                        users = userService.Login("", "", users);
                        break;
                    case 2:
                        users = userService.Register(users);
                        break;
                    default:
                        //validation error
                        break;
                }
            }


            // task 3
            Atm atm = new Atm();
            atm.Main();
        }


        //static void Main(string[] args)
        //{
        //    double[] numbers = new double[] { 1, 11, 1.3, -22.3, -11, 43235.2, 3123, 0.5 };

        //    foreach (double number in numbers)
        //    {
        //        NumberStats numberStats = NumberStats(number);
        //        numberStats.PrintInfo();
        //    }

        //    Console.ReadLine();
        //}

        public static NumberStats NumberStats(double number)
        {
            NumberStats stats = new NumberStats()
            {
                Number = number
            };
            stats.IsEven = number % 2 == 0;
            stats.IsDecimal = number % 1 != 0;
            stats.IsNegative = number < 0;
            return stats;
        }
    }
}
