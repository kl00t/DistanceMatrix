namespace Travel.Api.Connector.Connectors
{
    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Interfaces;
    using Newtonsoft.Json;

    public class TimezoneConnector : ITimezoneConnector
    {
        private readonly IApiRequestExecutor _queryExecutor;

        public TimezoneConnector(IApiRequestExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public TimezoneResponse Timezone(TimezoneRequest timezoneRequest)
        {
            var address = new StringBuilder();
            address.AppendFormat("{0}/timezone/json?location={1}&timestamp={2}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
                HttpUtility.UrlEncode(timezoneRequest.location),
                HttpUtility.UrlEncode(timezoneRequest.timestamp));

            address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("Timezone_ApiKey"));

            var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<TimezoneResponse>(response);
        }
    }
}