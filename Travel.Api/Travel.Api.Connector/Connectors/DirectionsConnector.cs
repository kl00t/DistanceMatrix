namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;

    public class DirectionsConnector : IDirectionsConnector
    {
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
            var address = string.Format("{0}/directions/json?origin={1}&destination={2}&key={3}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(request.origin),
                HttpUtility.UrlEncode(request.destination),
                request.key);

            var response = _queryExecutor.ExecuteRequest(address.ToString());

			return JsonConvert.DeserializeObject<DirectionsResponse>(response);
		}
    }
}
