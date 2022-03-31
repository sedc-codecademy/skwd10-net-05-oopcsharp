using System;

namespace CSharpBasic_G2_L9_EX1.Exceptions
{
    public class InvalidRatingException : Exception
    {
        public InvalidRatingException(string message) : base(message)
        {
        }
    }
}
