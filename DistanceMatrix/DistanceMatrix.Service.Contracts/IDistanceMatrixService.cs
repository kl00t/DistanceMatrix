namespace DistanceMatrix.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Core.Framework;
    using Domain.Models;

    [ServiceContract]
    public interface IDistanceMatrixService
    {
        /// <summary>
        /// Provides basic heartbeat check to allow monitoring of service health.
        /// </summary>
        /// <returns>Current date and time.</returns>
        [OperationContract]
        ServiceResponse<DateTime> Heartbeat();

        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        /// <returns>
        /// Returns a distance matrix response.
        /// </returns>
        [OperationContract]
        ServiceResponse<DistanceMatrixResponse> DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest);

		[OperationContract]
		ServiceResponse<DirectionsResponse> Directions(DirectionsRequest directionsRequest);

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns all the request history.
        /// </returns>
        [OperationContract]
        ServiceResponse<List<RequestHistory>> GetDistanceMatrixRequestHistory();

        /// <summary>
        /// Gets the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>Returns request history.</returns>
        [OperationContract]
        ServiceResponse<RequestHistory> GetRequestHistory(Guid requestId);

        /// <summary>
        /// Replays the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>Returns the response from the requested history request id.</returns>
        [OperationContract]
        ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId);
    }
}
