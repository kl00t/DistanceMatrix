namespace DistanceMatrix.Connector.Connectors
{

    using System;
    using Entities;
    using Interfaces;

    public class DirectionsConnector : IDirectionsConnector
    {
        /// <summary>
        /// The query executor.
        /// </summary>
        private readonly IApiRequestExecutor _queryExecutor;

        public DirectionsConnector(IApiRequestExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public DirectionsResponse Directions(DirectionsRequest request)
        {
            return new DirectionsResponse();
        }
    }
}
