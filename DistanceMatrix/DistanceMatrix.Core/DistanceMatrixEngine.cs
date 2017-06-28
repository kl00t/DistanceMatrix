namespace DistanceMatrix.Core
{
    using System;
    using AutoMapper;
    using Connector;
    using Domain.Models;

    public class DistanceMatrixEngine : IDistanceMatrixEngine
    {
        /// <summary>
        /// The distance matrix connector.
        /// </summary>
        private readonly IDistanceMatrixConnector _distanceMatrixConnector;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceMatrixEngine"/> class.
        /// </summary>
        /// <param name="distanceMatrixConnector">The distance matrix connector.</param>
        /// <exception cref="System.ArgumentNullException">distanceMatrixConnector</exception>
        public DistanceMatrixEngine(IDistanceMatrixConnector distanceMatrixConnector)
        {
            if (distanceMatrixConnector == null)
            {
                throw new ArgumentNullException("distanceMatrixConnector");
            }

            _distanceMatrixConnector = distanceMatrixConnector;
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
            var distanceMatrix = _distanceMatrixConnector.DistanceMatrix(distanceMatrixRequest.Origin, distanceMatrixRequest.Destination);

            var response = Mapper.Map<DistanceMatrixResponse>(distanceMatrix);

            return response;
        }
    }
}