using System;
using System.Collections.Generic;

namespace CSharpBasic_G2_L8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>()
            {
                { "Ivan", 20 },
                { "Miki", 25 }
            };

            ageDictionary.Add("Petko", 20);
            ageDictionary.Add("Stanko", 25);

            if (ageDictionary.ContainsKey("asdf")) 
            {
                int age = ageDictionary["asdf"];
            }

            ageDictionary.Remove("Petko");


            ageDictionary["Petko"] = 30;

            int dictionaryCount = ageDictionary.Count;

            Console.WriteLine($"The age of Petko is: {ageDictionary["Petko"]}");

            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            intList.Add(4);
            Console.WriteLine(intList[0]);
            List<string> stringList = new List<string>();

            intList.AddRange(new List<int>() { 4, 5, 6 });

            Console.WriteLine($"First occurence of 4 is {intList.IndexOf(4)}");

            intList.Insert(intList.Count, 8);


            Queue<DateTime> dateTimeQueue = new Queue<DateTime>();

            dateTimeQueue.Enqueue(DateTime.Now);
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-1));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-2));

            //Console.WriteLine(dateTimeQueue.Dequeue());
            //Console.WriteLine(dateTimeQueue.Dequeue());



            //bool isSuccsesfull = dateTimeQueue.TryDequeue(out DateTime lastDate);

            DateTime copyDate = dateTimeQueue.Peek();

            Stack<double> doubleStack = new Stack<double>();

            doubleStack.Push(3.4);
            doubleStack.Push(0.2);
            doubleStack.Push(1.3);
            doubleStack.Push(5.4);


            doubleStack.Pop();
            bool isPoped = doubleStack.TryPop(out double value);
            bool hasElement = doubleStack.TryPeek(out double peekedValue);
        }
    }
}
