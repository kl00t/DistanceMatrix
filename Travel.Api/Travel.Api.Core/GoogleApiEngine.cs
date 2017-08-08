namespace Travel.Api.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Connector.Interfaces;
    using Data;
    using Domain.Enums;
    using Domain.Exceptions;
    using Domain.Models;

    public class GoogleApiEngine : IGoogleApiEngine
	{
		/// <summary>
		/// The distance matrix connector.
		/// </summary>
		private readonly IDistanceMatrixConnector _distanceMatrixConnector;

        /// <summary>
        /// The directions connector
        /// </summary>
        private readonly IDirectionsConnector _directionsConnector;

        /// <summary>
        /// The elevation connector
        /// </summary>
        private readonly IElevationConnector _elevationConnector;

        /// <summary>
        /// The request history repository.
        /// </summary>
        private readonly IRequestHistoryRepository _requestHistoryRepository;

        /// <summary>
        /// The timezone connector.
        /// </summary>
        private readonly ITimezoneConnector _timezoneConnector;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleApiEngine" /> class.
        /// </summary>
        /// <param name="distanceMatrixConnector">The distance matrix connector.</param>
        /// <param name="requestHistoryRepository">The request history repository.</param>
        /// <param name="directionsConnector">The directions connector.</param>
        /// <param name="elevationConnector">The elevation connector.</param>
        /// <param name="timezoneConnector">The timezone connector.</param>
        /// <exception cref="System.ArgumentNullException">distanceMatrixConnector</exception>
        public GoogleApiEngine(
            IDistanceMatrixConnector distanceMatrixConnector, 
            IRequestHistoryRepository requestHistoryRepository, 
            IDirectionsConnector directionsConnector, 
            IElevationConnector elevationConnector, 
            ITimezoneConnector timezoneConnector)
		{
			if (distanceMatrixConnector == null)
			{
				throw new ArgumentNullException("distanceMatrixConnector");
			}

			if (requestHistoryRepository == null)
			{
				throw new ArgumentNullException("requestHistoryRepository");
			}

			if (directionsConnector == null)
			{
				throw new ArgumentNullException("directionsConnector");
			}

            if (elevationConnector == null)
            {
                throw new ArgumentNullException("elevationConnector");
            }

            if (timezoneConnector == null)
            {
                throw new ArgumentNullException("timezoneConnector");
            }

            _distanceMatrixConnector = distanceMatrixConnector;
			_requestHistoryRepository = requestHistoryRepository;
			_directionsConnector = directionsConnector;
            _elevationConnector = elevationConnector;
            _timezoneConnector = timezoneConnector;
		}

		/// <summary>
		/// Distances the matrix.
		/// </summary>
		/// <param name="distanceMatrixRequest">The distance matrix request.</param>
		/// <returns>
		/// Returns distance matrix response.
		/// </returns>
		public DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest)
		{
			var request = Mapper.Map<Connector.Entities.DistanceMatrixRequest>(distanceMatrixRequest);

			var distanceMatrix = _distanceMatrixConnector.DistanceMatrix(request);

			var response = Mapper.Map<DistanceMatrixResponse>(distanceMatrix);

			if (CheckResponseStatus(response.Status, response.ErrorMessage))
			{
				_requestHistoryRepository.InsertRequestHistory(distanceMatrixRequest);
			}

			return response;
		}

        public DirectionsResponse Directions(DirectionsRequest directionsRequest)
        {
            var request = Mapper.Map<Connector.Entities.DirectionsRequest>(directionsRequest);

            var directions = _directionsConnector.Directions(request);

            var response = Mapper.Map<DirectionsResponse>(directions);

            if (CheckResponseStatus(response.Status, response.ErrorMessage))
            {
            }

            return response;
        }

        /// <summary>
        /// Elevations the specified elevation request.
        /// </summary>
        /// <param name="elevationRequest">The elevation request.</param>
        /// <returns>
        /// Returns the elevation data.
        /// </returns>
        public ElevationResponse Elevation(ElevationRequest elevationRequest)
        {
            var request = Mapper.Map<Connector.Entities.ElevationRequest>(elevationRequest);

            var elevation = _elevationConnector.Elevation(request);

            var response = Mapper.Map<ElevationResponse>(elevation);

            if (CheckResponseStatus(response.Status, response.ErrorMessage))
            {
            }

            return response;
        }

        /// <summary>
        /// Timezones the specified timezone request.
        /// </summary>
        /// <param name="timezoneRequest">The timezone request.</param>
        /// <returns>
        /// Returns the timezone.
        /// </returns>
        public TimezoneResponse Timezone(TimezoneRequest timezoneRequest)
        {
            var request = Mapper.Map<Connector.Entities.TimezoneRequest>(timezoneRequest);

            var timezone = _timezoneConnector.Timezone(request);

            var response = Mapper.Map<TimezoneResponse>(timezone);

            if (CheckResponseStatus(response.Status, response.ErrorMessage))
            {
            }

            return response;
        }

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        public List<RequestHistory> GetDistanceMatrixRequestHistory()
        {
            return _requestHistoryRepository.GetAll().ToList();
        }

        /// <summary>
        /// Gets the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        public RequestHistory GetRequestHistory(Guid requestId)
        {
            return _requestHistoryRepository.GetById(requestId);
        }

        /// <summary>
        /// Replays the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the replayed request.
        /// </returns>
        public DistanceMatrixResponse ReplayRequest(Guid requestId)
        {
            var requestHistory = GetRequestHistory(requestId);
            return DistanceMatrix(requestHistory.Request);
        }

        public DeleteRequestHistoryResponse DeleteRequestHistory(Guid requestId)
        {
            try
            {
                _requestHistoryRepository.Delete(requestId);
            }
            catch (Exception exception)
            {
                return new DeleteRequestHistoryResponse
                {
                    Status = Status.UnknownError, ErrorMessage = exception.Message
                };
            }

            return new DeleteRequestHistoryResponse();
        }

        private static bool CheckResponseStatus(Status status, string errorMessage)
        {
            switch (status)
            {
                case Status.Ok:
                    return true;
                case Status.InvalidRequest:
                    throw new InvalidRequestException(errorMessage);
                case Status.MaxElementsExceeded:
                    throw new MaxElementsExceededException(errorMessage);
                case Status.OverQueryLimit:
                    throw new OverQueryLimitException(errorMessage);
                case Status.RequestDenied:
                    throw new RequestDeniedException(errorMessage);
                case Status.UnknownError:
                    throw new GoogleApiException(errorMessage);
                default:
                    return true;
            }
        }
    }
}