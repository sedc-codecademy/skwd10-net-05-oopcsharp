using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            string[] strArray = new string[4];
            string[] strArray2 = new string[] { "Hello", "World" };
            GoThruCollection(strArray2, "Array");

            Array.Resize(ref strArray2, strArray2.Length + 1);
            strArray2[strArray2.Length - 1] = "!";
            GoThruCollection(strArray2, "Array");
            #endregion

            #region Lists
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Remove(9);
            Console.WriteLine("List count is: " + numbers.Count);
            Console.WriteLine(numbers[2]);
            numbers[2] = 5;
            GoThruCollection(numbers, "List of integers");
            #endregion


            #region Dictionary

            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "Winds of change");
            dictionaryOne.Add("song2", "Enter Sandman");
            dictionaryOne.Add("animal", "dog");
            GoThruCollection(dictionaryOne, "Dictionary");
            // dictionaryOne.Add("animal", "Cat"); // key always must be unique
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>
            {
                { 4, "Hello" },
                { 5, "World" },
                { 6, "!" }
            };

            Console.WriteLine(dictionaryOne["song2"]);
            Console.WriteLine(dictionaryTwo[5]);
            Console.WriteLine("Length: " + dictionaryTwo.Count);

            Dictionary<int, MyType> myTypeDictionary = new Dictionary<int, MyType>();
            Dictionary<string, List<string>> bandsSongsDictionary = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<int, string> keyValue in dictionaryTwo)
            {
                Console.WriteLine("=============");
                Console.WriteLine(dictionaryTwo[keyValue.Key]);
                Console.WriteLine("This is directly with using value property: " + keyValue.Value);
            }
            dictionaryTwo.Remove(4);

            #endregion

            #region Stack and Queue

            Console.WriteLine("================QUEUE=================");
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);

            int firstElement = someQueue.Dequeue();
            Console.WriteLine(firstElement);
            GoThruCollection(someQueue, "Queue");
            // Console.WriteLine(someQueue[2]); // we cannot use indexes
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);

            Console.WriteLine("================STACK=================");

            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey");
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");

            string item = someStack.Pop();
            Console.WriteLine("Pop: " + item);
            Console.WriteLine("Peek: " + someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);
            GoThruCollection(someStack, "STACK");
            #endregion


            Console.ReadLine();
        }

        public static void GoThruCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items", name);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }
    }

    public class MyType
    {

    }
}
