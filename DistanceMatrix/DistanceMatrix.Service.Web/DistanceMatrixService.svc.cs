namespace DistanceMatrix.Service.Web
{
    using System;
    using Contracts;
    using Core;
    using Domain.Models;

    public class DistanceMatrixService : IDistanceMatrixService
    {
        private readonly IDistanceMatrixEngine _distanceMatrixEngine;

        public DistanceMatrixService(IDistanceMatrixEngine distanceMatrixEngine)
        {
            _distanceMatrixEngine = distanceMatrixEngine;
        }

        public DateTime Heartbeat()
        {
            return DateTime.UtcNow;
        }

        public DistanceMatrixResponse Calculate(DistanceMatrixRequest distanceMatrixRequest)
        {
            return _distanceMatrixEngine.Calculate(distanceMatrixRequest);
        }
    }
}