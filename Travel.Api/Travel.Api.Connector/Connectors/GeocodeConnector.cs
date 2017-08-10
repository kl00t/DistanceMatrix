namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using System.Web;
    using BingMapsRESTToolkit;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;
    using GeocodeRequest = Entities.GeocodeRequest;
    using ReverseGeocodeRequest = Entities.ReverseGeocodeRequest;

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

        public GeocodeResponse ReverseGeocode(ReverseGeocodeRequest reverseGeocodeRequest)
        {
            var address = new StringBuilder();
            address.AppendFormat("{0}/geocode/json?latlng={1}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(reverseGeocodeRequest.latlng));

            address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("Geocode_ApiKey"));

            var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<GeocodeResponse>(response);
        }

        public BingMapsRESTToolkit.Location GeocodeRequest(BingMapsRESTToolkit.GeocodeRequest geocodeRequest)
        {
            //Process the request by using the ServiceManager.
            var response = ServiceManager.GetResponseAsync(geocodeRequest)
                .GetAwaiter()
                .GetResult();

            if (response == null || response.ResourceSets == null || response.ResourceSets.Length <= 0 ||
                response.ResourceSets[0].Resources == null || response.ResourceSets[0].Resources.Length <= 0)
            {
                throw new Exception();
            }

            return response.ResourceSets[0].Resources[0] as BingMapsRESTToolkit.Location;
        }
    }
}