namespace DistanceMatrix.Connector
{
    using System.Net;
    using Domain.Exceptions;

    public class QueryExecutor : IQueryExecutor
    {
        public string Execute(string address)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    return webClient.DownloadString(address);
                }
            }
            catch (WebException webException)
            {
                throw new DistanceMatrixException(webException.Message, webException.InnerException);
            }
        }
    }
}