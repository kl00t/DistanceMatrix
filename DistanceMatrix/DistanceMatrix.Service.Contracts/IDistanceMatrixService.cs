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

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns all the request history.
        /// </returns>
        [OperationContract]
        ServiceResponse<List<RequestHistory>> GetDistanceMatrixRequestHistory();
    }
}
