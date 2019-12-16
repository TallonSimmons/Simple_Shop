using System;
using System.Runtime.Serialization;

namespace Simple_Shop.Domain.Entities.Exceptions
{
    public class ProductInvalidException : Exception
    {
        const string exceptionMessageDefault = "Product is invalid.";
        public ProductInvalidException(string message = exceptionMessageDefault) : base(message)
        {
        }

        public ProductInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class ProductUnavailableException : Exception
    {
        public ProductUnavailableException()
        {
        }

        public ProductUnavailableException(string message) : base(message)
        {
        }

        public ProductUnavailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductUnavailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
