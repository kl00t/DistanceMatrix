namespace DistanceMatrix.Core
{

    using System;
    using System.Collections.Generic;
    using Domain.Models;

    public interface IDistanceMatrixEngine
    {
        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        /// <returns>
        /// Returns distance matrix response.
        /// </returns>
        DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest);

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        List<RequestHistory> GetDistanceMatrixRequestHistory();

        /// <summary>
        /// Gets the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        RequestHistory GetRequestHistory(Guid requestId);

        /// <summary>
        /// Replays the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the replayed request.
        /// </returns>
        DistanceMatrixResponse ReplayRequest(Guid requestId);
    }
}