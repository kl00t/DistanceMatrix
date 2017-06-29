namespace DistanceMatrix.Data
{
    using System;
    using Domain.Models;

    public interface IRequestHistoryRepository : IRepository<RequestHistory, Guid>
    {
        /// <summary>
        /// Inserts the request history.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        Guid InsertRequestHistory(DistanceMatrixRequest distanceMatrixRequest);
    }
}