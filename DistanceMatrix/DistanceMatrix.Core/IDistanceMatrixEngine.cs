namespace DistanceMatrix.Core
{
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
    }
}