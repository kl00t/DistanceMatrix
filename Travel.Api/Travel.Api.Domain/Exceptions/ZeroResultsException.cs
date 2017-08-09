namespace Travel.Api.Domain.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class ZeroResultsException : Exception
    {
        public ZeroResultsException()
        {
        }

        public ZeroResultsException(string message) : base(message)
        {
        }

        public ZeroResultsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ZeroResultsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}