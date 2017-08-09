namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;

    public class GeocodeConnector : IGeocodeConnector
    {
        private readonly IApiRequestExecutor _queryExecutor;

        public GeocodeConnector(IApiRequestExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public GeocodeResponse Geocode(GeocodeRequest geocodeRequest)
        {
            var address = new StringBuilder();
            address.AppendFormat("{0}/geocode/json?address={1}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(geocodeRequest.address));

            if (!string.IsNullOrEmpty(geocodeRequest.language))
            {
                address.AppendFormat("&language={0}", geocodeRequest.language.ToLower());
            }

            address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("Geocode_ApiKey"));

            var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<GeocodeResponse>(response);
        }
    }
}