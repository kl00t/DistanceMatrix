namespace DistanceMatrix.Core
{
    using System;

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

        public string Calculate()
        {
            return _distanceMatrixConnector.Calculate();
        }
    }
}