﻿namespace DistanceMatrix.Connector
{
	using System.Net;
	using Domain.Exceptions;

	public class ApiRequestExecutor : IApiRequestExecutor
    {
        public string ExecuteRequest(string address)
        {
            try
            {
				using (var webClient = new WebClient())
				{
                    var response = webClient.DownloadString(address);
				    return response;
				}
            }
            catch (WebException webException)
            {
                throw new DistanceMatrixException(webException.Message, webException.InnerException);
            }
        }
    }
}