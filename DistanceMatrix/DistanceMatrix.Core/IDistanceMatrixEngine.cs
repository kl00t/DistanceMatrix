namespace DistanceMatrix.Core
{

    using Domain.Models;

    public interface IDistanceMatrixEngine
    {
        DistanceMatrixResponse Calculate(DistanceMatrixRequest distanceMatrixRequest);
    }
}