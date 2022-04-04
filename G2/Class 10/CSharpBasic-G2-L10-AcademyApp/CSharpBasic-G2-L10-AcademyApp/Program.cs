using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasic_G2_L10_AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new Student(new Subject("C# Basic", new List<int>() { 8, 9, 10}), "student1", "student1", "StudentOne", "Student"),
                new Student(new Subject("C# Basic", new List<int>() { 5, 8, 7}), "studen21", "student21", "StudentTwenty", "StudentOne"),
                new Student(new Subject("C# Basic", new List<int>() { 7, 6, 5}), "student13", "student13", "Student13", "Student"),
                new Student(new Subject("C# Basic", new List<int>() { 8, 9, 10}), "student14", "student1", "Student14", "Student"),
                new Student(new Subject("C# Advanced", new List<int>() { 8, 9, 10}), "student15", "student1", "Student15", "Student"),
                new Student(new Subject("C# Advanced", new List<int>() { 8, 9, 10}), "student16", "student1", "Student16", "Student"),
                new Student(new Subject("C# Advanced", new List<int>() { 8, 9, 10}), "student17", "student1", "Student17", "Student"),
                new Student(new Subject("C# Advanced", new List<int>() { 8, 9, 10}), "student18", "student1", "Student18", "Student"),
                new Admin("admin", "admin", "Administrator", "Admin"),
                new Teacher("teacher", "teacher", "Teacher", "Teach"),
            };

            RunApplication(users);
        }

        static void RunApplication(List<User> users)
        {
            try
            {
                User currentUser = LogIn(users);

                if (currentUser == null)
                {
                    Console.WriteLine("Invalid credentials");
                    return;
                }

                do
                {
                    // Check if the instance of the user is the specified class (upcasting)
                    if (currentUser is Student student)
                    {
                        ShowStudentOptions(student);
                    }
                    else if (currentUser is Teacher teacher)
                    {
                        ShowTeacherOptions(users);
                    }
                    else if (currentUser is Admin admin)
                    {
                        ShowAdminOptions(admin, users);
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid role");
                    }

                    Console.WriteLine("Write exit to exit or any key to repeat");
                } while (Console.ReadLine().ToLower() != "exit");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}. Exiting application");
            }
        }

        static void ShowAdminOptions(Admin admin, List<User> users)
        {
            Console.WriteLine("Add or Remove user - Enter add or remove");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add":
                    AddUser(admin, users);
                    break;
                case "remove":
                    RemoveUser(admin, users);
                    break;
                default:
                    throw new InvalidOperationException("Invalid input");
            }
        }

        private static void RemoveUser(Admin admin, List<User> users)
        {
            Console.WriteLine("Enter username for user  to remove");
            string username = Console.ReadLine();
            ValidateInput(username);

            User user = GetUserByUsername(users, username);

            if (user == null)
            {
                throw new InvalidOperationException($"User with username {username} doesn't exist");
            }

            admin.RemoveUser(users, user);
            Console.WriteLine($"User {user.FirstName} {user.LastName} successfully removed");
        }

        private static void AddUser(Admin admin, List<User> users)
        {
            Console.WriteLine("Enter username for user");
            string username = Console.ReadLine();
            ValidateInput(username);


            Console.WriteLine("Enter password for user");
            string password = Console.ReadLine();
            ValidateInput(password);

            Console.WriteLine("Enter first name for user");
            string firstName = Console.ReadLine();
            ValidateInput(firstName);

            Console.WriteLine("Enter lastName for user");
            string lastName = Console.ReadLine();
            ValidateInput(lastName);

            Console.WriteLine("Enter role for user (Teacher, Student, Admin)");
            string role = Console.ReadLine();
            ValidateInput(role);

            User newUser;
            switch (role.ToLower())
            {
                case "teacher":
                    newUser = new Teacher(username, password, firstName, lastName);
                    break;
                case "student":
                    Console.WriteLine("Enter subject for student");
                    string subject = Console.ReadLine();
                    ValidateInput(subject);
                    newUser = new Student(new Subject(subject, new List<int>()), username, password, firstName, lastName);
                    break;
                case "admin":
                    newUser = new Admin(username, password, firstName, lastName);
                    break;
                default:
                    throw new InvalidOperationException("Invalid role");
            }

            admin.AddUser(users, newUser);
            Console.WriteLine($"User {newUser.FirstName} {newUser.LastName} successfully added");
        }

        static void ShowTeacherOptions(List<User> users)
        {
            Console.WriteLine("See all subjects or students (enter subject or student)");
            string input = Console.ReadLine();

            // Get all users which are students (casting is done here)
            List<Student> students = users.Where(x => x is Student).Select(x => (Student)x).ToList();
            switch (input.ToLower())
            {
                case "subject":
                    // Get all subjects which are Distinct, (if multiple subjects have the same name, it will repeat in the list)
                    List<string> subjects = students.Select(x => x.Subject.Name).Distinct().ToList();
                    foreach (string subject in subjects)
                    {
                        // Get all of the students for the given subjects
                        int numberOfStudents = students.Where(x => x.Subject.Name == subject).Count();
                        Console.WriteLine($"{subject} - {numberOfStudents} attending");
                    }
                    break;
                case "student":
                    Console.WriteLine("Students: ");
                    students.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} "));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }
        }

        static void ShowStudentOptions(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}. Subject that the student is listening {student.Subject.Name}. Grades :");
            student.Subject.Grades.ForEach(x => Console.Write($"{x} "));
        }

        static User LogIn(List<User> users)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            ValidateInput(username);

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            ValidateInput(password);

            // Get the first occurence of the User with matching credentials. If one doesn't exist, null will be retuned
            User currentUser = users.SingleOrDefault(x => x.HasMatchingCredentials(username, password));

            return currentUser;
        }

        static User GetUserByUsername(List<User> users, string username)
        {
            // Get the first user which has the provided username. If he doesn't exist in the list, the result will be null
            return users.FirstOrDefault(x => x.Username == username);
        }

        static void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Input cannot be empty");
            }
        }
    }
}
