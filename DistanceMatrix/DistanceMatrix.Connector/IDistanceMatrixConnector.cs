namespace DistanceMatrix.Connector
{
    using Entities;

    /// <summary>
    /// Distance Matrix Connector.
    /// </summary>
    public interface IDistanceMatrixConnector
    {
        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Returns a response.</returns>
        DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest request);
    }
}