namespace DistanceMatrix.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Connector;
    using Data;
    using Domain.Enums;
    using Domain.Exceptions;
    using Domain.Models;

    public class DistanceMatrixEngine : IDistanceMatrixEngine
    {
        /// <summary>
        /// The distance matrix connector.
        /// </summary>
        private readonly IDistanceMatrixConnector _distanceMatrixConnector;

        /// <summary>
        /// The request history repository.
        /// </summary>
        private readonly IRequestHistoryRepository _requestHistoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceMatrixEngine" /> class.
        /// </summary>
        /// <param name="distanceMatrixConnector">The distance matrix connector.</param>
        /// <param name="requestHistoryRepository">The request history repository.</param>
        /// <exception cref="System.ArgumentNullException">distanceMatrixConnector</exception>
        public DistanceMatrixEngine(IDistanceMatrixConnector distanceMatrixConnector, IRequestHistoryRepository requestHistoryRepository)
        {
            if (distanceMatrixConnector == null)
            {
                throw new ArgumentNullException("distanceMatrixConnector");
            }

            if (requestHistoryRepository == null)
            {
                throw new ArgumentNullException("requestHistoryRepository");
            }

            _distanceMatrixConnector = distanceMatrixConnector;
            _requestHistoryRepository = requestHistoryRepository;
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

            if (response.Status == Status.Ok)
            {
                _requestHistoryRepository.InsertRequestHistory(distanceMatrixRequest);
            }

            if (response.Status == Status.InvalidRequest)
            {
                throw new InvalidRequestException(response.ErrorMessage);
            }

            if (response.Status == Status.MaxElementsExceeded)
            {
                throw new MaxElementsExceededException(response.ErrorMessage);
            }

            if (response.Status == Status.OverQueryLimit)
            {
                throw new OverQueryLimitException(response.ErrorMessage);
            }

            if (response.Status == Status.RequestDenied)
            {
                throw new RequestDeniedException(response.ErrorMessage);
            }

            if (response.Status == Status.RequestDenied)
            {
                throw new DistanceMatrixException(response.ErrorMessage);
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
    }
}