namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;

    public class GeolocationConnector : IGeolocationConnector
    {
        private readonly IApiRequestExecutor _queryExecutor;

        public GeolocationConnector(IApiRequestExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public GeolocationResponse Geolocation(GeolocationRequest geolocationRequest)
        {
            var address = new StringBuilder();
            address.AppendFormat("{0}/geolocation/v1/geolocate?key={1}", ConfigurationHelper.GetAppSetting("BaseUrl"), ConfigurationHelper.GetAppSetting("Geolocation_ApiKey"));

            if (!string.IsNullOrEmpty(geolocationRequest.homeMobileCountryCode))
            {
                address.AppendFormat("&homeMobileCountryCode={0}", geolocationRequest.homeMobileCountryCode);
            }

            if (!string.IsNullOrEmpty(geolocationRequest.homeMobileNetworkCode))
            {
                address.AppendFormat("&homeMobileNetworkCode={0}", geolocationRequest.homeMobileNetworkCode);
            }

            if (!string.IsNullOrEmpty(geolocationRequest.radioType))
            {
                address.AppendFormat("&radioType={0}", geolocationRequest.radioType);
            }

            if (!string.IsNullOrEmpty(geolocationRequest.carrier))
            {
                address.AppendFormat("&carrier={0}", geolocationRequest.carrier);
            }

            if (!string.IsNullOrEmpty(geolocationRequest.considerIp))
            {
                address.AppendFormat("&considerIp={0}", geolocationRequest.considerIp);
            }

            ////if (!string.IsNullOrEmpty(geolocationRequest.cellTowers))
            ////{
            ////    address.AppendFormat("&cellTowers={0}", geolocationRequest.cellTowers);
            ////}

            ////if (!string.IsNullOrEmpty(geolocationRequest.wifiAccessPoints))
            ////{
            ////    address.AppendFormat("&wifiAccessPoints={0}", geolocationRequest.wifiAccessPoints);
            ////}

            var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<GeolocationResponse>(response);
        }
    }
}