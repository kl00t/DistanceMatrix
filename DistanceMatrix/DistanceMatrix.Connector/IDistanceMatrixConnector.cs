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
        /// <param name="origin">The origin.</param>
        /// <param name="destination">The destination.</param>
        /// <returns>Returns distance matrix.</returns>
        DistanceMatrix DistanceMatrix(string origin, string destination);
    }
}