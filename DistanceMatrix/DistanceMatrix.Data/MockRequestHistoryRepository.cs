namespace DistanceMatrix.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Domain.Models;

    /// <summary>
    /// Mock request history repository.
    /// </summary>
    /// <seealso cref="DistanceMatrix.Data.IRequestHistoryRepository" />
    public class MockRequestHistoryRepository : IRequestHistoryRepository
    {
        /// <summary>
        /// The request history.
        /// </summary>
        readonly List<RequestHistory> _requestHistory = new List<RequestHistory>
        {
            new RequestHistory
            {
                Id = Guid.Parse("CC17BDFA-309A-497A-AF8F-7864BC92664E"),
                Origin = "Peckham",
                Destination = "Paris"
            },
            new RequestHistory
            {
                Id = Guid.Parse("1E1AD9FE-7BC6-4239-9FF7-0CD0B4ABBCE0"),
                Origin = "Manchester",
                Destination = "Marrakech"
            },
            new RequestHistory
            {
                Id = Guid.Parse("875DBFD4-26C1-459A-A098-D1A521D36000"),
                Origin = "London",
                Destination = "Bombay"
            }
        };

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Returns the entity by the id.
        /// </returns>
        public RequestHistory GetById(Guid id)
        {
            return _requestHistory.FirstOrDefault(x => x.Id.Equals(id));
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Insert(RequestHistory entity)
        {
            _requestHistory.Add(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(RequestHistory entity)
        {
            var requestHistory = GetById(entity.Id);
            requestHistory.Origin = entity.Origin;
            requestHistory.Destination = entity.Destination;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var requestHistory = GetById(id);
            _requestHistory.Remove(requestHistory);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>
        /// Returns all history requests.
        /// </returns>
        public List<RequestHistory> GetAll()
        {
            return _requestHistory;
        }

        /// <summary>
        /// Inserts the request history.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        public void InsertRequestHistory(DistanceMatrixRequest distanceMatrixRequest)
        {
            var requestHistory = new RequestHistory
            {
                Id = Guid.NewGuid(),
                Origin = distanceMatrixRequest.Origin,
                Destination = distanceMatrixRequest.Destination
            };

            Insert(requestHistory);
        }
    }
}