namespace Travel.Api.Connector.Interfaces
{
    using Entities;

    public interface IGeolocationConnector
    {
        GeolocationResponse Geolocation(GeolocationRequest geolocationRequest);
    }
}