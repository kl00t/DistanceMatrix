namespace DistanceMatrix.Connector.Connectors
{
	using System;
	using System.Text;
	using System.Web;
	using Entities;
	using Interfaces;
	using Newtonsoft.Json;

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
			var address = new StringBuilder();
			address.AppendFormat("{0}/directions/json?origin={1}&destination={2}",
				ConfigurationHelper.GetAppSetting("BaseUrl"),
				HttpUtility.UrlEncode(request.origin),
				HttpUtility.UrlEncode(request.destination));

			address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("Directions_ApiKey"));

			var response = _queryExecutor.ExecuteRequest(address.ToString());

			return JsonConvert.DeserializeObject<DirectionsResponse>(response);
		}
    }
}
