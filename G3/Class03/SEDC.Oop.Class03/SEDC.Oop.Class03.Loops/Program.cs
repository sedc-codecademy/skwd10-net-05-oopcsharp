using System;

namespace SEDC.Oop.Class03.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int timesToItterate = 100;
            //for(int index = timesToItterate; index > 0; index--)
            //{
            //    Console.WriteLine(index);
            //}

            //int index = 0;
            //while(index < 10)
            //{
            //    Console.WriteLine(index);
            //    index += 1;
            //}

            //string str = "Trajan";
            //int counter = 0;
            //while(str == "Trajan")
            //{
            //    if(counter == 10)
            //    {
            //        str = "Something else";
            //        Console.WriteLine(str);
            //    }
            //    Console.WriteLine(str);
            //    counter += 2;
            //}

            //bool isActive = true;

            //while (isActive)
            //{
            //    //Console.Clear();
            //    Console.WriteLine("1. Say hello");
            //    Console.WriteLine("2. Say goodbye");
            //    Console.WriteLine("3. Say something else");
            //    Console.WriteLine("0. Exit application");

            //    string input = Console.ReadLine();

            //    bool isValidInput = int.TryParse(input, out int selection);

            //    if(!isValidInput)
            //    {
            //        Console.WriteLine("Plese enter valid input");
            //        continue;
            //    }

            //    if (selection == 1)
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //    else if (selection == 2)
            //    {
            //        Console.WriteLine("Goodbye");
            //    }
            //    else if (selection == 3)
            //    {
            //        Console.WriteLine("Something else");
            //    }
            //    else if (selection == 0)
            //    {
            //        Console.WriteLine("Thank you for using our app");
            //        isActive = !isActive;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Plese enter valid input");
            //    }
            //}

            //int counter = 0;

            //do
            //{
            //    Console.WriteLine("We will be executed always minimun once");
            //} while (counter != 0);


            //while(true)
            //{
            //    Console.WriteLine("Enter a valid number");
            //    Console.WriteLine("To exit the application enter A");
            //    Console.WriteLine("To exit the application enter 0");

            //    string input = Console.ReadLine();

            //    if (input == "A")
            //    {
            //        Console.WriteLine("Thank you for using our app");
            //        break;
            //    }

            //    bool isValidInput = int.TryParse(input, out int selection);
            //    if(!isValidInput)
            //    {
            //        Console.WriteLine("Not valid number");
            //        continue;
            //    }

            //    if(selection == 0)
            //    {
            //        Console.WriteLine("Thank you for using our app");
            //        break;
            //    }

            //    int result = selection * 10;
            //    Console.WriteLine("The result is: " + result);
            //}


            //while(true)
            //{
            //    if(false)
            //    {
            //        while(true)
            //        {
            //            if(true)
            //            {
            //                continue;
            //            }
            //            break;
            //        }
            //        continue;
            //    }
            //    break;
            //}

            Console.ReadLine();
        }
    }
}
