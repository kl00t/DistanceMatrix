namespace DistanceMatrix.Domain.Models
{
    using System;
    using Interfaces;

    /// <summary>
    /// Request History class.
    /// </summary>
    /// <seealso cref="DistanceMatrix.Domain.Interfaces.IRequestHistory" />
    public class RequestHistory : IRequestHistory
    {
        public Guid Id { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }
    }
}