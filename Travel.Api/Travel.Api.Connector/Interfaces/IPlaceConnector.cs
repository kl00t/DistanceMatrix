namespace Travel.Api.Connector.Interfaces
{

    using Entities;

    public interface IPlaceConnector
    {
        PlaceResponse Place(PlaceRequest request);
    }
}
