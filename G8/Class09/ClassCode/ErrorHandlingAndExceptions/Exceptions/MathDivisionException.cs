using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingAndExceptions.Exceptions
{
    public class MathDivisionException : Exception
    {
        public MathDivisionException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("MathDivisionException Constructor was called!!!!!");
        }
    }
}
