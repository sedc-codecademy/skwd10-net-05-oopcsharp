using System;

namespace SEDC.Oop.Class09.ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number example");
            Console.WriteLine("Enter a number: ");

            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                Console.WriteLine(number);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("WE ARE IN FORMAT EXCEPTION");
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("WE ARE IN ArgumentNullException EXCEPTION");
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("WE ARE IN OverflowException EXCEPTION");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always be executed!");
            }


            Console.WriteLine("Enter the letter a or b");
            try
            {
                string inputstr = Console.ReadLine();
                if(inputstr == "a" || inputstr == "b")
                {
                    Console.WriteLine("Congratulations, ypu have entered a or b!");
                }
                else
                {
                    throw new Exception("That is not a or b! Sorry!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.InnerException.Message);
            }

            try
            {
                string consoleInput = Console.ReadLine();
                int a = ParseNumber(consoleInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }


            Console.ReadLine();
        }

        public static int ParseNumber(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
