namespace Travel.Api.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Core.Framework;
    using Domain.Models;

    [ServiceContract]
    public interface ITravelApiService
    {
        /// <summary>
        /// Provides basic heartbeat check to allow monitoring of service health.
        /// </summary>
        /// <returns>Current date and time.</returns>
        [OperationContract]
        ServiceResponse<DateTime> Heartbeat();

        [OperationContract]
        ServiceResponse<DistanceMatrixResponse> DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest);

        [OperationContract]
		ServiceResponse<DirectionsResponse> Directions(DirectionsRequest directionsRequest);

        [OperationContract]
        ServiceResponse<ElevationResponse> Elevation(ElevationRequest elevationRequest);

        [OperationContract]
        ServiceResponse<TimezoneResponse> Timezone(TimezoneRequest timezoneRequest);

        [OperationContract]
        ServiceResponse<GeocodeResponse> Geocode(GeocodeRequest geocodeRequest);

        [OperationContract]
        ServiceResponse<BingGeoCodeResponse> BingGeocode(GeocodeRequest bingGeoCodeRequest);

        [OperationContract]
        ServiceResponse<GeocodeResponse> ReverseGeocode(ReverseGeocodeRequest reverseGeocodeRequest);

        [OperationContract]
        ServiceResponse<GeolocationResponse> Geolocation(GeolocationRequest geolocationRequest);

        [OperationContract]
        ServiceResponse<List<RequestHistory>> GetDistanceMatrixRequestHistory();

        [OperationContract]
        ServiceResponse<RequestHistory> GetRequestHistory(Guid requestId);

        [OperationContract]
		ServiceResponse<DeleteRequestHistoryResponse> DeleteRequestHistory(Guid requestId);

		[OperationContract]
        ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId);
    }
}