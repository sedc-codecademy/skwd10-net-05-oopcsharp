using System;
using System.Collections.Generic;

namespace ExceptionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int> { 2, 4, 6, 8 };

                //ArgumentOutOfRangeException
                //int number = list[4];
                int number = list[3];

                string name = null;
                //NullReferenceException
                //name.ToLower();

                //int a = 5;
                //int b = 0;

                //int result = a / b;

                Console.WriteLine("Vnesete zbor od nad 5 bukvi");
                string input = Console.ReadLine();

                if(input.Length < 5)
                {
                    throw new ArgumentException("Input not valid, you need word with more than 5 chars");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Console.WriteLine(ex); -> Log into file for further investigation
                Console.WriteLine("Se sluci greska...");
            }
            catch (NullReferenceException ex)
            {
                //Console.WriteLine(ex); -> Log into file for further investigation
                Console.WriteLine("Javi se na administratorot...");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error happend");
            }
            finally
            {
                Console.WriteLine("Finish");
            }
        }
    }
}
