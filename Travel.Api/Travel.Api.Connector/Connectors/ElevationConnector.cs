namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;

    public class ElevationConnector : IElevationConnector
    {
        private readonly IApiRequestExecutor _queryExecutor;

        public ElevationConnector(IApiRequestExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public ElevationResponse Elevation(ElevationRequest request)
        {
            var address = new StringBuilder();
            address.AppendFormat("{0}/elevation/json?locations={1}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(request.locations));

            address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("Elevation_ApiKey"));

            var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<ElevationResponse>(response);
        }
    }
}