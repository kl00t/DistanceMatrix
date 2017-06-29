namespace DistanceMatrix.Connector.Interfaces
{

    using Entities;

    public interface IGeolocationConnector
    {
        GeolocationResponse Geolocation(GeolocationRequest request);
    }
}