using System;

namespace DistanceMatrix.Connector
{

    using Domain.Models;

    public class DistanceMatrixConnector : IDistanceMatrixConnector
    {
        private readonly IQueryExecutor _queryExecutor;
            
        public DistanceMatrixConnector(IQueryExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public DistanceMatrixResponse Calculate(string origin, string destination)
        {
            var url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins={0}&destinations={1}&key={2}";

            var key = "AIzaSyDA_nYjDQYKHNDMIE3HpRXtxDOU-Cpuqnc";

            var address = string.Format(url,
                origin,
                destination,
                key);

            var response = _queryExecutor.Execute(address);

            return new DistanceMatrixResponse();
        }
    }
}
