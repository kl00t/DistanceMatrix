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
        private readonly IGoogleApiEngine _distanceMatrixEngine;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleApiService"/> class.
        /// </summary>
        /// <param name="distanceMatrixEngine">The distance matrix engine.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="System.ArgumentNullException">distanceMatrixEngine</exception>
        public GoogleApiService(IGoogleApiEngine distanceMatrixEngine, ILogger logger) : base(logger)
        {
            if (distanceMatrixEngine == null)
            {
                throw new ArgumentNullException("distanceMatrixEngine");
            }

            _distanceMatrixEngine = distanceMatrixEngine;
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
                () => _distanceMatrixEngine.DistanceMatrix(distanceMatrixRequest),
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
				() => _distanceMatrixEngine.Directions(directionsRequest),
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
                () => _distanceMatrixEngine.Elevation(elevationRequest),
                EventType.Elevation);
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
                () => _distanceMatrixEngine.GetDistanceMatrixRequestHistory(),
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
                () => _distanceMatrixEngine.GetRequestHistory(requestId),
                EventType.GetRequestHistory);
        }

        public ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId)
        {
            return CallEngine(
                () => _distanceMatrixEngine.ReplayRequest(requestId),
                EventType.ReplayRequest);
        }

		public ServiceResponse<DeleteRequestHistoryResponse> DeleteRequestHistory(Guid requestId)
		{
			return CallEngine(
				() => _distanceMatrixEngine.DeleteRequestHistory(requestId),
				EventType.DeleteRequestHistory);
		}
	}
}