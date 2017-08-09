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

    public class GoogleApiService : BaseService, IGoogleApiService
    {
        /// <summary>
        /// The distance matrix engine
        /// </summary>
        private readonly IGoogleApiEngine _apiEngine;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleApiService"/> class.
        /// </summary>
        /// <param name="apiEngine">The distance matrix engine.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="System.ArgumentNullException">apiEngine</exception>
        public GoogleApiService(IGoogleApiEngine apiEngine, ILogger logger) : base(logger)
        {
            if (apiEngine == null)
            {
                throw new ArgumentNullException("apiEngine");
            }

            _apiEngine = apiEngine;
        }

        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        /// <returns>
        /// Returns a distance matrix response.
        /// </returns>
        public ServiceResponse<DistanceMatrixResponse> DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest)
        {
            return CallEngine(
                () => _apiEngine.DistanceMatrix(distanceMatrixRequest),
                EventType.DistanceMatrix);
        }

        /// <summary>
        /// Directionses the specified directions request.
        /// </summary>
        /// <param name="directionsRequest">The directions request.</param>
        /// <returns>
        /// Returns the directions.
        /// </returns>
        public ServiceResponse<DirectionsResponse> Directions(DirectionsRequest directionsRequest)
		{
			return CallEngine(
				() => _apiEngine.Directions(directionsRequest),
				EventType.Directions);
		}

        /// <summary>
        /// Elevations the specified elevation request.
        /// </summary>
        /// <param name="elevationRequest">The elevation request.</param>
        /// <returns>
        /// Returns the elevation data.
        /// </returns>
        public ServiceResponse<ElevationResponse> Elevation(ElevationRequest elevationRequest)
        {
            return CallEngine(
                () => _apiEngine.Elevation(elevationRequest),
                EventType.Elevation);
        }

        /// <summary>
        /// Timezones the specified timezone request.
        /// </summary>
        /// <param name="timezoneRequest">The timezone request.</param>
        /// <returns>
        /// Returns the timezone response.
        /// </returns>
        public ServiceResponse<TimezoneResponse> Timezone(TimezoneRequest timezoneRequest)
        {
            return CallEngine(
                () => _apiEngine.Timezone(timezoneRequest),
                EventType.Timezone);
        }

        /// <summary>
        /// Geocodes the specified geocode request.
        /// </summary>
        /// <param name="geocodeRequest">The geocode request.</param>
        /// <returns>
        /// Returns the geocoded response.
        /// </returns>
        public ServiceResponse<GeocodeResponse> Geocode(GeocodeRequest geocodeRequest)
        {
            return CallEngine(
                () => _apiEngine.Geocode(geocodeRequest),
                EventType.Geocode);
        }

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns all the request history.
        /// </returns>
        public ServiceResponse<List<RequestHistory>> GetDistanceMatrixRequestHistory()
        {
            return CallEngine(
                () => _apiEngine.GetDistanceMatrixRequestHistory(),
                EventType.GetDistanceMatrixRequestHistory);
        }

        /// <summary>
        /// Gets the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns request history.
        /// </returns>
        public ServiceResponse<RequestHistory> GetRequestHistory(Guid requestId)
        {
            return CallEngine(
                () => _apiEngine.GetRequestHistory(requestId),
                EventType.GetRequestHistory);
        }

        /// <summary>
        /// Replays the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the response from the requested history request id.
        /// </returns>
        public ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId)
        {
            return CallEngine(
                () => _apiEngine.ReplayRequest(requestId),
                EventType.ReplayRequest);
        }

        /// <summary>
        /// Deletes the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns></returns>
        public ServiceResponse<DeleteRequestHistoryResponse> DeleteRequestHistory(Guid requestId)
		{
			return CallEngine(
				() => _apiEngine.DeleteRequestHistory(requestId),
				EventType.DeleteRequestHistory);
		}
	}
}