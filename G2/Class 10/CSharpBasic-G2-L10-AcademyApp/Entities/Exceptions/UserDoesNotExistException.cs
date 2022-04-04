using System;

namespace Entities.Exceptions
{
    internal class UserDoesNotExistException : Exception
    {
        public UserDoesNotExistException(string message) : base(message)
        {
        }
    }
}