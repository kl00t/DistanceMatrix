namespace DistanceMatrix.Core
{
    using System;
    using Connector;
    using Domain.Models;

    public class DistanceMatrixEngine : IDistanceMatrixEngine
    {
        private readonly IDistanceMatrixConnector _distanceMatrixConnector;

        public DistanceMatrixEngine(IDistanceMatrixConnector distanceMatrixConnector)
        {
            if (distanceMatrixConnector == null)
            {
                throw new ArgumentNullException("distanceMatrixConnector");
            }

            _distanceMatrixConnector = distanceMatrixConnector;
        }

        public DistanceMatrixResponse Calculate(DistanceMatrixRequest distanceMatrixRequest)
        {
            return _distanceMatrixConnector.Calculate(distanceMatrixRequest.Origin, distanceMatrixRequest.Destination);
        }
    }
}