using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY
            //Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )
            Dictionary<string, string> firstDictionary = new Dictionary<string, string>();
            firstDictionary.Add("song1", "Have a nice day!");
            firstDictionary.Add("song2", "Wind of change");

            bool song1Exists = firstDictionary.ContainsKey("song1");
            bool song3Exists = firstDictionary.ContainsKey("song3");

            Console.WriteLine(firstDictionary["song2"]); //get value for key song2

            Console.WriteLine($"Number of members in firstDictionary: {firstDictionary.Count}");

            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                { 2233, "Bread" },
                { 45645, "Milk" }
            };
            products.Add(4645, "Sugar");


            Console.WriteLine($"Product with number 2233: {products[2233]}");

            foreach (var item in firstDictionary)
            {
                Console.WriteLine($"{item}");
            }

            foreach (var item in firstDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            products[2233] = "Oranges";
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Console.WriteLine($"Product with number 7777: {products[7777]}");// ERROR, KeyNotFoundException
            //1.
            if (products.ContainsKey(7777))
            {
                Console.WriteLine($"Product with number 7777: {products[7777]}");
            }

            bool success = products.TryGetValue(7777, out string product7777);
            bool secondResult = products.TryGetValue(45645, out string product45645);

            Console.WriteLine(product7777);
            Console.WriteLine(product45645);

            foreach (KeyValuePair<int, string> item in products)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //LIST - has fixed type and has no fixed length
            List<int> integersList = new List<int>();
            integersList.Add(7);
            integersList.Add(99);
            integersList.Add(3);

            Console.WriteLine("===========LIST===========");
            foreach (int item in integersList)
            {
                Console.WriteLine(item);
            }

            integersList.Remove(99);

            Console.WriteLine("===========LIST after remove===========");
            foreach (int item in integersList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"integersList's second member: {integersList[1]}");

            integersList.RemoveAt(0);

            Console.WriteLine("===========LIST after remove at===========");
            foreach (int item in integersList)
            {
                Console.WriteLine(item);
            }

            //ArrayList - non generic
            //mixed ( Accepts all types and does not have constraint on number of elements )
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(true);
            arrayList.Add("test");
            arrayList.Add(new List<string>() { "G1", "G4" });
            Console.WriteLine("===========ARRAY LIST===========");
            //arrayList.Clear(); delete all members
            Console.WriteLine(arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(5);
            Console.WriteLine($"Second member: {arrayList[1]}");

            //QUEUE - FIFO first In First Out
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(6);
            intQueue.Enqueue(9);
            intQueue.Enqueue(3);
            // 6 9 3
            Console.WriteLine("===========QUEUE===========");
            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            int firstMember = intQueue.Peek(); //read the value of the FIRST element, don't remove the element!

            Console.WriteLine("===========QUEUE AFTER PEEK===========");
            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            int firstMemberOut = intQueue.Dequeue(); // read the value and remove the FIRST element

            Console.WriteLine("===========QUEUE AFTER DEQUEUE===========");
            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            int firstMemberOutAgain = intQueue.Dequeue(); // read the value and remove the FIRST element

            Console.WriteLine("===========QUEUE AFTER DEQUEUE===========");
            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(firstMember);
            Console.WriteLine(firstMemberOut);
            Console.WriteLine(firstMemberOutAgain);

            //STACK - LIFO Last in First Out

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hi");
            stringStack.Push("Hello");
            stringStack.Push("Bye");
            Console.WriteLine("===========STACK===========");
            foreach (var item in stringStack)
            {
                Console.WriteLine(item);
            }

            string lastMember = stringStack.Peek();//read the value of the LAST element, don't remove the element!

            Console.WriteLine("===========STACK AFTER PEEK===========");
            foreach (var item in stringStack)
            {
                Console.WriteLine(item);
            }

            string lastMemberOut = stringStack.Pop(); //read the value of the LAST element, remove the element!
            Console.WriteLine("===========STACK AFTER POP===========");
            foreach (var item in stringStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(lastMemberOut);
            Console.WriteLine(lastMember);

            Console.WriteLine("Count:");
            Console.WriteLine(intQueue.Count);
            Console.WriteLine(stringStack.Count);
        } 
    }
}
