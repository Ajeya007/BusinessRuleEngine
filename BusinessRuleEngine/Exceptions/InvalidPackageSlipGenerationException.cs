using System;

namespace BusinessRuleEngine.Exceptions
{
    public class InvalidPackageSlipGenerationException : Exception
    {
        public InvalidPackageSlipGenerationException() : base ()
        {

        }

        public InvalidPackageSlipGenerationException(string message): base(message)
        {

        }
    }
}
