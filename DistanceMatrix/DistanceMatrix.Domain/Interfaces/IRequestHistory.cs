namespace DistanceMatrix.Domain.Interfaces
{
    using System;

    public interface IRequestHistory
    {
        Guid Id { get; set; }

        string Origin { get; set; }

        string Destination { get; set; }
    }
}