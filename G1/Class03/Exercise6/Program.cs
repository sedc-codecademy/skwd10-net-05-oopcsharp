using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete gi prisutnite studenti od G1");

            string[] students = new string[0];

            while(true)
            {
                Console.WriteLine("Vnesete ime na student:");
                string name = Console.ReadLine();

                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = name;

                Console.WriteLine("Dokolku sakas da vneses drug student klikni Y");

                string input = Console.ReadLine();

                //if(input == "Y" || input == "y")
                //{
                //    continue;
                //}
                //else
                //{
                //    break;
                //}

                if(input != "Y" && input != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Uspesno vnesovte " + students.Length + " studenti.");
        }
    }
}
