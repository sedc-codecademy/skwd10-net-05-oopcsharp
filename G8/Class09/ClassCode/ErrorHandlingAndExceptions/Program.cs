using ErrorHandlingAndExceptions.Exceptions;
using System;

namespace ErrorHandlingAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Try/Catch/Finally example
            //try
            //{
            //    Console.WriteLine("Please enter a number");
            //    int numberFromUser = int.Parse(Console.ReadLine());

            //    int powOf2 = numberFromUser * numberFromUser;

            //    Console.WriteLine($"Power of two for {numberFromUser} is {powOf2}");

            //    if(powOf2 < 10)
            //    {
            //        throw new Exception("The result cannot be smaller than 10!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Aplication ended, Press anykey to continue...");
            //    Console.ReadLine();
            //}


            #endregion

            #region Multiple catch blocks for different types of exceptions
            //try
            //{
            //    int[] oddNumbers = new int[] { 1, 3, 5, 7 };

            //    //throw new IndexOutOfRangeException("Stupid index exception !");
            //    throw new Exception("Some stupid exception out of nowhere?!?");

            //    Console.WriteLine(oddNumbers[5]);
            //}
            //catch (IndexOutOfRangeException indexException)
            //{
            //    Console.WriteLine($"IndexOutOfRangeException: {indexException.Message}");
            //}
            //catch (SystemException sysException)
            //{
            //    Console.WriteLine($"SystemException {sysException.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            #endregion

            #region Custom and Nested Exceptions
            try
            {
                Console.WriteLine("Please enter two numbers:");
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                DivisionMethod(first, second);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion


            Console.ReadLine();
        }

        public static decimal DivisionMethod(decimal dividend, decimal devisor)
        {
            try
            {
                return dividend / devisor;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Attempted to divide by zero.")
                {
                    throw new MathDivisionException($"You can't divide with zero SERIOUSLY !", ex);
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}
