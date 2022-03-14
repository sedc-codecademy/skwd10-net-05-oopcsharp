using System;

namespace ArraysExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];

            int counter = 0;

            while (true)
            {
                Console.WriteLine("Please enter a name");
                string name = Console.ReadLine();

                Array.Resize(ref names, names.Length + 1);
                names[counter] = name;
                //names[counter] = $"{counter+1}:{name}";

                Console.WriteLine("Do you want to continue?");
                string response = Console.ReadLine();

                if (response == "N" || response == "n")
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine("Names:");
            int index = 0;
            foreach (string name in names)
            {
                Console.WriteLine(name);
                Console.WriteLine($"{name} - {index}");
                index++;
            }
        }
    }
}
