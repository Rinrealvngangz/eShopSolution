using System;
using System.Runtime.Serialization;

namespace eShopSolution.Utilities.Exceptions
{
    public class EShopException :Exception
    {
        public EShopException()
        {
        }

        public EShopException(string message) : base(message)
        {
        }

        public EShopException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
