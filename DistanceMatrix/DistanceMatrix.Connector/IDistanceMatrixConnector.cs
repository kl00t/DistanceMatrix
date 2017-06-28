namespace DistanceMatrix.Connector
{
    using Domain.Models;

    public interface IDistanceMatrixConnector
    {
        DistanceMatrixResponse Calculate(string origin, string destination);
    }
}