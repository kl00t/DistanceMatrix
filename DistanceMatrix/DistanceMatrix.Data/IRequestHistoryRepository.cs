namespace DistanceMatrix.Data
{
    using System;
    using System.Collections.Generic;
    using Domain.Models;

    public interface IRequestHistoryRepository : IRepository<RequestHistory, Guid>
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>
        /// Returns all history requests.
        /// </returns>
        List<RequestHistory> GetAll();

        /// <summary>
        /// Inserts the request history.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        void InsertRequestHistory(DistanceMatrixRequest distanceMatrixRequest);
    }
}