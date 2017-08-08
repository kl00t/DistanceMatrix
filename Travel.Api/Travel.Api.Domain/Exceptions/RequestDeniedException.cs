namespace Travel.Api.Domain.Exceptions
{

    using System;
    using System.Runtime.Serialization;

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
