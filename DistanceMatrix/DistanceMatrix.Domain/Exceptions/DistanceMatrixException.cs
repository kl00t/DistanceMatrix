using System;
using System.Runtime.Serialization;

namespace DistanceMatrix.Domain.Exceptions
{
    public class DistanceMatrixException : Exception
    {
        public DistanceMatrixException()
        {
        }

        public DistanceMatrixException(string message) : base(message)
        {
        }

        public DistanceMatrixException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DistanceMatrixException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
