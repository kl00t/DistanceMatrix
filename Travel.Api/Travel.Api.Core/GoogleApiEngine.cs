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

		private readonly IDirectionsConnector _directionsConnector;

		/// <summary>
		/// The request history repository.
		/// </summary>
		private readonly IRequestHistoryRepository _requestHistoryRepository;

		/// <summary>
		/// Initializes a new instance of the <see cref="GoogleApiEngine" /> class.
		/// </summary>
		/// <param name="distanceMatrixConnector">The distance matrix connector.</param>
		/// <param name="requestHistoryRepository">The request history repository.</param>
		/// <exception cref="System.ArgumentNullException">distanceMatrixConnector</exception>
		public GoogleApiEngine(
			IDistanceMatrixConnector distanceMatrixConnector,
			IRequestHistoryRepository requestHistoryRepository,
			IDirectionsConnector directionsConnector)
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

			_distanceMatrixConnector = distanceMatrixConnector;
			_requestHistoryRepository = requestHistoryRepository;
			_directionsConnector = directionsConnector;
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

		private bool CheckResponseStatus(Status Status, string ErrorMessage)
		{
			if (Status == Status.Ok)
			{
				return true;
			}

			if (Status == Status.InvalidRequest)
			{
				throw new InvalidRequestException(ErrorMessage);
			}

			if (Status == Status.MaxElementsExceeded)
			{
				throw new MaxElementsExceededException(ErrorMessage);
			}

			if (Status == Status.OverQueryLimit)
			{
				throw new OverQueryLimitException(ErrorMessage);
			}

			if (Status == Status.RequestDenied)
			{
				throw new RequestDeniedException(ErrorMessage);
			}

			if (Status == Status.RequestDenied)
			{
				throw new GoogleApiException(ErrorMessage);
			}

			return true;
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
					Status = Status.UnknownError,
					ErrorMessage = exception.Message
				};
			}

			return new DeleteRequestHistoryResponse();
		}
	}
}