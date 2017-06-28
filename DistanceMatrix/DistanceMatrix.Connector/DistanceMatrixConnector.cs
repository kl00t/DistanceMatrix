namespace DistanceMatrix.Connector
{
    using System;
    using System.Configuration;
    using System.Text;
    using System.Web;
    using Domain.Exceptions;
    using Entities;
    using Newtonsoft.Json;

    /// <summary>
    /// Distance Matrix Connector.
    /// </summary>
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

        /// <summary>
        /// Gets the application setting.
        /// </summary>
        /// <param name="appSetting">The application setting.</param>
        /// <returns></returns>
        /// <exception cref="DistanceMatrixException"></exception>
        public static string GetAppSetting(string appSetting)
        {
            try
            {
                return ConfigurationManager.AppSettings[appSetting];
            }
            catch (ConfigurationErrorsException configurationErrorsException)
            {
                throw new DistanceMatrixException(configurationErrorsException.Message, configurationErrorsException.InnerException);
            }
        }

        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="origin">The origin.</param>
        /// <param name="destination">The destination.</param>
        /// <returns>
        /// Returns distance matrix.
        /// </returns>
        public DistanceMatrix DistanceMatrix(string origin, string destination)
        {
            var address = new StringBuilder();
            var key = GetAppSetting("ApiKey");
            var baseUrl = GetAppSetting("BaseUrl");

            address.AppendFormat("{0}/distancematrix/json?origins={1}&destinations={2}&key={3}",
                baseUrl,
                HttpUtility.UrlEncode(origin),
                HttpUtility.UrlEncode(destination), 
                key);

            var response = _queryExecutor.Execute(address.ToString());

            var result = JsonConvert.DeserializeObject<DistanceMatrix>(response);

            return result;
        }
    }
}