using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictonary
            Dictionary<string, string> osigurenici = new Dictionary<string, string>();
            osigurenici.Add("1231231231", "Risto Panchevski");
            osigurenici.Add("222222222", "Test Test");
            //osigurenici.Add("1231231231", "Bob Bobsky"); -> throws error bcause we have same key
            bool success = osigurenici.TryAdd("1231231231", "Bob Bobsky");

            Dictionary<int, Person> flats = new Dictionary<int, Person>()
            {
                { 20, new Person("petko", "petkovski")},
                { 21, new Person("john", "johnsky")},
                { 22, new Person("bob", "bobsky")}
            };

            Person p = flats[20];
            string name = osigurenici["222222222"];

            if (flats.ContainsKey(33))
            {
                Console.WriteLine($"In flat no. {33} lives: {flats[33].FirstName} {flats[33].LastName}");
            }
            else
            {
                Console.WriteLine("Flat does not exist");
            }

            osigurenici.ContainsValue("Risto Panchevski");

            flats.Remove(30);

            bool success1 = flats.TryGetValue(23, out Person result);
            #endregion

            #region List
            List<string> students = new List<string>();
            students.Add("David");
            students.Add("Darko");
            students.Add("Martina");
            students.Add("Risto");
            students.Add("Risto");

            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8, 10 };

            students.Remove("Risto");
            string studentName = students[1];
            //string studentName1 = students[5];
            int count = students.Count;

            List<string> students2 = new List<string>()
            {
                "Test",
                "Bobsky"
            };

            students.AddRange(students2);

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            foreach (KeyValuePair<string, string> osigurenik in osigurenici)
            {
                string key = osigurenik.Key;
                string value = osigurenik.Value;
            }

            students.ForEach(student =>
            {
                Console.WriteLine(student);
            });

            //students.ForEach(Console.WriteLine);
            bool ristoExists = students.Contains("Risto");
            students.Sort();
            #endregion

            #region Queue
            Queue<Person> bankQueue = new Queue<Person>();
            bankQueue.Enqueue(new Person("Risto", "Panchevski"));
            bankQueue.Enqueue(new Person("Test", "Test"));
            bankQueue.Enqueue(new Person("Bojan", "Damcevski"));

            Person peekPerson = bankQueue.Peek();
            Person p1 = bankQueue.Dequeue();
            Person p2 = bankQueue.Dequeue();
            Person p3 = bankQueue.Dequeue();
            //Person p4 = bankQueue.Dequeue();

            bool success2 = bankQueue.TryDequeue(out Person p4);
            #endregion

            #region Stack
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            int a = numbers.Pop();
            bool success4 = numbers.TryPop(out int b);
            int peekNumber = numbers.Peek();
            #endregion

            List<Person> users = new List<Person>
            {
                new Person("Bob", "Bobsky", "bob@gmail.com"),
                new Person("John", "Johnsky", "john@yahoo.com"),
                new Person("Tom", "Tomsky", "tom@gmail.com"),
                new Person("Steve", "Stevsky", "steve@yahoo.com"),
                new Person("Test", "Testsky", "test@outlook.com")
            };

            // x => {}
            List<Person> usersContainingOAndB = users
                .Where(user =>
                    user.FirstName.Contains("o")
                    && user.LastName.StartsWith("B"))
                .ToList();

            List<Person> usersOnGmail = users.Where(user => user.Email.Contains("gmail")).ToList();

            // 1 or more
            Person lastUserOnYahoo = users.Where(user => user.Email.Contains("yahoo")).Last();
            // 0 or more
            Person lastOrDefaultUserOnYahoo = users.Where(user => user.Email.Contains("yahoo")).LastOrDefault();
            Person firstOrDefaultUserOnYahoo = users.Where(user => user.Email.Contains("hotmail")).FirstOrDefault();
            Person firstOrDefaultUserOnYahoo1 = users.FirstOrDefault(user => user.Email.Contains("hotmail"));
            //Person firstUserOnYahoo = users.Where(user => user.Email.Contains("hotmail")).First();
            // exact 1
            //Person singleUserOnYahoo = users.Where(user => user.Email.Contains("yahoo")).Single();
            //0 or 1
            //Person singleOrDefaultUserOnYahoo = users.Where(user => user.Email.Contains("yahoo")).SingleOrDefault();


            List<string> emailsOfUsersContainingO = users
                .Where(user =>
                    user.FirstName.Contains("o"))
                .Select(user => user.Email)
                .ToList();

            List<int> n = new List<int> { 3, 12, 15, 6, 7, 10 };
            double avg = n.Average();
            int sum = n.Sum();
            int max = n.Max();
            List<int> ordered = n.OrderBy(x => x).ToList();
            List<int> orderedDescending = n.OrderByDescending(x => x).ToList();
        }
    }
}
