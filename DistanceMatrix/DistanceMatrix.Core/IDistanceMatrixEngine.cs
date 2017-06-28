namespace DistanceMatrix.Core
{
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
    }
}