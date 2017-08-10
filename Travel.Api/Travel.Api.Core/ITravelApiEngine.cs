namespace Travel.Api.Core
{
    using System;
    using System.Collections.Generic;
    using Domain.Models;

    public interface ITravelApiEngine
    {
        DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest);

        List<RequestHistory> GetDistanceMatrixRequestHistory();

        RequestHistory GetRequestHistory(Guid requestId);

        DistanceMatrixResponse ReplayRequest(Guid requestId);

        DirectionsResponse Directions(DirectionsRequest directionsRequest);

        DeleteRequestHistoryResponse DeleteRequestHistory(Guid requestId);

        ElevationResponse Elevation(ElevationRequest elevationRequest);

        TimezoneResponse Timezone(TimezoneRequest timezoneRequest);

        GeocodeResponse Geocode(GeocodeRequest geocodeRequest);

        GeocodeResponse ReverseGeocode(ReverseGeocodeRequest reverseGeocodeRequest);

        GeolocationResponse Geolocation(GeolocationRequest geolocationRequest);

        BingGeoCodeResponse BingGeocode(BingGeoCodeRequest bingGeoCodeRequest);
    }
}