using System;
using System.Runtime.Serialization;

namespace DistanceMatrix.Domain.Exceptions
{
    public class GoogleApiException : Exception
    {
        public GoogleApiException()
        {
        }

        public GoogleApiException(string message) : base(message)
        {
        }

        public GoogleApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GoogleApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
