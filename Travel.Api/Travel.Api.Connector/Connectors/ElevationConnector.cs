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
            var address = string.Format("{0}/elevation/json?locations={1}&key={2}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(request.locations),
                request.key);

            var response = _queryExecutor.ExecuteRequest(address);

            return JsonConvert.DeserializeObject<ElevationResponse>(response);
        }
    }
}