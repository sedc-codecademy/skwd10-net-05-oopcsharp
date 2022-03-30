using System;
using ErrorHandling.Domain;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered {number}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message); //main details
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //finally is executed in both cases
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("End of entering number!");
            }

            Console.WriteLine("After try catch");

            //THROW EXCEPTIONS
            Console.WriteLine("Enter a or b.");

            try
            {
                string letter = Console.ReadLine();
                if (letter != "a" && letter != "b")
                {
                    //our exception
                    throw new Exception("You must enter a or b!");
                }

                //code
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("End of entering a or b!");
            }

            //SPECIFIC EXCEPTIONS
            try
            {
                int num = int.Parse(Console.ReadLine()); //FormatException if the input can not be parsed
                Console.WriteLine($"num: {num}");

                Human human = null;
                //human.FirstName = "ana"; //NullReferenceException

                int[] integers = new int[] { 1, 3, 6 };
                Console.WriteLine(integers[7]); //IndexOutOfRangeException
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input was not a number!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Empty object!");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
            }


            //UNHANDLED EXCEPTIONS IN METHODS
            //If the exception is not handled it is propagated in the Program
            //try
            //{
            //    UnhandledExceptionExample();
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine("Empty object!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("An error occurred!");
            //}

            //If the exception is handled it will not be propagated!
            HandledExceptionExample();

            Console.WriteLine("End of program!");
        }


        static void UnhandledExceptionExample()
        {
            Human human = null;
            human.FirstName = "ana";

            //code
        }

        static void HandledExceptionExample()
        {
            try
            {
                int[] integers = new int[] { 1, 3, 6 };
                Console.WriteLine(integers[7]);

                //code
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index was out of range!");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
            }
        }
    }
}
