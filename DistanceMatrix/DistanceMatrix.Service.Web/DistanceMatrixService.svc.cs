namespace DistanceMatrix.Service.Web
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Core;
    using Core.Framework;
    using Core.Logging;
    using Domain.Enums;
    using Domain.Models;

    public class DistanceMatrixService : BaseService, IDistanceMatrixService
    {
        /// <summary>
        /// The distance matrix engine
        /// </summary>
        private readonly IDistanceMatrixEngine _distanceMatrixEngine;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceMatrixService"/> class.
        /// </summary>
        /// <param name="distanceMatrixEngine">The distance matrix engine.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="System.ArgumentNullException">distanceMatrixEngine</exception>
        public DistanceMatrixService(IDistanceMatrixEngine distanceMatrixEngine, ILogger logger) : base(logger)
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
    }
}