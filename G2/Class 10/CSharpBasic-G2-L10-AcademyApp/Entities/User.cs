namespace Entities
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string username, string password, string firstName, string lastName)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Checks if the provided credentials (username and password) match the ones given for the current user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool HasMatchingCredentials(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
