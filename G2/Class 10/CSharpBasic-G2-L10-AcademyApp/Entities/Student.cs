namespace Entities
{
    public class Student : User
    {
        public Subject Subject { get; set; }

        public Student(Subject subject, string username, string password, string firstName, string lastName)
            : base(username, password, firstName, lastName)
        {
            Subject = subject;
        }
    }
}
