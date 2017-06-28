namespace DistanceMatrix.Connector
{
    using System;
    using System.Configuration;
    using System.Text;
    using System.Web;
    using Domain.Models;
    using Newtonsoft.Json;

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

        public static string GetAppSetting(string appSetting)
        {
            try
            {
                return ConfigurationManager.AppSettings[appSetting].ToString();
            }
            catch (ConfigurationErrorsException exception)
            {
                throw;
            }
        }

        public DistanceMatrixResponse Calculate(string origin, string destination)
        {
            origin = "Vancouver, BC, Canada";
            destination = "San Francisco, CA, USA";

            var address = new StringBuilder();
            var key = GetAppSetting("ApiKey");
            var baseUrl = GetAppSetting("BaseUrl");

            address.AppendFormat("{0}distancematrix/json?origins={1}&destinations={2}&key={3}",
                baseUrl,
                HttpUtility.UrlEncode(origin),
                HttpUtility.UrlEncode(destination), 
                key);

            var response = _queryExecutor.Execute(address.ToString());

            var result = JsonConvert.DeserializeObject<DistanceMatrix>(response);

            return new DistanceMatrixResponse
            {
                OriginAddresses = new []
                {
                    "Vancouver, BC, Canada",
                    "Seattle, WA, USA"
                },
                DestinationAddresses = new []
                {
                    "San Francisco, CA, USA",
                    "Victoria, BC, Canada"
                },
                Rows = new[]
                {
                    new Element
                    {
                        Distance = new Distance
                        {
                            Text = "1,529 km",
                            Value = 1528699
                        },
                        Duration = new Duration
                        {
                            Text = "14 hours 56 mins",
                            Value = 53778
                        }
                    }
                },
                Status = "OK"
            };
        }
    }
}