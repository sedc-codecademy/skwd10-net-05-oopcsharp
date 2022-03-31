using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basic_L9_H3.Exceptions
{
    public class InvalidCarNumberException : Exception
    {
        public InvalidCarNumberException(string message) : base(message)
        {

        }
    }
}
