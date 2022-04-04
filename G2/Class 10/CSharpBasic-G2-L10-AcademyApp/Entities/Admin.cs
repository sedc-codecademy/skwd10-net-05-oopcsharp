using Entities.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class Admin : User
    {
        public Admin(string username, string password, string firstName, string lastName) : base(username, password, firstName, lastName)
        {
        }

        /// <summary>
        /// The admin can add a user in the academy
        /// </summary>
        public void AddUser(List<User> users, User user)
        {
            // Check if the user with the certain username exists in the list of users
            if (users.Where(x => x.Username == user.Username).ToList().Count > 0)
            {
                throw new UserAlreadyExistsException($"The user {user.FirstName} {user.LastName} exists in the academy");
            }

            users.Add(user);
        }

        /// <summary>
        /// The admin can remove from the academy
        /// </summary>
        public void RemoveUser(List<User> users, User user)
        {
            // Here we check if the provided user is an Admin, and if the username is the same to the admin username (current object is admin)
            if (user is Admin && user.Username == Username)
            {
                throw new CannotDeleteSelfException("The admin cannot delete himself from the academy");
            }

            // Check if the user with the certain username exists in the list of users
            if (users.Where(x => x.Username == user.Username).ToList().Count == 0)
            {
                throw new UserDoesNotExistException($"The user {user.FirstName} {user.LastName} doesn't exist in the academy");
            }

            // Remove the user with the username from the list of users;
            users = users.Where(x => user.Username != x.Username).ToList();
        }
    }
}
