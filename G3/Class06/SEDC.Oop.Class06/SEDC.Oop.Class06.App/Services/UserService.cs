using SEDC.Oop.Class06.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.App.Services
{
    public class UserService
    {
        public User[] Login(string username, string password, User[] users)
        {
            // login logic
            return users;
        }

        public User[] Register(User[] users)
        {
            // register logic
            return users;
        }

        private User[] AddNewUser(User user, User[] users)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length] = user;
            return users;
        }
    }
}
