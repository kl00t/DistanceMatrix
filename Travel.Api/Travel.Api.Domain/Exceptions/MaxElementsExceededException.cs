namespace Travel.Api.Domain.Exceptions
{

    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MaxElementsExceededException : Exception
    {
        public MaxElementsExceededException()
        {
        }

        public MaxElementsExceededException(string message) : base(message)
        {
        }

        public MaxElementsExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaxElementsExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}