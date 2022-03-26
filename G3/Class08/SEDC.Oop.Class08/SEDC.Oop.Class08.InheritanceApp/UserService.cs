using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.InheritanceApp
{
    public class UserService : BaseService
    {
        public void Login()
        {
            ValidateInteger(1);
        }

        public void Register()
        {
            ValidateString("");
        }
    }
}
