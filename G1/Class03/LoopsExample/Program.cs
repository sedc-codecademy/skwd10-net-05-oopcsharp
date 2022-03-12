using System;

namespace LoopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;

            while(j <= 100)
            {

                //if (j == 50)
                //{
                //    break;
                //}

                if(j >= 50 && j < 60)
                {
                    j++;
                    continue;
                }

                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }

            int k = 1;
            do
            {
                if(k == 1)
                {
                    Console.WriteLine("First execution");
                }else
                {
                    Console.WriteLine("Rest");
                }
                k++;

            } while (k <= 100);
        }
    }
}
