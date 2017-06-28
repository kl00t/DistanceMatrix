namespace DistanceMatrix.Service.Contracts
{
    using System;
    using System.ServiceModel;
    using Domain.Models;

    [ServiceContract]
    public interface IDistanceMatrixService
    {
        /// <summary>
        /// Provides basic heartbeat check to allow monitoring of service health.
        /// </summary>
        /// <returns>Current date and time.</returns>
        [OperationContract]
        DateTime Heartbeat();

        [OperationContract]
        DistanceMatrixResponse Calculate(DistanceMatrixRequest distanceMatrixRequest);
    }
}
