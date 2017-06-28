namespace DistanceMatrix.Connector
{
    using Entities;

    /// <summary>
    /// Distance Matrix Connector.
    /// </summary>
    public interface IDistanceMatrixConnector
    {
        DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest request);
    }
}