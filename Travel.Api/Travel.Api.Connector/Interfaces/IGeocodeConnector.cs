﻿namespace Travel.Api.Connector.Interfaces
{
    using Entities;

    public interface IGeocodeConnector
    {
        GeocodeResponse Geocode(GeocodeRequest geocodeRequest);

        GeocodeResponse ReverseGeocode(ReverseGeocodeRequest reverseGeocodeRequest);

        BingMapsRESTToolkit.Location GeocodeRequest(BingMapsRESTToolkit.GeocodeRequest geocodeRequest);
    }
}