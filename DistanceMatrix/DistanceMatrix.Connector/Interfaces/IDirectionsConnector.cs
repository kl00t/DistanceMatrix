namespace DistanceMatrix.Connector.Interfaces
{
    using Entities;

    public interface IDirectionsConnector
    {
        DirectionsResponse Directions(DirectionsRequest request);
    }
}
