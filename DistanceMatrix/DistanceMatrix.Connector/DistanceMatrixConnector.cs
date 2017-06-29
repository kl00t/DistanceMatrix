﻿namespace DistanceMatrix.Connector
{
    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Newtonsoft.Json;

    /// <summary>
    /// Distance Matrix Connector.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DistanceMatrixConnector : IDistanceMatrixConnector
    {
        /// <summary>
        /// The query executor.
        /// </summary>
        private readonly IQueryExecutor _queryExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceMatrixConnector"/> class.
        /// </summary>
        /// <param name="queryExecutor">The query executor.</param>
        /// <exception cref="System.ArgumentNullException">queryExecutor</exception>
        public DistanceMatrixConnector(IQueryExecutor queryExecutor)
        {
            if (queryExecutor == null)
            {
                throw new ArgumentNullException("queryExecutor");
            }

            _queryExecutor = queryExecutor;
        }

        public DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest request)
        {
            var address = new StringBuilder();

            address.AppendFormat("{0}/distancematrix/json?origins={1}&destinations={2}",
                ConfigurationHelper.GetAppSetting("BaseUrl"),
				HttpUtility.UrlEncode(request.origins),
				HttpUtility.UrlEncode(request.destinations));

			if (!string.IsNullOrEmpty(request.mode))
			{
				address.AppendFormat("&mode={0}", request.mode);
			}

			if (!string.IsNullOrEmpty(request.units))
			{
				address.AppendFormat("&units={0}", request.units);
			}

            if (Convert.ToBoolean(ConfigurationHelper.GetAppSetting("UseSSL")))
            {
                address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("ApiKey"));
            }

			var response = _queryExecutor.Execute(address.ToString());

            var result = JsonConvert.DeserializeObject<DistanceMatrixResponse>(response);

            return result;
        }
	}
}