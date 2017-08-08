namespace Travel.Api.Service.Contracts
{

    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Core.Framework;
    using Domain.Models;

    [ServiceContract]
    public interface IGoogleApiService
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

        /// <summary>
        /// Directionses the specified directions request.
        /// </summary>
        /// <param name="directionsRequest">The directions request.</param>
        /// <returns>
        /// Returns the directions.
        /// </returns>
        [OperationContract]
		ServiceResponse<DirectionsResponse> Directions(DirectionsRequest directionsRequest);

        /// <summary>
        /// Elevations the specified elevation request.
        /// </summary>
        /// <param name="elevationRequest">The elevation request.</param>
        /// <returns>Returns the elevation data.</returns>
        [OperationContract]
        ServiceResponse<ElevationResponse> Elevation(ElevationRequest elevationRequest);

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

		[OperationContract]
		ServiceResponse<DeleteRequestHistoryResponse> DeleteRequestHistory(Guid requestId);

		/// <summary>
		/// Replays the request.
		/// </summary>
		/// <param name="requestId">The request identifier.</param>
		/// <returns>Returns the response from the requested history request id.</returns>
		[OperationContract]
        ServiceResponse<DistanceMatrixResponse> ReplayRequest(Guid requestId);
    }
}
