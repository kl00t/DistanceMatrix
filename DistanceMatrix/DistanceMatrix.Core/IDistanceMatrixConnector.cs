namespace DistanceMatrix.Core
{
    using Domain.Models;

    public interface IDistanceMatrixConnector
    {
        DistanceMatrixResponse Calculate(DistanceMatrixRequest distanceMatrixRequest);
    }
}