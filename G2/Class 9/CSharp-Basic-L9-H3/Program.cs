using CSharp_Basic_L9_H3.Enteties;
using CSharp_Basic_L9_H3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Basic_L9_H3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>
            {
                new Car("Hyundai", 250),
                new Car("Mazda", 180),
                new Car("Ferrari", 300),
                new Car("Porsche", 280),
            };

            List<Driver> driversList = new List<Driver>
            {
                new Driver("Bob", 100),
                new Driver("Greg", 90),
                new Driver("Jill", 120),
                new Driver("Anne", 70)
            };

            var skillLevels = driversList.Select(GetSkil).ToList();

            skillLevels.ForEach(Console.WriteLine);

            /*var fastCars = carList.Where(car => car.Speed > 200).ToList();

            fastCars.ForEach(car => Console.WriteLine($"Car model {car.Model} Speed: {car.Speed}"));

            var fastCarNames = fastCars.Select(car => car.Model).ToList();
            Console.WriteLine("Fast car models are:");
            fastCarNames.ForEach(car => Console.WriteLine(car)
            Console.WriteLine("Choose car number 1");

            //bool isParsed = int.TryParse(Console.ReadLine(), out int parsedNumber);*/

            do
            {
                ChooseAndRaceCars(carList, driversList);
                Console.WriteLine("Race again? Any key for yes or x to exit");
            }
            while (Console.ReadLine().ToLower() != "x");
        }

        private static int GetSkil(Driver driver)
        {
            return driver.Skill;
        }

        public static void ChooseAndRaceCars(List<Car> carList, List<Driver> driverList)
        {
            Car firstCar = SelectCar(carList);
            Driver firstDriver = SelectDriver(driverList);
            firstCar.Driver = firstDriver;

            Car secondCar = SelectCar(carList.Where(x => x.Model != firstCar.Model).ToList());
            Driver secondDriver = SelectDriver(driverList.Where(x => x.Name != firstDriver.Name).ToList());
            secondCar.Driver = secondDriver;

            if (firstCar != null && firstDriver != null && secondCar != null && secondDriver != null)
            {
                RaceCars(firstCar, secondCar);
            }
            else
            {
                Console.WriteLine("The input was invalid");
            }
        }

        public static void RaceCars(Car firstCar, Car secondCar)
        {
            var firstCarSpeed = firstCar.CalculateSpeed();
            var secondCarSpeed = secondCar.CalculateSpeed();

            if (firstCarSpeed > secondCarSpeed)
            {
                Console.WriteLine($"The car that won is {firstCar.Model}. And the driver is {firstCar.Driver.Name}. \n The car speed was {firstCar.CalculateSpeed()}");
            }
            else if (firstCarSpeed < secondCarSpeed)
            {
                Console.WriteLine($"The car that won is {secondCar.Model}. And the driver is {secondCar.Driver.Name}. \n The car speed was {secondCar.CalculateSpeed()}");
            }
            else
            {
                Console.WriteLine("The race is a tie");
            }
        }

        private static Car SelectCar(List<Car> carList)
        {
            Console.WriteLine("Choose car");
            for (int index = 1; index <= carList.Count; index++)
            {
                Console.WriteLine($"{index}) {carList[index - 1].Model}");
            }

            Car selectedCar = null;

            try
            {
                int firstCarNumber = int.Parse(Console.ReadLine());

                if (firstCarNumber < 1 || firstCarNumber > carList.Count)
                {
                    throw new InvalidCarNumberException("The entered number was not in the correct range");
                }

                selectedCar = carList[firstCarNumber - 1];
            }
            catch (InvalidCarNumberException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number was invalid");
                return null;
            }

            return selectedCar;
        }

        private static Driver SelectDriver(List<Driver> driverList)
        {
            Driver driver = null;

            Console.WriteLine("Choose driver");
            for (int driverNumber = 1; driverNumber <= driverList.Count; driverNumber++)
            {
                Console.WriteLine($"{driverNumber}) {driverList[driverNumber - 1].Name}");
            }

            try
            {
                int firstDriverNumber = int.Parse(Console.ReadLine());

                if (firstDriverNumber < 1 || firstDriverNumber > driverList.Count)
                {
                    throw new InvalidCarNumberException("The entered number was not in the correct range");
                }

                driver = driverList[firstDriverNumber - 1];
            }
            catch (InvalidCarNumberException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number was invalid");
                return null;
            }

            return driver;
        }
    }
}
