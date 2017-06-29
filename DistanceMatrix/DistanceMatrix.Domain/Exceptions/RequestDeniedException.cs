using System;
using System.Runtime.Serialization;

namespace DistanceMatrix.Domain.Exceptions
{
    public class RequestDeniedException : Exception
    {
        public RequestDeniedException()
        {
        }

        public RequestDeniedException(string message) : base(message)
        {
        }

        public RequestDeniedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RequestDeniedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
