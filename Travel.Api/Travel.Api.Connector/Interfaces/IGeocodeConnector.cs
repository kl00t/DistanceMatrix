namespace Travel.Api.Connector.Interfaces
{

    using Entities;

    public interface IGeocodeConnector
    {
        GeocodeResponse Geocode(GeocodeRequest request);
    }
}