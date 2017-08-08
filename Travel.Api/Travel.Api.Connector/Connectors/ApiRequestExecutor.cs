namespace Travel.Api.Connector.Connectors
{

    using System;
    using System.Net;
    using Domain.Exceptions;
    using Interfaces;

    public class ApiRequestExecutor : IApiRequestExecutor
    {
		public string ExecuteRequest(string address)
		{
			var uriBuilder = new UriBuilder(address);
			if (Convert.ToBoolean(ConfigurationHelper.GetAppSetting("UseSSL")))
			{
				uriBuilder.Scheme = "https";
			}

			address = string.Format("{0}://{1}{2}{3}",
				uriBuilder.Scheme,
				uriBuilder.Host,
				uriBuilder.Path,
				uriBuilder.Query);

			try
            {
				using (var webClient = new WebClient())
				{
					return webClient.DownloadString(address);
				}
            }
            catch (WebException webException)
            {
                throw new GoogleApiException(webException.Message, webException.InnerException);
            }
        }
    }
}