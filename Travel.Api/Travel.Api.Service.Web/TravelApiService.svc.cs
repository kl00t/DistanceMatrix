namespace Travel.Api.Service.Web
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Core;
    using Core.Framework;
    using Core.Logging;
    using Domain.Enums;
    using Domain.Models;

    public class TravelApiService : BaseService, ITravelApiService
    {
        /// <summary>
        /// The distance matrix engine
        /// </summary>
        private readonly ITravelApiEngine _apiEngine;

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelApiService"/> class.
        /// </summary>
        /// <param name="apiEngine">The distance matrix engine.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="System.ArgumentNullException">apiEngine</exception>
        public TravelApiService(ITravelApiEngine apiEngine, ILogger logger) : base(logger)
        {
            if (apiEngine == null)
            {
                throw new ArgumentNullException("apiEngine");
            }

            _apiEngine = apiEngine;
        }

        public ServiceResponse<DistanceMatrixResponse> DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest)
        {
            return CallEngine(
                () => _apiEngine.DistanceMatrix(distanceMatrixRequest),
                EventType.DistanceMatrix);
        }

        public ServiceResponse<DirectionsResponse> Directions(DirectionsRequest directionsRequest)
		{
			return CallEngine(
				() => _apiEngine.Directions(directionsRequest),
				EventType.Directions);
		}

        public ServiceResponse<ElevationResponse> Elevation(ElevationRequest elevationRequest)
        {
            return CallEngine(
                () => _apiEngine.Elevation(elevationRequest),
                EventType.Elevation);
        }

        public ServiceResponse<TimezoneResponse> Timezone(TimezoneRequest timezoneRequest)
        {
            return CallEngine(
                () => _apiEngine.Timezone(timezoneRequest),
                EventType.Timezone);
        }

        public ServiceResponse<GeocodeResponse> Geocode(GeocodeRequest geocodeRequest)
        {
            return CallEngine(
                () => _apiEngine.Geocode(geocodeRequest),
                EventType.Geocode);
        }

        public ServiceResponse<BingGeoCodeResponse> BingGeocode(GeocodeRequest bingGeoCodeRequest)
        {
            return CallEngine(
                () => _apiEngine.BingGeocode(bingGeoCodeRequest),
                EventType.BingGeocode);
        }

        public ServiceResponse<GeocodeResponse> ReverseGeocode(ReverseGeocodeRequest reverseGeocodeRequest)
        {
            return CallEngine(
                () => _apiEngine.ReverseGeocode(reverseGeocodeRequest),
                EventType.ReverseGeocode);
        }

        public ServiceResponse<GeolocationResponse> Geolocation(GeolocationRequest geolocationRequest)
        {
            return CallEngine(
                () => _apiEngine.Geolocation(geolocationRequest),
                EventType.Geolocation);
        }

        public ServiceResponse<List<RequestHistory>> GetDistanceMatrixRequestHistory()
        {
            return CallEngine(
                () => _apiEngine.GetDistanceMatrixRequestHistory(),
                EventType.GetDistanceMatrixRequestHistory);
        }

        public ServiceResponse<RequestHistory> GetRequestHistory(Guid requestId)
        {
            return CallEngine(
                () => _apiEngine.GetRequestHistory(requestId),
                EventType.GetRequestHistory);
        }

        public ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId)
        {
            return CallEngine(
                () => _apiEngine.ReplayRequest(requestId),
                EventType.ReplayRequest);
        }

        public ServiceResponse<DeleteRequestHistoryResponse> DeleteRequestHistory(Guid requestId)
		{
			return CallEngine(
				() => _apiEngine.DeleteRequestHistory(requestId),
				EventType.DeleteRequestHistory);
		}
	}
}