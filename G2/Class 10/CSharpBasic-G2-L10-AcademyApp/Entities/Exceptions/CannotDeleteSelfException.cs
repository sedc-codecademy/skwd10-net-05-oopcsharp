using System;

namespace Entities.Exceptions
{
    public class CannotDeleteSelfException : Exception
    {
        public CannotDeleteSelfException(string message) : base(message)
        {
        }
    }
}
