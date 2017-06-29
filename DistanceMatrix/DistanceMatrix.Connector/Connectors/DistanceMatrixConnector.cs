namespace DistanceMatrix.Connector.Connectors
{

    using System;
    using System.Text;
    using System.Web;
    using Entities;
    using Interfaces;
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
        private readonly IApiRequestExecutor _queryExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceMatrixConnector"/> class.
        /// </summary>
        /// <param name="queryExecutor">The query executor.</param>
        /// <exception cref="System.ArgumentNullException">queryExecutor</exception>
        public DistanceMatrixConnector(IApiRequestExecutor queryExecutor)
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

			address.AppendFormat("&key={0}", ConfigurationHelper.GetAppSetting("DistanceMatrix_ApiKey"));

			var response = _queryExecutor.ExecuteRequest(address.ToString());

            return JsonConvert.DeserializeObject<DistanceMatrixResponse>(response);
        }
	}
}