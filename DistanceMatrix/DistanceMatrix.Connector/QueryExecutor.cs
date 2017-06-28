namespace DistanceMatrix.Connector
{

    using System.IO;
    using System.Net;
    using System.Text;

    public class QueryExecutor : IQueryExecutor
    {
        public string Execute(string address)
        {
            address = address.Replace(" ", "+");

            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add("Content-Type", "application/xml");
                var response = webClient.DownloadString(address);
                return response;
            }
        }
    }
}