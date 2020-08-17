using System;

namespace BusinessRuleEngine.Exceptions
{
    public class InvalidProductException : Exception
    {
        public InvalidProductException() : base()
        {

        }

        public InvalidProductException(string message): base(message)
        {

        }
    }
}
