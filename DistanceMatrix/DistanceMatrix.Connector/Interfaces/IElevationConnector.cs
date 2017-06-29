namespace DistanceMatrix.Connector.Interfaces
{

    using Entities;

    public interface IElevationConnector
    {
        ElevationResponse Elevation(ElevationRequest request);
    }
}
